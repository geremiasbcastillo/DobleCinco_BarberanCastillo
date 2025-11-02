using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleCinco_BarberanCastillo
{
    public partial class ReporteVenta : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        public ReporteVenta()
        {
            InitializeComponent();
            MostrarReporteVentasPorCategoria();
        }

        private void LVentas_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MostrarReporteVentasPorCategoria()
        {
            // Query similar a CargarDatos (ajústala si necesita diferentes columnas)
            string query = @"SELECT
                                c.nombre_categoria AS Categoria,
                                SUM(dv.cantidad_detalle) AS TotalVendido
                            FROM
                                detalle_ventas dv
                            INNER JOIN
                                producto p ON dv.id_producto = p.id_producto
                            INNER JOIN
                                categoria c ON p.id_categoria = c.id_categoria
                            GROUP BY
                                c.nombre_categoria";

            var dt = new DataTable();
            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            using (var da = new System.Data.SqlClient.SqlDataAdapter(query, conn))
            {
                da.Fill(dt);
            }

            // Reiniciar y configurar el ReportViewer
            reportViewer1.Reset();
            // Si tu .rdlc está embebido usa el nombre de recurso completo:
            reportViewer1.LocalReport.ReportEmbeddedResource = "DobleCinco_BarberanCastillo\\Report1.rdlc";
            // El nombre "DataSet1" debe coincidir con el DataSet definido dentro del .rdlc
            var rds = new Microsoft.Reporting.WinForms.ReportDataSource("Categoria", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.RefreshReport();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
