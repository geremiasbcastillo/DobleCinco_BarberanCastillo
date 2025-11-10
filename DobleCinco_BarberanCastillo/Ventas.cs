using DobleCinco_BarberanCastillo.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;// Reemplaza el using al inicio del archivo

namespace DobleCinco_BarberanCastillo
{
    public partial class Ventas : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        int id_vendedor;
        public Ventas()
        {
            InitializeComponent();
            ConfigurarDgvDetalleVenta();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            var vendedor = Models.Sesion.UsuarioActual;
            if (vendedor != null)
            {
                id_vendedor = vendedor.Id;
            }
            DeshabilitarCamposCliente();
        }

        private void TBVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TBVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            BBuscarProducto.Enabled = false;
            string filtro_nombre = TBProducto.Text.Trim();
            string filtro_desc = TBDescripcion.Text.Trim();
            var formBusqueda = new BuscarProducto(filtro_nombre, filtro_desc);

            formBusqueda.ProductoSeleccionado += (id, descripcion, precio) =>
            {
                // =========================================================
                // 1. REVISAR SI EL PRODUCTO YA EXISTE
                // =========================================================
                bool yaExiste = false;
                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    // Omitir la fila nueva (la que está vacía al final)
                    if (row.IsNewRow) continue;

                    // Comparar el ID del producto seleccionado (int)
                    // con el ID de la celda de la grilla (object)
                    if (row.Cells["id_producto"].Value != null && Convert.ToInt32(row.Cells["id_producto"].Value) == id)
                    {
                        yaExiste = true;
                        break; // Salimos del bucle, ya lo encontramos
                    }
                }

                if (yaExiste)
                {
                    // Si ya existe, mostrar el mensaje de advertencia
                    MessageBox.Show("Ese producto ya está agregado.", "Producto Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Si no existe, agregarlo a la grilla
                    dgvDetalleVenta.Rows.Add(id, descripcion, 1, precio);
                }

                // Limpieza (esto se hace siempre, exista o no)
                TBDescripcion.Clear();
                TBDescripcion.Focus();
                BBuscarProducto.Enabled = true;
            };

            formBusqueda.FormClosed += (s, args) => BBuscarProducto.Enabled = true;

            formBusqueda.Show();

            formBusqueda.FormClosed += (s, args) => BBuscarProducto.Enabled = true;

