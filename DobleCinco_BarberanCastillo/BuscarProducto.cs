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
    public partial class BuscarProducto : Form
    {
        // Propiedades públicas para devolver los datos del producto seleccionado
        public int IdProductoSeleccionado;
        public string DescripcionProducto;
        public decimal PrecioCostoProducto;

        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        private string filtro_nombre, filtro_descripcion;

        public BuscarProducto(string filtro, string filtro2)
        {
            InitializeComponent();
            this.filtro_nombre = filtro;
            this.filtro_descripcion = filtro2;
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
            // Configurar el DataGridView para que no se puedan editar las celdas y se seleccione la fila completa
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;
        }

        private void CargarProductos()
        {
            using (var conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT id_producto AS 'ID', 
                                        descripcion_producto AS Descripción, 
                                        precio_producto AS 'Precio',
                                        cantidad_producto AS 'Cantidad'
                                 FROM Producto 
                                 WHERE descripcion_producto LIKE @filtro_descripcion OR nombre_producto LIKE @filtro_nombre"; // Buscamos por descripción o por un ID de texto si lo tuvieras

                try
                {
                    conn.Open();
                    var da = new SqlDataAdapter(query, conn);
                    // Usamos el filtro que recibimos en el constructor
                    da.SelectCommand.Parameters.AddWithValue("@filtro_descripcion", "%" + this.filtro_descripcion + "%");
                    da.SelectCommand.Parameters.AddWithValue("@filtro_nombre", this.filtro_nombre + "%");

                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvProductos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar productos: " + ex.Message, "Error");
                }
            }
        }

        public event Action<int, string, decimal> ProductoSeleccionado;

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                var fila = dgvProductos.CurrentRow;
                IdProductoSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
                DescripcionProducto = fila.Cells["Descripción"].Value.ToString();
                PrecioCostoProducto = Convert.ToDecimal(fila.Cells["Precio"].Value);

                // Dispara el evento
                ProductoSeleccionado?.Invoke(IdProductoSeleccionado, DescripcionProducto, PrecioCostoProducto);

                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Advertencia");
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Para mejorar la experiencia, si el usuario hace doble clic, también se selecciona
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no hizo clic en el encabezado
            {
                BAceptar.PerformClick();
            }
        }
    }
}
