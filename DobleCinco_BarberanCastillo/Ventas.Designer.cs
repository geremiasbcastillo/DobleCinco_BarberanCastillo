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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            LVentas = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            DTPFecha = new DateTimePicker();
            LFecha = new Label();
            panel2 = new Panel();
            LTelefono = new Label();
            TBTelefono = new TextBox();
            BCancelar = new Button();
            BAceptar = new Button();
            label11 = new Label();
            TBDniSearch = new TextBox();
            BBuscarCliente = new Button();
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
            BVenta = new Button();
            dgvDetalleVenta = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            producto_descripcion = new DataGridViewTextBoxColumn();
            producto_cantidad = new DataGridViewTextBoxColumn();
            producto_precio = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            BBuscarProducto = new Button();
            TBDescripcion = new TextBox();
            LDesc = new Label();
            TBProducto = new TextBox();
            LProducto = new Label();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
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
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 64, 0);
            panel5.Controls.Add(LVentas);
            panel5.Location = new Point(12, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1440, 86);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 192, 0);
            panel6.Controls.Add(panel3);
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(BVenta);
            panel6.Controls.Add(dgvDetalleVenta);
            panel6.Controls.Add(panel4);
            panel6.ForeColor = SystemColors.ControlLightLight;
            panel6.Location = new Point(12, 74);
            panel6.Name = "panel6";
            panel6.Size = new Size(1440, 833);
            panel6.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(DTPFecha);
            panel3.Controls.Add(LFecha);
            panel3.Location = new Point(51, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 133);
            panel3.TabIndex = 10;
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
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(LTelefono);
            panel2.Controls.Add(TBTelefono);
            panel2.Controls.Add(BCancelar);
            panel2.Controls.Add(BAceptar);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(TBDniSearch);
            panel2.Controls.Add(BBuscarCliente);
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
            panel2.Location = new Point(695, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(651, 462);
            panel2.TabIndex = 9;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Segoe UI", 13F);
            LTelefono.Location = new Point(33, 289);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(83, 25);
            LTelefono.TabIndex = 16;
            LTelefono.Text = "Telefono:";
            // 
            // TBTelefono
            // 
            TBTelefono.Enabled = false;
            TBTelefono.Location = new Point(193, 292);
            TBTelefono.Name = "TBTelefono";
            TBTelefono.Size = new Size(313, 23);
            TBTelefono.TabIndex = 15;
            // 
            // BCancelar
            // 
            BCancelar.ForeColor = SystemColors.ActiveCaptionText;
            BCancelar.Location = new Point(357, 346);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(98, 23);
            BCancelar.TabIndex = 14;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            // 
            // BAceptar
            // 
            BAceptar.ForeColor = SystemColors.ActiveCaptionText;
            BAceptar.Location = new Point(137, 346);
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
            label11.Location = new Point(203, 410);
            label11.Name = "label11";
            label11.Size = new Size(47, 25);
            label11.TabIndex = 12;
            label11.Text = "DNI:";
            // 
            // TBDniSearch
            // 
            TBDniSearch.Location = new Point(290, 413);
            TBDniSearch.Name = "TBDniSearch";
            TBDniSearch.Size = new Size(216, 23);
            TBDniSearch.TabIndex = 11;
            // 
            // BBuscarCliente
            // 
            BBuscarCliente.ForeColor = SystemColors.ActiveCaptionText;
            BBuscarCliente.Location = new Point(48, 413);
            BBuscarCliente.Name = "BBuscarCliente";
            BBuscarCliente.Size = new Size(105, 23);
            BBuscarCliente.TabIndex = 10;
            BBuscarCliente.Text = "Buscar Cliente";
            BBuscarCliente.UseVisualStyleBackColor = true;
            BBuscarCliente.Click += BBuscarCliente_Click;
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
            TBDomicilio.Enabled = false;
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
            TBDni.Enabled = false;
            TBDni.Location = new Point(193, 187);
            TBDni.Name = "TBDni";
            TBDni.Size = new Size(313, 23);
            TBDni.TabIndex = 5;
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
            TBApellido.Enabled = false;
            TBApellido.Location = new Point(193, 137);
            TBApellido.Name = "TBApellido";
            TBApellido.Size = new Size(313, 23);
            TBApellido.TabIndex = 3;
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
            // 
            // TBNombre
            // 
            TBNombre.Enabled = false;
            TBNombre.Location = new Point(193, 78);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(313, 23);
            TBNombre.TabIndex = 1;
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
            BVenta.Click += BVenta_Click;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.AllowUserToAddRows = false;
            dgvDetalleVenta.AllowUserToDeleteRows = false;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { id_producto, producto_descripcion, producto_cantidad, producto_precio });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalleVenta.Location = new Point(949, 498);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            // producto_precio
            // 
            producto_precio.HeaderText = "Precio";
            producto_precio.Name = "producto_precio";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(BBuscarProducto);
            panel4.Controls.Add(TBDescripcion);
            panel4.Controls.Add(LDesc);
            panel4.Controls.Add(TBProducto);
            panel4.Controls.Add(LProducto);
            panel4.Location = new Point(18, 498);
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LVentas;
        private Panel panel5;
        private Panel panel6;
        private DataGridView dgvDetalleVenta;
        private Panel panel4;
        private Button BBuscarProducto;
        private TextBox TBDescripcion;
        private Label LDesc;
        private TextBox TBProducto;
        private Label LProducto;
        private Button BVenta;
        private Panel panel3;
        private Label label7;
        private DateTimePicker DTPFecha;
        private Label LFecha;
        private Panel panel2;
        private Button BCancelar;
        private Button BAceptar;
        private Label label11;
        private TextBox TBDniSearch;
        private Button BBuscarCliente;
        private Button button2;
        private Label label6;
        private TextBox TBDomicilio;
        private Label label5;
        private TextBox TBDni;
        private Label label4;
        private TextBox TBApellido;
        private Label label3;
        private Label label2;
        private TextBox TBNombre;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn producto_descripcion;
        private DataGridViewTextBoxColumn producto_cantidad;
        private DataGridViewTextBoxColumn producto_precio;
        private Label LTelefono;
        private TextBox TBTelefono;
    }
}