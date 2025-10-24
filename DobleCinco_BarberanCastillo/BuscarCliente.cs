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
    public partial class BuscarCliente : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        private string filtro;

        public event Action<string, string, string, string, string> ClienteSeleccionado;

        public BuscarCliente(string filtro)
        {
            InitializeComponent();
            this.filtro = filtro;
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            CargarProductos();
            // Configurar el DataGridView para que no se puedan editar las celdas y se seleccione la fila completa
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
        }

        private void CargarProductos()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT id_cliente AS 'ID', 
                                        nombre_cliente AS 'Nombre', 
                                        apellido_cliente AS 'Apellido',
                                        dni_cliente AS 'DNI',
                                        domicilio_cliente AS 'Domicilio',
                                        telefono_cliente AS 'Teléfono'
                                 FROM Cliente 
                                 WHERE dni_cliente LIKE @filtro"; // Buscamos por descripción o por un ID de texto si lo tuvieras

                try
                {
                    conn.Open();
                    var da = new SqlDataAdapter(query, conn);
                    // Usamos el filtro que recibimos en el constructor
                    da.SelectCommand.Parameters.AddWithValue("@filtro", this.filtro + "%");
                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvClientes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar cliente: " + ex.Message, "Error");
                }
            }
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                var row = dgvClientes.CurrentRow;
                int id = 0;
                if (row.Cells["ID"].Value != null)
                {
                    int.TryParse(row.Cells["ID"].Value.ToString(), out id);
                }
                string nombre = row.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                string apellido = row.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                string dni = row.Cells["DNI"].Value?.ToString() ?? string.Empty;
                string domicilio = row.Cells["Domicilio"].Value?.ToString() ?? string.Empty;
                string telefono = row.Cells["Teléfono"].Value?.ToString() ?? string.Empty;

                ClienteSeleccionado?.Invoke(nombre, apellido, dni, domicilio, telefono);
                this.Close();
            }
        }
    }
}
