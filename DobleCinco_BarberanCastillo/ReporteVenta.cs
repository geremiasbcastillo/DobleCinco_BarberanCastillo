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

namespace DobleCinco_BarberanCastillo
{
    public partial class ReporteVenta : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        public ReporteVenta()
        {
            InitializeComponent();
        }

        private void CargarGraficoCategorias()
        {
            // 1. Cadena de conexión
            using var conn = new SqlConnection(connectionString);

            // 2. La consulta SQL
            string query = @"
                            SELECT
                                c.nombre_categoria AS Categoria,
                                SUM(dv.cantidad_detalle) AS TotalVendido
                            FROM
                                detalle_ventas AS dv
                            JOIN
                                producto AS p ON dv.id_producto = p.id_producto
                            JOIN
                                categoria AS c ON p.id_categoria = c.id_categoria
                            GROUP BY
                                c.nombre_categoria
                            ORDER BY
                                TotalVendido DESC;
                            ";

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del gráfico: " + ex.Message);
                return;
            }

            ChVentaPorProducto.Series.Clear();
            ChVentaPorProducto.Titles.Clear();

            // Si quieres ocultar el borde exterior del control Chart (el control en sí)
            ChVentaPorProducto.BorderSkin.SkinStyle = BorderSkinStyle.None;
            ChVentaPorProducto.BorderlineWidth = 0;

            ChartArea chartArea = ChVentaPorProducto.ChartAreas[0];

            // Quitar el borde (BorderWidth = 0) o hacerlo transparente
            chartArea.BorderWidth = 0;
            chartArea.BackColor = Color.Transparent;

            Title mainTitle = ChVentaPorProducto.Titles.Add("Categorías Más Vendidas");
            mainTitle.Font = new Font("Arial", 16, FontStyle.Bold); // Ejemplo: Arial, tamaño 16, negrita
            mainTitle.ForeColor = Color.Black;

            Series series = new Series("Categorias");
            series.ChartType = SeriesChartType.Pie; // Gráfico de Columnas

            // Usamos el DataTable 'dt' que llenamos desde la BD
            series.Points.DataBind(dt.AsEnumerable(), "Categoria", "TotalVendido", "");

            series.IsValueShownAsLabel = true; // Mostrar el número en cada columna
            ChVentaPorProducto.Series.Add(series);
            ChVentaPorProducto.DataBind();
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
            CargarGraficoCategorias();
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
                    cmd.Parameters.AddWithValue("@IdUsuarioLogueado", Models.Sesion.UsuarioActual.PerfilId);
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
    }
}
