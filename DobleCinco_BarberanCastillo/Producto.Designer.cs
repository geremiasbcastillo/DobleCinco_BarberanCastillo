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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            nombre_producto = new DataGridViewTextBoxColumn();
            descripcion_producto = new DataGridViewTextBoxColumn();
            precio_producto = new DataGridViewTextBoxColumn();
            producto_stock = new DataGridViewTextBoxColumn();
            producto_categoria = new DataGridViewTextBoxColumn();
            dgvproducto_foto = new DataGridViewImageColumn();
            panel5 = new Panel();
            panel1 = new Panel();
            BAgregarImagen = new Button();
            BProducto_agregar = new Button();
            CBCategoria = new ComboBox();
            PBproducto_imagen = new PictureBox();
            TBNombre = new TextBox();
            LNombre = new Label();
            LCategoria = new Label();
            TBStock = new TextBox();
            LStock = new Label();
            TBVenta = new TextBox();
            LVenta = new Label();
            TBDescripcion = new TextBox();
            LDescripcion = new Label();
            numericUpDown1 = new NumericUpDown();
            BLimpiar = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            LBusqueda = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBproducto_imagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_producto, nombre_producto, descripcion_producto, precio_producto, producto_stock, producto_categoria, dgvproducto_foto });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(248, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(743, 212);
            dataGridView1.TabIndex = 13;
            // 
            // id_producto
            // 
            id_producto.HeaderText = "Id_producto";
            id_producto.Name = "id_producto";
            // 
            // nombre_producto
            // 
            nombre_producto.HeaderText = "Nombre";
            nombre_producto.Name = "nombre_producto";
            // 
            // descripcion_producto
            // 
            descripcion_producto.HeaderText = "Descripcion";
            descripcion_producto.Name = "descripcion_producto";
            // 
            // precio_producto
            // 
            precio_producto.HeaderText = "Precio";
            precio_producto.Name = "precio_producto";
            // 
            // producto_stock
            // 
            producto_stock.HeaderText = "Stock";
            producto_stock.Name = "producto_stock";
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
            panel1.Controls.Add(LCategoria);
            panel1.Controls.Add(TBStock);
            panel1.Controls.Add(LStock);
            panel1.Controls.Add(TBVenta);
            panel1.Controls.Add(LVenta);
            panel1.Controls.Add(TBDescripcion);
            panel1.Controls.Add(LDescripcion);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(BLimpiar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(LBusqueda);
            panel1.Controls.Add(dataGridView1);
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(33, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 718);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // BAgregarImagen
            // 
            BAgregarImagen.Font = new Font("Segoe UI", 12F);
            BAgregarImagen.ForeColor = SystemColors.ActiveCaptionText;
            BAgregarImagen.Location = new Point(624, 426);
            BAgregarImagen.Name = "BAgregarImagen";
            BAgregarImagen.Size = new Size(113, 43);
            BAgregarImagen.TabIndex = 64;
            BAgregarImagen.Text = "Imagen";
            BAgregarImagen.UseVisualStyleBackColor = true;
            // 
            // BProducto_agregar
            // 
            BProducto_agregar.Font = new Font("Segoe UI", 12F);
            BProducto_agregar.ForeColor = SystemColors.ActiveCaptionText;
            BProducto_agregar.Location = new Point(768, 646);
            BProducto_agregar.Name = "BProducto_agregar";
            BProducto_agregar.Size = new Size(206, 41);
            BProducto_agregar.TabIndex = 63;
            BProducto_agregar.Text = "Agregar producto";
            BProducto_agregar.UseVisualStyleBackColor = true;
            // 
            // CBCategoria
            // 
            CBCategoria.DisplayMember = "1 2 3";
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Items.AddRange(new object[] { "Botines", "Camisetas", "Entrenamiento" });
            CBCategoria.Location = new Point(328, 593);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(254, 23);
            CBCategoria.TabIndex = 61;
            CBCategoria.ValueMember = "1 2 3";
            // 
            // PBproducto_imagen
            // 
            PBproducto_imagen.Image = Properties.Resources.shopping_bag_add__1_;
            PBproducto_imagen.InitialImage = Properties.Resources.shopping_bag_add__1_;
            PBproducto_imagen.Location = new Point(755, 369);
            PBproducto_imagen.Name = "PBproducto_imagen";
            PBproducto_imagen.Size = new Size(250, 183);
            PBproducto_imagen.SizeMode = PictureBoxSizeMode.Zoom;
            PBproducto_imagen.TabIndex = 62;
            PBproducto_imagen.TabStop = false;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(328, 369);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(254, 23);
            TBNombre.TabIndex = 48;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 15F);
            LNombre.Location = new Point(131, 364);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(85, 28);
            LNombre.TabIndex = 49;
            LNombre.Text = "Nombre";
            // 
            // LCategoria
            // 
            LCategoria.AutoSize = true;
            LCategoria.Font = new Font("Segoe UI", 15F);
            LCategoria.Location = new Point(131, 588);
            LCategoria.Name = "LCategoria";
            LCategoria.Size = new Size(97, 28);
            LCategoria.TabIndex = 60;
            LCategoria.Text = "Categoria";
            // 
            // TBStock
            // 
            TBStock.Location = new Point(328, 539);
            TBStock.Name = "TBStock";
            TBStock.Size = new Size(254, 23);
            TBStock.TabIndex = 57;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Font = new Font("Segoe UI", 15F);
            LStock.Location = new Point(131, 531);
            LStock.Name = "LStock";
            LStock.Size = new Size(60, 28);
            LStock.TabIndex = 56;
            LStock.Text = "Stock";
            // 
            // TBVenta
            // 
            TBVenta.Location = new Point(328, 482);
            TBVenta.Name = "TBVenta";
            TBVenta.Size = new Size(254, 23);
            TBVenta.TabIndex = 55;
            // 
            // LVenta
            // 
            LVenta.AutoSize = true;
            LVenta.Font = new Font("Segoe UI", 15F);
            LVenta.Location = new Point(131, 477);
            LVenta.Name = "LVenta";
            LVenta.Size = new Size(119, 28);
            LVenta.TabIndex = 54;
            LVenta.Text = "Precio venta";
            // 
            // TBDescripcion
            // 
            TBDescripcion.Location = new Point(328, 426);
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Size = new Size(254, 23);
            TBDescripcion.TabIndex = 51;
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Font = new Font("Segoe UI", 15F);
            LDescripcion.Location = new Point(131, 421);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(114, 28);
            LDescripcion.TabIndex = 50;
            LDescripcion.Text = "Descripcion";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(696, 19);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(107, 23);
            numericUpDown1.TabIndex = 47;
            // 
            // BLimpiar
            // 
            BLimpiar.Font = new Font("Segoe UI", 15F);
            BLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            BLimpiar.Location = new Point(328, 71);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(163, 40);
            BLimpiar.TabIndex = 46;
            BLimpiar.Text = "Limpiar filtros";
            BLimpiar.TextAlign = ContentAlignment.TopCenter;
            BLimpiar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(716, 71);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 45;
            button1.Text = "Buscar";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Botines", "Camisetas", "Entrenamiento" });
            comboBox1.Location = new Point(947, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 23);
            comboBox1.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(844, 15);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 43;
            label3.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(616, 15);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 42;
            label2.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(262, 15);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 40;
            label4.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 39;
            // 
            // LBusqueda
            // 
            LBusqueda.AutoSize = true;
            LBusqueda.Font = new Font("Segoe UI", 15F);
            LBusqueda.Location = new Point(119, 14);
            LBusqueda.Name = "LBusqueda";
            LBusqueda.Size = new Size(108, 28);
            LBusqueda.TabIndex = 38;
            LBusqueda.Text = "Buscar por:";
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Panel panel1;
        private ToolTip toolTip1;
        private Button BLimpiar;
        private Button button1;
        private Button BAgregarImagen;
        private Button BProducto_agregar;
        private ComboBox CBCategoria;
        private PictureBox PBproducto_imagen;
        private TextBox TBNombre;
        private Label LNombre;
        private Label LCategoria;
        private TextBox TBStock;
        private Label LStock;
        private TextBox TBVenta;
        private Label LVenta;
        private TextBox TBDescripcion;
        private Label LDescripcion;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private Label LBusqueda;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn nombre_producto;
        private DataGridViewTextBoxColumn descripcion_producto;
        private DataGridViewTextBoxColumn precio_producto;
        private DataGridViewTextBoxColumn producto_stock;
        private DataGridViewTextBoxColumn producto_categoria;
        private DataGridViewImageColumn dgvproducto_foto;
    }
}