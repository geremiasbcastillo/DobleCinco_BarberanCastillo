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
    public partial class ReporteVendedores : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        private bool filtrosAplicados = false;
        public ReporteVendedores()
        {
            InitializeComponent();
        }

        private void ReporteVendedores_Load(object sender, EventArgs e)
        {
            ActualizarGraficoVisible();
        }

        private void CargarGraficoVendedoresPorMonto(DateTime? fechaDesde, DateTime? fechaHasta)
        {
            // 1. Cadena de conexión
            using var conn = new SqlConnection(connectionString);

            // 2. La consulta SQL para el TOP 5 Vendedores
            string query = @"
                            SELECT TOP 5
                                u.nombre_usuario + ' ' + u.apellido_usuario AS VendedorNombre,
                                SUM(dv.cantidad_detalle * dv.precio_detalle) AS TotalVendidoMonto
                            FROM
                                usuario AS u
                            JOIN
                                venta AS v ON u.id_usuario = v.id_usuarios
                            JOIN
                                detalle_ventas AS dv ON v.id_venta = dv.id_ventas
                            WHERE
                                (@FechaDesde IS NULL OR v.venta_fecha >= @FechaDesde)
                            AND
                                (@FechaHasta IS NULL OR v.venta_fecha <= @FechaHasta)
                            GROUP BY
                                u.nombre_usuario, u.apellido_usuario
                            ORDER BY
                                TotalVendidoMonto DESC;
                            ";

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // El manejo de parámetros es idéntico
                        if (fechaDesde.HasValue)
                            cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde.Value);
                        else
                            cmd.Parameters.AddWithValue("@FechaDesde", DBNull.Value);

                        if (fechaHasta.HasValue)
                            cmd.Parameters.AddWithValue("@FechaHasta", fechaHasta.Value);
                        else
                            cmd.Parameters.AddWithValue("@FechaHasta", DBNull.Value);

                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos del gráfico de Vendedores: " + ex.Message);
                return;
            }

            // 3. Configuración del NUEVO gráfico (CHVendedores)
            CHVendedores.Series.Clear();
            CHVendedores.Titles.Clear();
            CHVendedores.ChartAreas[0].BackColor = Color.Transparent;

            // Opcional: Limpiar ejes
            CHVendedores.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            CHVendedores.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            CHVendedores.ChartAreas[0].AxisX.Interval = 1;

            // 4. Añadir Título
            Title mainTitle = CHVendedores.Titles.Add("TOP 5 Vendedores (Por Monto)");
            mainTitle.Font = new Font("Arial", 16, FontStyle.Bold);

            // 5. Crear la Serie
            Series series = new Series("Monto vendido por vendedor");
            series.IsValueShownAsLabel = true;
            series.ChartType = SeriesChartType.Column;
            series.IsXValueIndexed = true; // La corrección para el Eje X

            // 6. Enlazar los datos (¡CAMBIAN LOS NOMBRES DE COLUMNAS!)
            series.Points.DataBind(dt.AsEnumerable(),
                                    "VendedorNombre",      // Columna para el eje X
                                    "TotalVendidoMonto",   // Columna para el eje Y
                                    "");

            // 7. Añadir la serie al gráfico
            CHVendedores.Series.Add(series);
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            filtrosAplicados = true;

            // 2. Recargamos el gráfico que esté visible
            ActualizarGraficoVisible();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            filtrosAplicados = false;
            ActualizarGraficoVisible();
        }
        private void ActualizarGraficoVisible()
        {
            DateTime? fechaDesde = null;
            DateTime? fechaHasta = null;

            // Si el "interruptor" está encendido, toma las fechas
            if (filtrosAplicados)
            {
                fechaDesde = DTPDesde.Value.Date;
                fechaHasta = DTPHasta.Value.Date.AddDays(1).AddTicks(-1); // 23:59:59
            }

            // Llama a la función de carga pasándole las fechas (o null)
            CargarGraficoVendedoresPorMonto(fechaDesde, fechaHasta);
        }
    }
}
