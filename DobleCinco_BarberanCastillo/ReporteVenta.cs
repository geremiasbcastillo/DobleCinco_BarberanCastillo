using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace DobleCinco_BarberanCastillo
{
    public partial class ReporteVenta : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        public ReporteVenta()
        {
            InitializeComponent();
        }

       

        private void LVentas_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarDatos()
        {
            using var conn = new SqlConnection(connectionString);
            // Selecciona solo las columnas que quieres mostrar y les pones alias para los headers
            string query = @"SELECT 
                        v.id_venta AS 'Nro Venta',
                        v.venta_fecha AS 'Fecha',
                        u.nombre_usuario AS 'Vendedor',
                        c.nombre_cliente + ' ' + c.apellido_cliente AS 'Cliente'
                     FROM venta v
                     INNER JOIN usuario u ON u.id_usuario = v.id_usuarios
                     INNER JOIN cliente c ON c.id_cliente = v.id_cliente";

            List<SqlParameter> parametros = new List<SqlParameter>();

            // (Asumo que 3 es 'Vendedor' y PerfilId es el nombre correcto)
            if (Models.Sesion.UsuarioActual.PerfilId == 3)
            {
                query += " WHERE v.id_usuarios = @IdUsuario";

                // --- CORRECCIÓN LÓGICA ---
                // Debes pasar el ID del Usuario, no el ID del Perfil.
                // Asegúrate de que 'id_usuario' sea el nombre correcto de tu propiedad en el modelo Sesion.
                parametros.Add(new SqlParameter("@IdUsuario", Models.Sesion.UsuarioActual.Id));
            }

            var da = new SqlDataAdapter(query, conn);

            if (parametros.Count > 0)
            {
                da.SelectCommand.Parameters.AddRange(parametros.ToArray());
            }

            var dt = new DataTable();
            da.Fill(dt);
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = dt;
            dgvVentas.Refresh();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ReporteVenta_Load(object sender, EventArgs e)
        {
            CargarDatos();

            // Verifica si la columna ya existe para evitar duplicados
            if (!dgvVentas.Columns.Contains("DescargarFactura"))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = "DescargarFactura",
                    HeaderText = "Factura",
                    Text = "Descargar",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dgvVentas.Columns.Add(btnCol);
            }

            dgvVentas.CellClick += dgvVentas_CellClick;
        }

        private void BGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaDesde = DTFechaDesde.Text.Trim();
                string fechaHasta = DTFechaHasta.Text.Trim();

                string query = @"SELECT 
                                    v.id_venta AS 'Nro Venta',
                                    v.venta_fecha AS 'Fecha',
                                    u.nombre_usuario AS 'Vendedor',
                                    c.nombre_cliente + ' ' + c.apellido_cliente AS 'Cliente'
                                 FROM venta v
                                 INNER JOIN usuario u ON u.id_usuario = v.id_usuarios
                                 INNER JOIN cliente c ON c.id_cliente = v.id_cliente";

                List<string> condiciones = new();
                SqlCommand cmd = new SqlCommand();


                if (Models.Sesion.UsuarioActual.PerfilId == 3) // Si es Vendedor
                {
                    condiciones.Add("v.id_usuarios = @IdUsuarioLogueado");
                    cmd.Parameters.AddWithValue("@IdUsuarioLogueado", Models.Sesion.UsuarioActual.Id);
                }
                if (!string.IsNullOrEmpty(fechaDesde))
                {
                    condiciones.Add("v.venta_fecha >= @FechaDesde");
                    DateTime fechaDesdePar = DateTime.Parse(DTFechaDesde.Text).Date;
                    cmd.Parameters.AddWithValue("@FechaDesde", fechaDesdePar);
                }
                if (!string.IsNullOrEmpty(fechaHasta))
                {
                    condiciones.Add("v.venta_fecha < @FechaHasta");
                    DateTime fechaHastaSiguiente = DateTime.Parse(DTFechaHasta.Text).Date.AddDays(1);
                    cmd.Parameters.AddWithValue("@FechaHasta", fechaHastaSiguiente);
                }
                if (condiciones.Count > 0)
                    query += " WHERE " + string.Join(" AND ", condiciones);

                cmd.CommandText = query;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    cmd.Connection = conn;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvVentas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChVentaPorProducto_Click(object sender, EventArgs e)
        {

        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVentas.Columns[e.ColumnIndex].Name == "DescargarFactura")
            {
                var idVenta = dgvVentas.Rows[e.RowIndex].Cells["Nro Venta"].Value;
                if (idVenta != null)
                {
                    int idCliente = ObtenerIdClientePorVenta(Convert.ToInt32(idVenta));
                    DescargarFacturaPDF(Convert.ToInt32(idVenta), idCliente);
                }
            }
        }

        private int ObtenerIdClientePorVenta(int idVenta)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT id_cliente FROM venta WHERE id_venta = @idVenta", conn))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private void DescargarFacturaVenta(int idVenta, int idCliente)
        {
            // Aquí deberías reutilizar tu lógica existente para generar/descargar la factura
            // Por ejemplo, podrías mostrar el reporte o guardar el PDF
            // Ejemplo: Mostrar un MessageBox (reemplaza por tu lógica real)
            MessageBox.Show($"Descargando factura para venta #{idVenta}", "Descargar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DescargarFacturaPDF(idVenta, idCliente); // Llama a la función para descargar el PDF
        }

        private void DescargarFacturaPDF(int idVenta, int idCliente)
        {
            string nombreCliente = "";
            string apellidoCliente = "";
            string dniCliente = "";
            string domicilioCliente = "";
            string telefonoCliente = "";
            List<(string Producto, int Cantidad, decimal Precio)> productos = new();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Datos del cliente
                using (var cmd = new SqlCommand("SELECT nombre_cliente, apellido_cliente, dni_cliente, domicilio_cliente, telefono_cliente FROM cliente WHERE id_cliente = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", idCliente);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreCliente = reader.GetString(0);
                            apellidoCliente = reader.GetString(1);
                            dniCliente = reader.GetValue(2).ToString();
                            domicilioCliente = reader.GetString(3);
                            telefonoCliente = reader.GetValue(4).ToString();
                        }
                    }
                }

                // Productos de la venta
                using (var cmd = new SqlCommand(
                    @"SELECT p.descripcion_producto, d.cantidad_detalle, d.precio_detalle
                      FROM detalle_ventas d
                      INNER JOIN producto p ON d.id_producto = p.id_producto
                      WHERE d.id_ventas = @idVenta", conn))
                {
                    cmd.Parameters.AddWithValue("@idVenta", idVenta);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add((
                                reader.GetString(0),
                                reader.GetInt32(1),
                                Convert.ToDecimal(reader.GetValue(2))
                            ));
                        }
                    }
                }
            }

            // Crear el PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = $"Factura_{idVenta}.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    doc.Add(new Paragraph("Factura de Venta"));
                    doc.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy}"));
                    doc.Add(new Paragraph($"Cliente: {nombreCliente} {apellidoCliente}"));
                    doc.Add(new Paragraph($"DNI: {dniCliente}"));
                    doc.Add(new Paragraph($"Domicilio: {domicilioCliente}"));
                    doc.Add(new Paragraph($"Teléfono: {telefonoCliente}"));
                    doc.Add(new Paragraph(" "));

                    PdfPTable table = new PdfPTable(3);
                    table.AddCell("Producto");
                    table.AddCell("Cantidad");
                    table.AddCell("Precio");

                    decimal total = 0;
                    foreach (var item in productos)
                    {
                        table.AddCell(item.Producto);
                        table.AddCell(item.Cantidad.ToString());
                        table.AddCell(item.Precio.ToString("C"));
                        total += item.Precio * item.Cantidad;
                    }

                    doc.Add(table);
                    doc.Add(new Paragraph(" "));
                    doc.Add(new Paragraph($"Total: {total:C}"));

                    doc.Close();
                }

                MessageBox.Show("Factura PDF generada correctamente.", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
