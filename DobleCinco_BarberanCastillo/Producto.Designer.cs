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
            label1 = new Label();
            LDescripcion = new Label();
            TBDescripcion = new TextBox();
            TBCosto = new TextBox();
            PCosto = new Label();
            TBVenta = new TextBox();
            PVenta = new Label();
            TBStock = new TextBox();
            LStock = new Label();
            TBStockMinimo = new TextBox();
            LMinimo = new Label();
            LCategoria = new Label();
            LImagen = new Label();
            dataGridView1 = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            producto_descripcion = new DataGridViewTextBoxColumn();
            producto_costo = new DataGridViewTextBoxColumn();
            producto_venta = new DataGridViewTextBoxColumn();
            producto_stock = new DataGridViewTextBoxColumn();
            producto_minimo = new DataGridViewTextBoxColumn();
            producto_categoria = new DataGridViewTextBoxColumn();
            TBNombre = new TextBox();
            LNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(81, 37);
            label1.Name = "label1";
            label1.Size = new Size(172, 46);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // LDescripcion
            // 
            LDescripcion.AutoSize = true;
            LDescripcion.Font = new Font("Segoe UI", 15F);
            LDescripcion.Location = new Point(179, 135);
            LDescripcion.Name = "LDescripcion";
            LDescripcion.Size = new Size(114, 28);
            LDescripcion.TabIndex = 1;
            LDescripcion.Text = "Descripcion";
            // 
            // TBDescripcion
            // 
            TBDescripcion.Location = new Point(376, 143);
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Size = new Size(254, 23);
            TBDescripcion.TabIndex = 2;
            // 
            // TBCosto
            // 
            TBCosto.Location = new Point(376, 203);
            TBCosto.Name = "TBCosto";
            TBCosto.Size = new Size(254, 23);
            TBCosto.TabIndex = 4;
            TBCosto.KeyPress += TBCosto_KeyPress;
            // 
            // PCosto
            // 
            PCosto.AutoSize = true;
            PCosto.Font = new Font("Segoe UI", 15F);
            PCosto.Location = new Point(179, 195);
            PCosto.Name = "PCosto";
            PCosto.Size = new Size(122, 28);
            PCosto.TabIndex = 3;
            PCosto.Text = "Precio Costo";
            // 
            // TBVenta
            // 
            TBVenta.Location = new Point(376, 269);
            TBVenta.Name = "TBVenta";
            TBVenta.Size = new Size(254, 23);
            TBVenta.TabIndex = 6;
            TBVenta.KeyPress += TBVenta_KeyPress;
            // 
            // PVenta
            // 
            PVenta.AutoSize = true;
            PVenta.Font = new Font("Segoe UI", 15F);
            PVenta.Location = new Point(179, 261);
            PVenta.Name = "PVenta";
            PVenta.Size = new Size(119, 28);
            PVenta.TabIndex = 5;
            PVenta.Text = "Precio venta";
            // 
            // TBStock
            // 
            TBStock.Location = new Point(376, 333);
            TBStock.Name = "TBStock";
            TBStock.Size = new Size(254, 23);
            TBStock.TabIndex = 8;
            TBStock.KeyPress += TBStock_KeyPress;
            // 
            // LStock
            // 
            LStock.AutoSize = true;
            LStock.Font = new Font("Segoe UI", 15F);
            LStock.Location = new Point(179, 325);
            LStock.Name = "LStock";
            LStock.Size = new Size(60, 28);
            LStock.TabIndex = 7;
            LStock.Text = "Stock";
            // 
            // TBStockMinimo
            // 
            TBStockMinimo.Location = new Point(376, 395);
            TBStockMinimo.Name = "TBStockMinimo";
            TBStockMinimo.Size = new Size(254, 23);
            TBStockMinimo.TabIndex = 10;
            TBStockMinimo.KeyPress += TBStockMinimo_KeyPress;
            // 
            // LMinimo
            // 
            LMinimo.AutoSize = true;
            LMinimo.Font = new Font("Segoe UI", 15F);
            LMinimo.Location = new Point(179, 387);
            LMinimo.Name = "LMinimo";
            LMinimo.Size = new Size(132, 28);
            LMinimo.TabIndex = 9;
            LMinimo.Text = "Stock mínimo";
            // 
            // LCategoria
            // 
            LCategoria.AutoSize = true;
            LCategoria.Font = new Font("Segoe UI", 15F);
            LCategoria.Location = new Point(179, 451);
            LCategoria.Name = "LCategoria";
            LCategoria.Size = new Size(97, 28);
            LCategoria.TabIndex = 11;
            LCategoria.Text = "Categoria";
            // 
            // LImagen
            // 
            LImagen.AutoSize = true;
            LImagen.Font = new Font("Segoe UI", 15F);
            LImagen.Location = new Point(784, 135);
            LImagen.Name = "LImagen";
            LImagen.Size = new Size(77, 28);
            LImagen.TabIndex = 12;
            LImagen.Text = "Imagen";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_producto, producto_descripcion, producto_costo, producto_venta, producto_stock, producto_minimo, producto_categoria });
            dataGridView1.Location = new Point(179, 537);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(746, 322);
            dataGridView1.TabIndex = 13;
            // 
            // id_producto
            // 
            id_producto.HeaderText = "id_usuario";
            id_producto.Name = "id_producto";
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
            // TBNombre
            // 
            TBNombre.Location = new Point(376, 91);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(254, 23);
            TBNombre.TabIndex = 15;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 15F);
            LNombre.Location = new Point(179, 83);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(85, 28);
            LNombre.TabIndex = 14;
            LNombre.Text = "Nombre";
            // 
            // Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(1856, 906);
            Controls.Add(TBNombre);
            Controls.Add(LNombre);
            Controls.Add(dataGridView1);
            Controls.Add(LImagen);
            Controls.Add(LCategoria);
            Controls.Add(TBStockMinimo);
            Controls.Add(LMinimo);
            Controls.Add(TBStock);
            Controls.Add(LStock);
            Controls.Add(TBVenta);
            Controls.Add(PVenta);
            Controls.Add(TBCosto);
            Controls.Add(PCosto);
            Controls.Add(TBDescripcion);
            Controls.Add(LDescripcion);
            Controls.Add(label1);
            Name = "Producto";
            Text = "Ventas";
            Load += Producto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LDescripcion;
        private TextBox TBDescripcion;
        private TextBox TBCosto;
        private Label PCosto;
        private TextBox TBVenta;
        private Label PVenta;
        private TextBox TBStock;
        private Label LStock;
        private TextBox TBStockMinimo;
        private Label LMinimo;
        private Label LCategoria;
        private Label LImagen;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn producto_descripcion;
        private DataGridViewTextBoxColumn producto_costo;
        private DataGridViewTextBoxColumn producto_venta;
        private DataGridViewTextBoxColumn producto_stock;
        private DataGridViewTextBoxColumn producto_minimo;
        private DataGridViewTextBoxColumn producto_categoria;
        private TextBox TBNombre;
        private Label LNombre;
    }
}