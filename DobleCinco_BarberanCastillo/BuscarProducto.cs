using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int IdProductoSeleccionado { get; private set; }
        public string DescripcionProducto { get; private set; }
        public decimal PrecioCostoProducto { get; private set; }

        private string connectionString = "Server=localhost;Database=doble_cinco;User Id=sa;Password=12345678;";
        private string filtroBusqueda;

       

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
                // Asumo que tu tabla se llama 'Producto' y tiene estas columnas
                string query = @"SELECT id_producto AS ID, 
                                        descripcion AS Descripción, 
                                        precio_costo AS 'Precio Costo' 
                                 FROM Producto 
                                 WHERE descripcion LIKE @filtro OR id_producto_texto LIKE @filtro"; // Buscamos por descripción o por un ID de texto si lo tuvieras

                try
                {
                    conn.Open();
                    var da = new SqlDataAdapter(query, conn);
                    // Usamos el filtro que recibimos en el constructor
                    da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + this.filtroBusqueda + "%");

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

        private void BAceptar_Click(object sender, EventArgs e)
        {
            // Verificamos si hay una fila seleccionada
            if (dgvProductos.CurrentRow != null)
            {
                // Guardamos los datos de la fila seleccionada en las propiedades públicas
                var fila = dgvProductos.CurrentRow;
                IdProductoSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
                DescripcionProducto = fila.Cells["Descripción"].Value.ToString();
                PrecioCostoProducto = Convert.ToDecimal(fila.Cells["Precio Costo"].Value);

                // Establecemos el resultado del diálogo como OK y cerramos el formulario
                this.DialogResult = DialogResult.OK;
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