            formBusqueda.Show();
        }

        private void ConfigurarDgvDetalleVenta()
        {
            // Asegúrate de que el control no esté completamente en ReadOnly
            dgvDetalleVenta.ReadOnly = false;

            // Si usas nombres de columnas, ajústalos a los tuyos
            dgvDetalleVenta.Columns["id_producto"].ReadOnly = true;
            dgvDetalleVenta.Columns["producto_descripcion"].ReadOnly = true;
            dgvDetalleVenta.Columns["producto_cantidad"].ReadOnly = false;
            dgvDetalleVenta.Columns["producto_precio"].ReadOnly = true;

            // Opcional: facilitar la edición al entrar en la celda
            dgvDetalleVenta.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void BVenta_Click(object sender, EventArgs e)
        {
            using (SqlConnection outerConn = new SqlConnection(connectionString)) 
            {
                try
                {
                    if (dgvDetalleVenta.Rows.Count == 0 || dgvDetalleVenta.Rows[0].IsNewRow)
                    {
                        MessageBox.Show("Debe agregar al menos un producto a la venta.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validar cantidades > 0
                    foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (!int.TryParse(row.Cells["producto_cantidad"].Value?.ToString(), out int qty) || qty <= 0)
                        {
                            MessageBox.Show("La cantidad de los productos debe ser mayor a cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Obtener id_cliente a partir del DNI mostrado en el formulario
                    if (!int.TryParse(TBDni.Text, out int dniCliente) || dniCliente == 0)
                    {
                        MessageBox.Show("Cliente no seleccionado o DNI inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if(CUFormaDePago.IdSeleccionado <= 0)
                    {
                        MessageBox.Show("Debe seleccionar una forma de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (var innerConn = new SqlConnection(connectionString)) // Renombrado a 'innerConn'
                    {
                        innerConn.Open();
                        using (var tran = innerConn.BeginTransaction())
                        {
                            try
                            {
                                // Buscar id_cliente por DNI
                                int idCliente;
                                using (var cmd = new SqlCommand("SELECT id_cliente FROM cliente WHERE dni_cliente = @dni", innerConn, tran))
                                {
                                    cmd.Parameters.AddWithValue("@dni", dniCliente);
                                    var obj = cmd.ExecuteScalar();
                                    if (obj == null)
                                    {
                                        MessageBox.Show("Cliente no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        tran.Rollback();
                                        return;
                                    }
                                    idCliente = Convert.ToInt32(obj);
                                }

                                // Insertar venta y obtener id_venta
                                int idVenta;
                                int idForma = CUFormaDePago.IdSeleccionado;
                                using (var cmd = new SqlCommand("INSERT INTO venta (id_usuarios, id_forma, id_cliente) VALUES (@usuario, @forma, @cliente); SELECT CAST(SCOPE_IDENTITY() AS INT);", innerConn, tran))
                                {
                                    cmd.Parameters.AddWithValue("@usuario", id_vendedor);
                                    cmd.Parameters.AddWithValue("@forma", idForma);
                                    cmd.Parameters.AddWithValue("@cliente", idCliente);
                                    idVenta = (int)cmd.ExecuteScalar()!;
                                }

                                using (var cmdDetalle = new SqlCommand("", innerConn, tran))
                                using (var cmdUpdate = new SqlCommand("", innerConn, tran))
                                {
                                    cmdDetalle.CommandText = @"INSERT INTO detalle_ventas (cantidad_detalle, precio_detalle, id_producto, id_ventas, id_cliente)
                                               VALUES (@cantidad, @precio, @idproducto, @idventa, @idcliente)";
                                    cmdDetalle.Parameters.Add(new SqlParameter("@cantidad", System.Data.SqlDbType.Int));
                                    cmdDetalle.Parameters.Add(new SqlParameter("@precio", System.Data.SqlDbType.Float));
                                    cmdDetalle.Parameters.Add(new SqlParameter("@idproducto", System.Data.SqlDbType.Int));
                                    cmdDetalle.Parameters.AddWithValue("@idventa", idVenta);
                                    cmdDetalle.Parameters.AddWithValue("@idcliente", idCliente);

                                    cmdUpdate.CommandText = @"UPDATE producto
                                      SET cantidad_producto = cantidad_producto - @qty
                                      WHERE id_producto = @idproduct AND cantidad_producto >= @qty";

                                    cmdUpdate.Parameters.Add(new SqlParameter("@qty", System.Data.SqlDbType.Int));
                                    cmdUpdate.Parameters.Add(new SqlParameter("@idproduct", System.Data.SqlDbType.Int));

                                    foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                                    {
                                        if (row.IsNewRow) continue;
                                        int idProd = Convert.ToInt32(row.Cells["id_producto"].Value);
                                        string nombreProd = row.Cells["producto_descripcion"].Value.ToString();
                                        int cantidad = Convert.ToInt32(row.Cells["producto_cantidad"].Value);
                                        decimal precio = Convert.ToDecimal(row.Cells["producto_precio"].Value);

                                        cmdUpdate.Parameters["@qty"].Value = cantidad;
                                        cmdUpdate.Parameters["@idproduct"].Value = idProd;
                                        int updated = cmdUpdate.ExecuteNonQuery();
                                        if (updated == 0)
                                        {
                                            MessageBox.Show($"Stock insuficiente para el producto {nombreProd}.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            tran.Rollback();
                                            return;
                                        }

                                        cmdDetalle.Parameters["@cantidad"].Value = cantidad;
                                        cmdDetalle.Parameters["@precio"].Value = (double)precio;
                                        cmdDetalle.Parameters["@idproducto"].Value = idProd;
                                        cmdDetalle.ExecuteNonQuery();
                                    }
                                }

                                tran.Commit();
                                MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Preguntar si desea descargar la factura
                                var result = MessageBox.Show("¿Desea descargar la factura en PDF?", "Descargar factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    DescargarFacturaPDF(idVenta, idCliente); // Implementa este método para generar el PDF
                                }

                                // Limpiar UI si procede
                                dgvDetalleVenta.Rows.Clear();
                                TBNombre.Clear();
                                TBApellido.Clear();
                                TBDni.Clear();
                                TBDomicilio.Clear();
                                TBTelefono.Clear();
                            }
                            catch (Exception ex)
                            {
                                try { tran.Rollback(); } catch { }
                                MessageBox.Show("Error al guardar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {

            string filtro = TBDniSearch.Text.Trim();
            var formBusqueda = new BuscarCliente(filtro);

            formBusqueda.ClienteSeleccionado += (nombre, apellido, dni, domicilio, telefono) =>
            {
                TBNombre.Text = nombre;
                TBApellido.Text = apellido;
                TBDni.Text = dni;
                TBDomicilio.Text = domicilio;
                TBTelefono.Text = telefono;
            };

            formBusqueda.FormClosed += (s, args) => BBuscarProducto.Enabled = true;

            formBusqueda.Show();
        }

        private void HabilitarCamposCliente()
        {
            TBNombre.Enabled = true;
            TBApellido.Enabled = true;
            TBDni.Enabled = true;
            TBDomicilio.Enabled = true;
            TBTelefono.Enabled = true;
        }

        private void DeshabilitarCamposCliente()
        {
            TBNombre.Enabled = false;
            TBApellido.Enabled = false;
            TBDni.Enabled = false;
            TBDomicilio.Enabled = false;
            TBTelefono.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HabilitarCamposCliente();
            TBNombre.Clear();
            TBApellido.Clear();
            TBDni.Clear();
            TBDomicilio.Clear();
            TBTelefono.Clear();
            TBNombre.Focus();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCamposCliente();
            LimpiarCamposCliente();
        }

        private void LimpiarCamposCliente()
        {
            TBNombre.Clear();
            TBApellido.Clear();
            TBDni.Clear();
            TBDomicilio.Clear();
            TBTelefono.Clear();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            // Validar que el campo DNI no esté vacío
            if (string.IsNullOrWhiteSpace(TBDni.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBDni.Focus();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // 1. Verificar si el DNI ya existe
                    string checkQuery = "SELECT COUNT(*) FROM Cliente WHERE dni_cliente = @Dni";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Dni", TBDni.Text);

                    conn.Open();
                    int count = (int)checkCmd.ExecuteScalar();
                    conn.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("El DNI ingresado ya está registrado. Por favor, ingresa uno diferente.", "DNI duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TBDni.Clear();
                        TBDni.Focus();
                        return;
                    }

                    // 2. Insertar el cliente si no hay duplicados
                    string query = @"INSERT INTO Cliente (nombre_cliente, apellido_cliente, dni_cliente, domicilio_cliente, telefono_cliente)
                             VALUES (@Nombre, @Apellido, @Dni, @Domicilio, @Telefono)";
                    SqlCommand cmdInsert = new SqlCommand(query, conn);
                    cmdInsert.Parameters.AddWithValue("@Nombre", TBNombre.Text);
                    cmdInsert.Parameters.AddWithValue("@Apellido", TBApellido.Text);
                    cmdInsert.Parameters.AddWithValue("@Dni", TBDni.Text);
                    cmdInsert.Parameters.AddWithValue("@Domicilio", TBDomicilio.Text);
                    cmdInsert.Parameters.AddWithValue("@Telefono", TBTelefono.Text);

                    conn.Open();
                    cmdInsert.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposCliente();
                    DeshabilitarCamposCliente();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCamposCliente();
                }
            }
        }

        private void DescargarFacturaPDF(int idVenta, int idCliente)
        {
            // 1. Obtener los datos del cliente y la venta desde la base de datos
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

            // 2. Crear el PDF
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

        private void CUFormaDePago_Load(object sender, EventArgs e)
        {

        }
    }
}

