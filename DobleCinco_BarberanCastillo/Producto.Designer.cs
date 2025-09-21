namespace DobleCinco_BarberanCastillo
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            LDescripcion = new Label();
            TBDescripcion = new TextBox();
            TBCosto = new TextBox();
            LCosto = new Label();
            TBVenta = new TextBox();
            LVenta = new Label();
            TBStock = new TextBox();
            LStock = new Label();
            TBStockMinimo = new TextBox();
            LMinimo = new Label();
            LCategoria = new Label();
            dataGridView1 = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            producto_descripcion = new DataGridViewTextBoxColumn();
            producto_costo = new DataGridViewTextBoxColumn();
            producto_venta = new DataGridViewTextBoxColumn();
            producto_stock = new DataGridViewTextBoxColumn();
            producto_minimo = new DataGridViewTextBoxColumn();
            producto_categoria = new DataGridViewTextBoxColumn();
            dgvproducto_foto = new DataGridViewImageColumn();
            TBNombre = new TextBox();
            LNombre = new Label();
            panel5 = new Panel();
            panel1 = new Panel();
            BAgregarImagen = new Button();
            BProducto_agregar = new Button();
            CBCategoria = new ComboBox();
            PBproducto_imagen = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBproducto_imagen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(34, 18);
            label1.Name = "label1";
            label1.Size = new Size(172, 46);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Font = new Font("Segoe UI", 15F);
            LDescripcion.Location = new Point(139, 80);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(114, 28);
            LDescripcion.TabIndex = 2;
            LDescripcion.Text = "Descripcion";
            LDescripcion.Click += LDescripcion_Click;
            // 
            // TBDescripcion
            // 
            TBDescripcion.Location = new Point(336, 85);
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Size = new Size(254, 23);
            TBDescripcion.TabIndex = 2;
            // 
            // TBCosto
            // 
            TBCosto.Location = new Point(336, 135);
            TBCosto.Name = "TBCosto";
            TBCosto.Size = new Size(254, 23);
            TBCosto.TabIndex = 3;
            TBCosto.KeyPress += TBCosto_KeyPress;
            // 
            // LCosto
            // 
            LCosto.AutoSize = true;
            LCosto.Font = new Font("Segoe UI", 15F);
            LCosto.Location = new Point(139, 130);
            LCosto.Name = "LCosto";
            LCosto.Size = new Size(122, 28);
            LCosto.TabIndex = 3;
            LCosto.Text = "Precio Costo";
            // 
            // TBVenta
            // 
            TBVenta.Location = new Point(336, 185);
            TBVenta.Name = "TBVenta";
            TBVenta.Size = new Size(254, 23);
            TBVenta.TabIndex = 4;
            TBVenta.KeyPress += TBVenta_KeyPress;
            // 
            // LVenta
            // 
            LVenta.AutoSize = true;
            LVenta.Font = new Font("Segoe UI", 15F);
            LVenta.Location = new Point(139, 180);
            LVenta.Name = "LVenta";
            LVenta.Size = new Size(119, 28);
            LVenta.TabIndex = 4;
            LVenta.Text = "Precio venta";
            // 
            // TBStock
            // 
            TBStock.Location = new Point(336, 235);
            TBStock.Name = "TBStock";
            TBStock.Size = new Size(254, 23);
            TBStock.TabIndex = 5;
            TBStock.KeyPress += TBStock_KeyPress;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Font = new Font("Segoe UI", 15F);
            LStock.Location = new Point(139, 230);
            LStock.Name = "LStock";
            LStock.Size = new Size(60, 28);
            LStock.TabIndex = 5;
            LStock.Text = "Stock";
            // 
            // TBStockMinimo
            // 
            TBStockMinimo.Location = new Point(336, 285);
            TBStockMinimo.Name = "TBStockMinimo";
            TBStockMinimo.Size = new Size(254, 23);
            TBStockMinimo.TabIndex = 6;
            TBStockMinimo.TextChanged += TBStockMinimo_TextChanged;
            TBStockMinimo.KeyPress += TBStockMinimo_KeyPress;
            // 
            // LMinimo
            // 
            LMinimo.AutoSize = true;
            LMinimo.Font = new Font("Segoe UI", 15F);
            LMinimo.Location = new Point(139, 280);
            LMinimo.Name = "LMinimo";
            LMinimo.Size = new Size(132, 28);
            LMinimo.TabIndex = 6;
            LMinimo.Text = "Stock mínimo";
            LMinimo.Click += LMinimo_Click;
            // 
            // LCategoria
            // 
            LCategoria.AutoSize = true;
            LCategoria.Font = new Font("Segoe UI", 15F);
            LCategoria.Location = new Point(139, 330);
            LCategoria.Name = "LCategoria";
            LCategoria.Size = new Size(97, 28);
            LCategoria.TabIndex = 7;
            LCategoria.Text = "Categoria";
            LCategoria.Click += LCategoria_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_producto, Nombre, producto_descripcion, producto_costo, producto_venta, producto_stock, producto_minimo, producto_categoria, dgvproducto_foto });
            dataGridView1.Location = new Point(139, 381);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(945, 211);
            dataGridView1.TabIndex = 13;
            // 
            // id_producto
            // 
            id_producto.HeaderText = "id_usuario";
            id_producto.Name = "id_producto";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // producto_descripcion
            // 
            producto_descripcion.HeaderText = "Descripcion";
            producto_descripcion.Name = "producto_descripcion";
            // 
            // producto_costo
            // 
            producto_costo.HeaderText = "Precio Costo";
            producto_costo.Name = "producto_costo";
            // 
            // producto_venta
            // 
            producto_venta.HeaderText = "Precio Venta";
            producto_venta.Name = "producto_venta";
            // 
            // producto_stock
            // 
            producto_stock.HeaderText = "Stock";
            producto_stock.Name = "producto_stock";
            // 
            // producto_minimo
            // 
            producto_minimo.HeaderText = "Stock Mínimo";
            producto_minimo.Name = "producto_minimo";
            // 
            // producto_categoria
            // 
            producto_categoria.HeaderText = "Categoria";
            producto_categoria.Name = "producto_categoria";
            // 
            // dgvproducto_foto
            // 
            dgvproducto_foto.HeaderText = "Imagen";
            dgvproducto_foto.Name = "dgvproducto_foto";
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(336, 35);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(254, 23);
            TBNombre.TabIndex = 1;
            TBNombre.TextChanged += TBNombre_TextChanged;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 15F);
            LNombre.Location = new Point(139, 30);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(85, 28);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            LNombre.Click += LNombre_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 64, 0);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(33, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(1213, 86);
            panel5.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Controls.Add(BAgregarImagen);
            panel1.Controls.Add(BProducto_agregar);
            panel1.Controls.Add(CBCategoria);
            panel1.Controls.Add(PBproducto_imagen);
            panel1.Controls.Add(TBNombre);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(LCategoria);
            panel1.Controls.Add(TBStockMinimo);
            panel1.Controls.Add(LMinimo);
            panel1.Controls.Add(TBStock);
            panel1.Controls.Add(LStock);
            panel1.Controls.Add(TBVenta);
            panel1.Controls.Add(LVenta);
            panel1.Controls.Add(TBCosto);
            panel1.Controls.Add(LCosto);
            panel1.Controls.Add(TBDescripcion);
            panel1.Controls.Add(LDescripcion);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(33, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 718);
            panel1.TabIndex = 17;
            // 
            // BAgregarImagen
            // 
            BAgregarImagen.Font = new Font("Segoe UI", 12F);
            BAgregarImagen.ForeColor = SystemColors.ActiveCaptionText;
            BAgregarImagen.Location = new Point(632, 92);
            BAgregarImagen.Name = "BAgregarImagen";
            BAgregarImagen.Size = new Size(113, 43);
            BAgregarImagen.TabIndex = 21;
            BAgregarImagen.Text = "Imagen";
            BAgregarImagen.UseVisualStyleBackColor = true;
            BAgregarImagen.Click += BAgregarImagen_Click;
            // 
            // BProducto_agregar
            // 
            BProducto_agregar.Font = new Font("Segoe UI", 12F);
            BProducto_agregar.ForeColor = SystemColors.ActiveCaptionText;
            BProducto_agregar.Location = new Point(776, 312);
            BProducto_agregar.Name = "BProducto_agregar";
            BProducto_agregar.Size = new Size(206, 41);
            BProducto_agregar.TabIndex = 20;
            BProducto_agregar.Text = "Agregar producto";
            BProducto_agregar.UseVisualStyleBackColor = true;
            // 
            // CBCategoria
            // 
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Items.AddRange(new object[] { "Botines", "Camisetas", "Entrenamiento" });
            CBCategoria.Location = new Point(336, 330);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(254, 23);
            CBCategoria.TabIndex = 7;
            // 
            // PBproducto_imagen
            // 
            PBproducto_imagen.Image = Properties.Resources.shopping_bag_add__1_;
            PBproducto_imagen.InitialImage = Properties.Resources.shopping_bag_add__1_;
            PBproducto_imagen.Location = new Point(763, 35);
            PBproducto_imagen.Name = "PBproducto_imagen";
            PBproducto_imagen.Size = new Size(301, 146);
            PBproducto_imagen.SizeMode = PictureBoxSizeMode.CenterImage;
            PBproducto_imagen.TabIndex = 18;
            PBproducto_imagen.TabStop = false;
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1856, 906);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "Producto";
            Text = "Ventas";
            Load += Producto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBproducto_imagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LDescripcion;
        private TextBox TBDescripcion;
        private TextBox TBCosto;
        private Label LCosto;
        private TextBox TBVenta;
        private Label LVenta;
        private TextBox TBStock;
        private Label LStock;
        private TextBox TBStockMinimo;
        private Label LMinimo;
        private Label LCategoria;
        private DataGridView dataGridView1;
        private TextBox TBNombre;
        private Label LNombre;
        private Panel panel5;
        private Panel panel1;
        private PictureBox PBproducto_imagen;
        private ComboBox CBCategoria;
        private ToolTip toolTip1;
        private Button BProducto_agregar;
        private Button BAgregarImagen;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn producto_descripcion;
        private DataGridViewTextBoxColumn producto_costo;
        private DataGridViewTextBoxColumn producto_venta;
        private DataGridViewTextBoxColumn producto_stock;
        private DataGridViewTextBoxColumn producto_minimo;
        private DataGridViewTextBoxColumn producto_categoria;
        private DataGridViewImageColumn dgvproducto_foto;
    }
}