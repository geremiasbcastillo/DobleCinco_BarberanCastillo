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
    public partial class ReporteProducto : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        private bool filtrosAplicados = false;
        public ReporteProducto()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarGraficoProductosPorCantidad(DateTime? fechaDesde, DateTime? fechaHasta)
        {

            // 1. Tu cadena de conexión
            using var conn = new SqlConnection(connectionString);

            // 2. La consulta SQL para cantidad
            string query = @"
                            SELECT TOP 5
                                p.nombre_producto AS ProductoNombre,
                                SUM(dv.cantidad_detalle) AS TotalCantidad
                            FROM
                                detalle_ventas AS dv
                            JOIN
                                producto AS p ON dv.id_producto = p.id_producto
                            JOIN
                                venta AS v ON dv.id_ventas = v.id_venta
                            WHERE
                                -- Esta es la lógica: Si @FechaDesde es NULL, ignora esta línea
                                (@FechaDesde IS NULL OR v.venta_fecha >= @FechaDesde)
                            AND
                                -- Si @FechaHasta es NULL, ignora esta línea
                                (@FechaHasta IS NULL OR v.venta_fecha <= @FechaHasta)
                            GROUP BY
                                p.nombre_producto
                            ORDER BY
                                TotalCantidad DESC;
                           ";

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (fechaDesde.HasValue)
                            cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde.Value);
                        else
                            cmd.Parameters.AddWithValue("@FechaDesde", DBNull.Value);

                        // Hacemos lo mismo para 'fechaHasta'
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
                MessageBox.Show("Error al cargar datos del gráfico: " + ex.Message);
                return;
            }

            // Configuración del Gráfico (ej. ChartProductosCantidad)
            CHProductosPorCantidad.Series.Clear();
            CHProductosPorCantidad.Titles.Clear();
            CHProductosPorCantidad.ChartAreas[0].BackColor = Color.Transparent;

            // Opcional: limpiar las líneas de fondo para un look más limpio

            CHProductosPorCantidad.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            CHProductosPorCantidad.ChartAreas[0].AxisY.MajorGrid.Enabled = false;



            // Importante: Asegura que cada etiqueta del eje X se muestre

            CHProductosPorCantidad.ChartAreas[0].AxisX.Interval = 1;

            // 5. Añadir Título
            Title mainTitle = CHProductosPorCantidad.Titles.Add("TOP 5 Productos Más Vendidos (Por Cantidad)");
            mainTitle.Font = new Font("Arial", 16, FontStyle.Bold);

            // 6. Crear la Serie y asignar el tipo de gráfico
            Series series = new Series("Cantidad vendida");
            series.ChartType = SeriesChartType.Column; // Vuelve a poner Columnas
            series.IsValueShownAsLabel = true;

            // =========================================================
            // 7. AÑADE ESTA LÍNEA PARA ARREGLAR EL EJE X
            // =========================================================
            series.IsXValueIndexed = true;

            // 8. Usa el enlace de datos que ya tenías
            series.Points.DataBind(dt.AsEnumerable(),
                                    "ProductoNombre",  // Columna para el eje X
                                    "TotalCantidad",   // Columna para el eje Y
                                    "");

            // 8. Añadir la serie al gráfico (esta línea se queda igual)
            CHProductosPorCantidad.Series.Add(series);
        }

        private void CargarGraficoProductosPorMonto(DateTime? fechaDesde, DateTime? fechaHasta)
        {
            // 1. Cadena de conexión (debe ser la misma que usas siempre)
            using var conn = new SqlConnection(connectionString);
            // (O bórra esta línea si 'connectionString' ya es global en tu clase)

            // 2. La consulta SQL para el TOP 5 por Monto Total
            string query = @"
                            SELECT TOP 5
                                p.nombre_producto AS ProductoNombre,
                                SUM(dv.cantidad_detalle * dv.precio_detalle) AS TotalMonto
                            FROM
                                detalle_ventas AS dv
                            JOIN
                                producto AS p ON dv.id_producto = p.id_producto
                            JOIN
                                venta AS v ON dv.id_ventas = v.id_venta
                            WHERE
                                -- Esta es la lógica: Si @FechaDesde es NULL, ignora esta línea
                                (@FechaDesde IS NULL OR v.venta_fecha >= @FechaDesde)
                            AND
                                -- Si @FechaHasta es NULL, ignora esta línea
                                (@FechaHasta IS NULL OR v.venta_fecha <= @FechaHasta)
                            GROUP BY
                                p.nombre_producto
                            ORDER BY
                                TotalMonto DESC;
                            ";

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (fechaDesde.HasValue)
                            cmd.Parameters.AddWithValue("@FechaDesde", fechaDesde.Value);
                        else
                            cmd.Parameters.AddWithValue("@FechaDesde", DBNull.Value);

                        // Hacemos lo mismo para 'fechaHasta'
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
                MessageBox.Show("Error al cargar datos del gráfico de Monto: " + ex.Message);
                return;
            }

            // 3. Limpiar y configurar el gráfico (¡Asegúrate que el nombre sea el correcto!)
            CHProductosPorMonto.Series.Clear();
            CHProductosPorMonto.Titles.Clear();
            CHProductosPorMonto.ChartAreas[0].BackColor = Color.Transparent;

            // Opcional: Limpiar ejes
            CHProductosPorMonto.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            CHProductosPorMonto.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            CHProductosPorMonto.ChartAreas[0].AxisX.Interval = 1;

            // 4. Añadir Título
            Title mainTitle = CHProductosPorMonto.Titles.Add("TOP 5 Productos Más Vendidos (Por Monto)");
            mainTitle.Font = new Font("Arial", 16, FontStyle.Bold);

            // 5. Crear la Serie
            Series series = new Series("Monto total vendido");
            series.IsValueShownAsLabel = true;

            // Puedes elegir el tipo de gráfico que prefieras
            series.ChartType = SeriesChartType.Column; // O SeriesChartType.Pie, etc.

            // La corrección para el Eje X (si usas Columnas)
            if (series.ChartType == SeriesChartType.Column)
            {
                series.IsXValueIndexed = true;
            }

            // 6. Enlazar los datos
            series.Points.DataBind(dt.AsEnumerable(),
                                    "ProductoNombre",  // Columna para el eje X
                                    "TotalMonto",      // Columna para el eje Y (¡cambió!)
                                    "");

            // 7. Añadir la serie al gráfico
            CHProductosPorMonto.Series.Add(series);
        }

        private void ActualizarGraficoVisible()
        {
            // 1. Preparamos las variables de fecha. Por defecto, son nulas.
            DateTime? fechaDesde = null;
            DateTime? fechaHasta = null;

            // 2. Revisamos el "interruptor"
            if (filtrosAplicados == true)
            {
                // Si los filtros SÍ están activos, tomamos las fechas de los controles
                fechaDesde = DTPDesde.Value.Date;
                fechaHasta = DTPHasta.Value.Date.AddDays(1).AddTicks(-1); // Ajuste a las 23:59:59
            }
            // Si 'filtrosAplicados' es false, las fechas se quedan en 'null' (y así se carga todo)

            // 3. Revisamos qué gráfico quiere ver el usuario y lo cargamos
            if (RBCantidad.Checked)
            {
                // Llamamos a la función de Cantidad pasándole las fechas (o 'null')
                CargarGraficoProductosPorCantidad(fechaDesde, fechaHasta);
                CHProductosPorCantidad.Visible = true;
                CHProductosPorMonto.Visible = false;
            }
            else if (RBMonto.Checked)
            {
                // Llamamos a la función de Monto pasándole las fechas (o 'null')
                CargarGraficoProductosPorMonto(fechaDesde, fechaHasta);
                CHProductosPorCantidad.Visible = false;
                CHProductosPorMonto.Visible = true;
            }
        }

        private void ReporteProducto_Load(object sender, EventArgs e)
        {
            CargarGraficoProductosPorCantidad(null, null);
            CargarGraficoProductosPorMonto(null, null);

            RBCantidad.Checked = true; // El de "Por Cantidad" empieza seleccionado
            CHProductosPorCantidad.Visible = true; // Muestra el gráfico de cantidad
            CHProductosPorMonto.Visible = false; // OCULTA el gráfico de monto
        }

        private void RBCantidad_CheckedChanged(object sender, EventArgs e)
        {
            if (RBCantidad.Checked)
            {
                ActualizarGraficoVisible();
            }
        }

        private void RBMonto_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMonto.Checked)
            {
                ActualizarGraficoVisible();
            }
        }

        private void CHProductosPorMonto_Click(object sender, EventArgs e)
        {

        }

        private void LFiltro_Click(object sender, EventArgs e)
        {

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

            // 2. Recarga el gráfico visible (ahora sin filtros)
            ActualizarGraficoVisible();
        }
    }
}
