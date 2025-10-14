namespace DobleCinco_BarberanCastillo
{
    partial class Ventas
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            TBVendedor = new TextBox();
            LVentas = new Label();
            panel2 = new Panel();
            BCancelar = new Button();
            BAceptar = new Button();
            label11 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            label6 = new Label();
            TBDomicilio = new TextBox();
            label5 = new Label();
            TBDni = new TextBox();
            label4 = new Label();
            TBApellido = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TBNombre = new TextBox();
            panel3 = new Panel();
            label7 = new Label();
            DTPFecha = new DateTimePicker();
            LFecha = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            BVenta = new Button();
            dgvDetalleVenta = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            producto_descripcion = new DataGridViewTextBoxColumn();
            producto_cantidad = new DataGridViewTextBoxColumn();
            producto_costo = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            BBuscarProducto = new Button();
            TBDescripcion = new TextBox();
            LDesc = new Label();
            TBProducto = new TextBox();
            LProducto = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TBVendedor);
            panel1.Location = new Point(18, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 102);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(427, 43);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(39, 39);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Vendedor: ";
            // 
            // TBVendedor
            // 
            TBVendedor.Location = new Point(155, 42);
            TBVendedor.Name = "TBVendedor";
            TBVendedor.Size = new Size(177, 23);
            TBVendedor.TabIndex = 1;
            TBVendedor.KeyPress += TBVendedor_KeyPress;
            // 
            // LVentas
            // 
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Segoe UI", 25F);
            LVentas.ForeColor = SystemColors.ControlLightLight;
            LVentas.Location = new Point(18, 13);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(119, 46);
            LVentas.TabIndex = 1;
            LVentas.Text = "Ventas";
            LVentas.Click += LVentas_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(BCancelar);
            panel2.Controls.Add(BAceptar);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(TBDomicilio);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(TBDni);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(TBApellido);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TBNombre);
            panel2.Location = new Point(694, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 406);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // BCancelar
            // 
            BCancelar.ForeColor = SystemColors.ActiveCaptionText;
            BCancelar.Location = new Point(357, 293);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(98, 23);
            BCancelar.TabIndex = 14;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            // 
            // BAceptar
            // 
            BAceptar.ForeColor = SystemColors.ActiveCaptionText;
            BAceptar.Location = new Point(137, 293);
            BAceptar.Name = "BAceptar";
            BAceptar.Size = new Size(98, 23);
            BAceptar.TabIndex = 13;
            BAceptar.Text = "Aceptar";
            BAceptar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F);
            label11.Location = new Point(203, 357);
            label11.Name = "label11";
            label11.Size = new Size(47, 25);
            label11.TabIndex = 12;
            label11.Text = "DNI:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 360);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(48, 360);
            button3.Name = "button3";
            button3.Size = new Size(105, 23);
            button3.TabIndex = 10;
            button3.Text = "Buscar Cliente";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(538, 156);
            button2.Name = "button2";
            button2.Size = new Size(105, 25);
            button2.TabIndex = 9;
            button2.Text = "Agregar Cliente";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(33, 238);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 8;
            label6.Text = "Domicilio:";
            // 
            // TBDomicilio
            // 
            TBDomicilio.Location = new Point(193, 241);
            TBDomicilio.Name = "TBDomicilio";
            TBDomicilio.Size = new Size(313, 23);
            TBDomicilio.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(33, 184);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 6;
            label5.Text = "DNI:";
            // 
            // TBDni
            // 
            TBDni.Location = new Point(193, 187);
            TBDni.Name = "TBDni";
            TBDni.Size = new Size(313, 23);
            TBDni.TabIndex = 5;
            TBDni.KeyPress += TBDni_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(33, 134);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 4;
            label4.Text = "Apellido: ";
            // 
            // TBApellido
            // 
            TBApellido.Location = new Point(193, 137);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(313, 23);
            TBApellido.TabIndex = 3;
            TBApellido.KeyPress += TBApellido_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(33, 76);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(203, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 0;
            label2.Text = "Datos del cliente";
            label2.Click += label2_Click;
            // 
            // TBNombre
            // 
            TBNombre.Location = new Point(193, 78);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(313, 23);
            TBNombre.TabIndex = 1;
            TBNombre.KeyPress += TBNombre_KeyPress;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(DTPFecha);
            panel3.Controls.Add(LFecha);
            panel3.Location = new Point(18, 427);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 133);
            panel3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(42, 75);
            label7.Name = "label7";
            label7.Size = new Size(72, 25);
            label7.TabIndex = 2;
            label7.Text = "Factura:";
            // 
            // DTPFecha
            // 
            DTPFecha.Format = DateTimePickerFormat.Short;
            DTPFecha.Location = new Point(268, 26);
            DTPFecha.Name = "DTPFecha";
            DTPFecha.Size = new Size(200, 23);
            DTPFecha.TabIndex = 1;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Font = new Font("Segoe UI", 13F);
            LFecha.Location = new Point(42, 24);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(61, 25);
            LFecha.TabIndex = 0;
            LFecha.Text = "Fecha:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 64, 0);
            panel5.Controls.Add(LVentas);
            panel5.Location = new Point(12, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1440, 86);
            panel5.TabIndex = 6;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 192, 0);
            panel6.Controls.Add(BVenta);
            panel6.Controls.Add(dgvDetalleVenta);
            panel6.Controls.Add(panel4);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(panel1);
            panel6.ForeColor = SystemColors.ControlLightLight;
            panel6.Location = new Point(12, 74);
            panel6.Name = "panel6";
            panel6.Size = new Size(1440, 833);
            panel6.TabIndex = 7;
            panel6.Paint += panel6_Paint;
            // 
            // BVenta
            // 
            BVenta.ForeColor = SystemColors.ActiveCaptionText;
            BVenta.Location = new Point(622, 676);
            BVenta.Name = "BVenta";
            BVenta.Size = new Size(111, 29);
            BVenta.TabIndex = 8;
            BVenta.Text = "Realizar venta";
            BVenta.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { id_producto, producto_descripcion, producto_cantidad, producto_costo });
            dgvDetalleVenta.Location = new Point(949, 20);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.Size = new Size(444, 122);
            dgvDetalleVenta.TabIndex = 7;
            // 
            // id_producto
            // 
            id_producto.HeaderText = "id_producto";
            id_producto.Name = "id_producto";
            // 
            // producto_descripcion
            // 
            producto_descripcion.HeaderText = "Descripcion";
            producto_descripcion.Name = "producto_descripcion";
            // 
            // producto_cantidad
            // 
            producto_cantidad.HeaderText = "Cantidad";
            producto_cantidad.Name = "producto_cantidad";
            // 
            // producto_costo
            // 
            producto_costo.HeaderText = "Precio Costo";
            producto_costo.Name = "producto_costo";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(BBuscarProducto);
            panel4.Controls.Add(TBDescripcion);
            panel4.Controls.Add(LDesc);
            panel4.Controls.Add(TBProducto);
            panel4.Controls.Add(LProducto);
            panel4.Location = new Point(18, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(893, 122);
            panel4.TabIndex = 6;
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.Font = new Font("Segoe UI", 13F);
            BBuscarProducto.ForeColor = SystemColors.ActiveCaptionText;
            BBuscarProducto.Location = new Point(761, 31);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(92, 35);
            BBuscarProducto.TabIndex = 4;
            BBuscarProducto.Text = "Buscar";
            BBuscarProducto.TextAlign = ContentAlignment.TopCenter;
            BBuscarProducto.UseVisualStyleBackColor = true;
            BBuscarProducto.Click += BBuscarProducto_Click;
            // 
            // TBDescripcion
            // 
            TBDescripcion.Location = new Point(422, 38);
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Size = new Size(292, 23);
            TBDescripcion.TabIndex = 3;
            // 
            // LDesc
            // 
            LDesc.AutoSize = true;
            LDesc.Font = new Font("Segoe UI", 13F);
            LDesc.Location = new Point(292, 36);
            LDesc.Name = "LDesc";
            LDesc.Size = new Size(113, 25);
            LDesc.TabIndex = 2;
            LDesc.Text = "Descripcion: ";
            // 
            // TBProducto
            // 
            TBProducto.Location = new Point(118, 39);
            TBProducto.Name = "TBProducto";
            TBProducto.Size = new Size(138, 23);
            TBProducto.TabIndex = 1;
            // 
            // LProducto
            // 
            LProducto.AutoSize = true;
            LProducto.Font = new Font("Segoe UI", 13F);
            LProducto.Location = new Point(9, 36);
            LProducto.Name = "LProducto";
            LProducto.Size = new Size(94, 25);
            LProducto.TabIndex = 0;
            LProducto.Text = "Producto: ";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1464, 956);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox TBVendedor;
        private Label LVentas;
        private Panel panel2;
        private Label label2;
        private TextBox TBNombre;
        private Label label6;
        private TextBox TBDomicilio;
        private Label label5;
        private TextBox TBDni;
        private Label label4;
        private TextBox TBApellido;
        private Label label3;
        private Panel panel3;
        private Label LFecha;
        private DateTimePicker DTPFecha;
        private Label label7;
        private Panel panel5;
        private Panel panel6;
        private Label label11;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button BCancelar;
        private Button BAceptar;
        private DataGridView dgvDetalleVenta;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn producto_descripcion;
        private DataGridViewTextBoxColumn producto_cantidad;
        private DataGridViewTextBoxColumn producto_costo;
        private Panel panel4;
        private Button BBuscarProducto;
        private TextBox TBDescripcion;
        private Label LDesc;
        private TextBox TBProducto;
        private Label LProducto;
        private Button button1;
        private Button BVenta;
    }
}