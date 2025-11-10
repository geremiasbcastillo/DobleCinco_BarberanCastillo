using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleCinco_BarberanCastillo
{
    public partial class Producto : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        private Image imagenInicialProducto;
        public Producto()
        {
            InitializeComponent();
            BProducto_agregar.Click += BProducto_agregar_Click;
            BAgregarImagen.Click += BAgregarImagen_Click;
            button1.Click += button1_Click;
            BLimpiar.Click += BLimpiar_Click;
        }

        private void CargarProductos()
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                string query = @"SELECT 
                    id_producto, 
                    nombre_producto, 
                    descripcion_producto, 
                    precio_producto, 
                    cantidad_producto, 
                    imagen_producto, 
                    id_categoria, 
                    id_estado
                    FROM producto WHERE id_estado = 1";

                var da = new System.Data.SqlClient.SqlDataAdapter(query, conn);
                var dt = new DataTable();
                da.Fill(dt);

                // Limpiar columnas previas
                dataGridView1.Columns.Clear();

                // Crear columnas manualmente
                dataGridView1.AutoGenerateColumns = false;

                // ID
                var colId = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "id_producto",
                    HeaderText = "ID",
                    Name = "ID"
                };
                dataGridView1.Columns.Add(colId);

                // Nombre
                var colNombre = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "nombre_producto",
                    HeaderText = "Nombre",
                    Name = "Nombre"
                };
                dataGridView1.Columns.Add(colNombre);

                // Descripción
                var colDesc = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "descripcion_producto",
                    HeaderText = "Descripción",
                    Name = "Descripción"
                };
                dataGridView1.Columns.Add(colDesc);

                // Precio
                var colPrecio = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "precio_producto",
                    HeaderText = "Precio",
                    Name = "Precio"
                };
                dataGridView1.Columns.Add(colPrecio);

                // Stock
                var colStock = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "cantidad_producto",
                    HeaderText = "Stock",
                    Name = "Stock"
                };
                dataGridView1.Columns.Add(colStock);

                // Imagen (columna especial)
                var colImagen = new DataGridViewImageColumn
                {
                    HeaderText = "Imagen",
                    Name = "Imagen",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dataGridView1.Columns.Add(colImagen);

                // Categoría
                var colCategoria = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "id_categoria",
                    HeaderText = "Categoría",
                    Name = "Categoría"
                };
                dataGridView1.Columns.Add(colCategoria);

                // Estado (oculta)
                var colEstado = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "id_estado",
                    HeaderText = "Estado",
                    Name = "Estado",
                    Visible = false // Oculta la columna
                };
                dataGridView1.Columns.Add(colEstado);

                // Cargar filas y las imágenes
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    object imagenObj = null;
                    string ruta = row["imagen_producto"]?.ToString();
                    if (!string.IsNullOrEmpty(ruta))
                    {
                        string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ruta);
                        if (File.Exists(rutaCompleta))
                        {
                            using (var imgTemp = Image.FromFile(rutaCompleta))
                            {
                                imagenObj = new Bitmap(imgTemp);
                            }
                        }
                    }

                    dataGridView1.Rows.Add(
                        row["id_producto"],
                        row["nombre_producto"],
                        row["descripcion_producto"],
                        row["precio_producto"],
                        row["cantidad_producto"],
                        imagenObj,
                        row["id_categoria"],
                        row["id_estado"]
                    );
                }
            }
            dataGridView1.Refresh(); // <-- Soluciona el problema de visualización
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                string query = "SELECT id_categoria, nombre_categoria FROM categoria";
                var da = new System.Data.SqlClient.SqlDataAdapter(query, conn);
                var dt = new DataTable();
                da.Fill(dt);

                // Configura el ComboBox de filtro de categoría
                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "id_categoria";      // El valor será el id
                comboBox1.DisplayMember = "nombre_categoria"; // Lo que se muestra al usuario
                comboBox1.SelectedIndex = -1; // Opcional: para que no haya nada seleccionado al inicio
            }

            // Si tienes otro ComboBox para alta de productos, configúralo igual
            CBCategoria.DataSource = comboBox1.DataSource;
            CBCategoria.ValueMember = "id_categoria";
            CBCategoria.DisplayMember = "nombre_categoria";
            CBCategoria.SelectedIndex = -1;

            CargarProductos();
            imagenInicialProducto = PBproducto_imagen.Image; // Guarda la imagen inicial
        }

        private void TBStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TBVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }



        private void LCategoria_Click(object sender, EventArgs e)
        {

        }

        private void LMinimo_Click(object sender, EventArgs e)
        {

        }

        private void LNombre_Click(object sender, EventArgs e)
        {

        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LDescripcion_Click(object sender, EventArgs e)
        {

        }

        private string rutaImagenProducto = "";



        private void BProducto_agregar_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(TBNombre.Text) ||
                string.IsNullOrWhiteSpace(TBDescripcion.Text) ||
                string.IsNullOrWhiteSpace(TBVenta.Text) ||
                string.IsNullOrWhiteSpace(TBStock.Text) ||
                CBCategoria.SelectedItem == null ||
                PBproducto_imagen.Image == null)
            {
                MessageBox.Show("Todos los campos son obligatorios y debe seleccionar una imagen.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener id_categoria del ComboBox (asumiendo que el Value es el id)
            int idCategoria;
            if (!int.TryParse(CBCategoria.SelectedValue?.ToString(), out idCategoria))
            {
                MessageBox.Show("Seleccione una categoría válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Guardar la imagen en una carpeta local y obtener la ruta relativa
            string nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(rutaImagenProducto);
            string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ImagenesProductos");
            Directory.CreateDirectory(carpetaDestino);
            string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);
            PBproducto_imagen.Image.Save(rutaDestino);
            string rutaRelativa = "ImagenesProductos\\" + nombreArchivo;

            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                string query = @"INSERT INTO producto 
                    (descripcion_producto, nombre_producto, precio_producto, cantidad_producto, imagen_producto, id_estado, id_categoria)
                    VALUES (@Descripcion, @Nombre, @Precio, @Cantidad, @Imagen, @Estado, @Categoria)";
                using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", TBDescripcion.Text);
                    cmd.Parameters.AddWithValue("@Nombre", TBNombre.Text);
                    cmd.Parameters.AddWithValue("@Precio", double.Parse(TBVenta.Text.Replace(',', '.')));
                    cmd.Parameters.AddWithValue("@Cantidad", int.Parse(TBStock.Text));
                    cmd.Parameters.AddWithValue("@Imagen", rutaRelativa);
                    cmd.Parameters.AddWithValue("@Estado", 1); // Alta lógica
                    cmd.Parameters.AddWithValue("@Categoria", idCategoria);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar campos
                        TBNombre.Clear();
                        TBDescripcion.Clear();
                        TBVenta.Clear();
                        TBStock.Clear();
                        CBCategoria.SelectedIndex = -1;
                        PBproducto_imagen.Image = imagenInicialProducto; // Restaura la imagen inicial
                        rutaImagenProducto = "";

                        CargarProductos(); // Actualiza la grilla después de agregar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            CargarProductos(); // Actualiza la grilla después de agregar
        }

        private void TBStockMinimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAgregarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PBproducto_imagen.Image = Image.FromFile(ofd.FileName);
                    rutaImagenProducto = ofd.FileName; // Guarda la ruta para usarla después
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreFiltro = textBox1.Text.Trim();
            int stockFiltro = (int)numericUpDown1.Value;
            int categoriaFiltro = comboBox1.SelectedValue != null ? Convert.ToInt32(comboBox1.SelectedValue) : 0;

            string query = @"SELECT 
        id_producto, 
        nombre_producto, 
        descripcion_producto, 
        precio_producto, 
        cantidad_producto, 
        imagen_producto, 
        id_categoria, 
        id_estado
        FROM producto WHERE id_estado = 1";

            List<string> condiciones = new();
            var cmd = new System.Data.SqlClient.SqlCommand();

            if (!string.IsNullOrEmpty(nombreFiltro))
            {
                condiciones.Add("nombre_producto LIKE @Nombre");
                cmd.Parameters.AddWithValue("@Nombre", "%" + nombreFiltro + "%");
            }
            if (stockFiltro > 0)
            {
                condiciones.Add("cantidad_producto >= @Stock");
                cmd.Parameters.AddWithValue("@Stock", stockFiltro);
            }
            if (categoriaFiltro > 0)
            {
                condiciones.Add("id_categoria = @Categoria");
                cmd.Parameters.AddWithValue("@Categoria", categoriaFiltro);
            }

            if (condiciones.Count > 0)
                query += " AND " + string.Join(" AND ", condiciones);

            cmd.CommandText = query;

            using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                cmd.Connection = conn;
                var da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                // Reutiliza la lógica para mostrar las imágenes en la grilla
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;
                // ID
                var colId = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "id_producto",
                    HeaderText = "ID",
                    Name = "ID"
                };
                dataGridView1.Columns.Add(colId);

                // Nombre
                var colNombre = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "nombre_producto",
                    HeaderText = "Nombre",
                    Name = "Nombre"
                };
                dataGridView1.Columns.Add(colNombre);

                // Descripción
                var colDesc = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "descripcion_producto",
                    HeaderText = "Descripción",
                    Name = "Descripción"
                };
                dataGridView1.Columns.Add(colDesc);

                // Precio
                var colPrecio = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "precio_producto",
                    HeaderText = "Precio",
                    Name = "Precio"
                };
                dataGridView1.Columns.Add(colPrecio);

                // Stock
                var colStock = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "cantidad_producto",
                    HeaderText = "Stock",
                    Name = "Stock"
                };
                dataGridView1.Columns.Add(colStock);

                // Imagen (columna especial)
                var colImagen = new DataGridViewImageColumn
                {
                    HeaderText = "Imagen",
                    Name = "Imagen",
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dataGridView1.Columns.Add(colImagen);

                // Categoría
                var colCategoria = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "id_categoria",
                    HeaderText = "Categoría",
                    Name = "Categoría"
                };
                dataGridView1.Columns.Add(colCategoria);

                // Estado (oculta)
                var colEstado = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "id_estado",
                    HeaderText = "Estado",
                    Name = "Estado",
                    Visible = false // Oculta la columna
                };
                dataGridView1.Columns.Add(colEstado);

                // Cargar filas y las imágenes
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    object imagenObj = null;
                    string ruta = row["imagen_producto"]?.ToString();
                    if (!string.IsNullOrEmpty(ruta))
                    {
                        string rutaCompleta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ruta);
                        if (File.Exists(rutaCompleta))
                        {
                            using (var imgTemp = Image.FromFile(rutaCompleta))
                            {
                                imagenObj = new Bitmap(imgTemp);
                            }
                        }
                    }

                    dataGridView1.Rows.Add(
                        row["id_producto"],
                        row["nombre_producto"],
                        row["descripcion_producto"],
                        row["precio_producto"],
                        row["cantidad_producto"],
                        imagenObj,
                        row["id_categoria"],
                        row["id_estado"]
                    );
                }
            }
            dataGridView1.Refresh();
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
            comboBox1.SelectedIndex = -1; // "Todos"
            CargarProductos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }

}


