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
            var da = new SqlDataAdapter(query, conn);
            /*da.SelectCommand.Parameters.AddRange(parametros.ToArray());
            */
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
