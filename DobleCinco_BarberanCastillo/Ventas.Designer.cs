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
            LVentas = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            panel3 = new Panel();
            LFecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            panel4 = new Panel();
            LProducto = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            LDesc = new Label();
            LBuscar = new Button();
            textBox8 = new TextBox();
            LStockAgregar = new Label();
            textBox9 = new TextBox();
            label8 = new Label();
            textBox10 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            producto_descripcion = new DataGridViewTextBoxColumn();
            producto_cantidad = new DataGridViewTextBoxColumn();
            producto_costo = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(181, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 102);
            panel1.TabIndex = 0;
            // 
            // LVentas
            // 
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Segoe UI", 25F);
            LVentas.Location = new Point(100, 52);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(119, 46);
            LVentas.TabIndex = 1;
            LVentas.Text = "Ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Vendedor: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 23);
            textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(892, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 296);
            panel2.TabIndex = 2;
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
            // textBox2
            // 
            textBox2.Location = new Point(193, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 23);
            textBox2.TabIndex = 1;
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
            // textBox3
            // 
            textBox3.Location = new Point(193, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 23);
            textBox3.TabIndex = 3;
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
            // textBox4
            // 
            textBox4.Location = new Point(193, 187);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(313, 23);
            textBox4.TabIndex = 5;
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
            // textBox5
            // 
            textBox5.Location = new Point(193, 241);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(313, 23);
            textBox5.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(LFecha);
            panel3.Location = new Point(181, 320);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 133);
            panel3.TabIndex = 3;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(268, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
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
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(textBox10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(textBox9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(textBox8);
            panel4.Controls.Add(LStockAgregar);
            panel4.Controls.Add(LBuscar);
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(LDesc);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(LProducto);
            panel4.Location = new Point(181, 510);
            panel4.Name = "panel4";
            panel4.Size = new Size(1246, 223);
            panel4.TabIndex = 4;
            // 
            // LProducto
            // 
            LProducto.AutoSize = true;
            LProducto.Font = new Font("Segoe UI", 13F);
            LProducto.Location = new Point(43, 31);
            LProducto.Name = "LProducto";
            LProducto.Size = new Size(94, 25);
            LProducto.TabIndex = 0;
            LProducto.Text = "Producto: ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(165, 34);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(138, 23);
            textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(542, 34);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(407, 23);
            textBox7.TabIndex = 3;
            // 
            // LDesc
            // 
            LDesc.AutoSize = true;
            LDesc.Font = new Font("Segoe UI", 13F);
            LDesc.Location = new Point(420, 31);
            LDesc.Name = "LDesc";
            LDesc.Size = new Size(113, 25);
            LDesc.TabIndex = 2;
            LDesc.Text = "Descripcion: ";
            // 
            // LBuscar
            // 
            LBuscar.Font = new Font("Segoe UI", 13F);
            LBuscar.Location = new Point(1087, 31);
            LBuscar.Name = "LBuscar";
            LBuscar.Size = new Size(89, 31);
            LBuscar.TabIndex = 4;
            LBuscar.Text = "Buscar";
            LBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(143, 118);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(138, 23);
            textBox8.TabIndex = 6;
            // 
            // LStockAgregar
            // 
            LStockAgregar.AutoSize = true;
            LStockAgregar.Font = new Font("Segoe UI", 13F);
            LStockAgregar.Location = new Point(42, 115);
            LStockAgregar.Name = "LStockAgregar";
            LStockAgregar.Size = new Size(64, 25);
            LStockAgregar.TabIndex = 5;
            LStockAgregar.Text = "Stock: ";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(465, 118);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(138, 23);
            textBox9.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(333, 115);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 7;
            label8.Text = "Precio Costo:";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(779, 118);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(138, 23);
            textBox10.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F);
            label9.Location = new Point(644, 115);
            label9.Name = "label9";
            label9.Size = new Size(118, 25);
            label9.TabIndex = 9;
            label9.Text = "Precio Venta: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.Location = new Point(959, 115);
            label10.Name = "label10";
            label10.Size = new Size(87, 25);
            label10.TabIndex = 11;
            label10.Text = "Cantidad:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(560, 170);
            button1.Name = "button1";
            button1.Size = new Size(92, 37);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_producto, producto_descripcion, producto_cantidad, producto_costo });
            dataGridView1.Location = new Point(181, 803);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1246, 144);
            dataGridView1.TabIndex = 5;
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
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1856, 1061);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(LVentas);
            Controls.Add(panel1);
            Name = "Ventas";
            Text = "Ventas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Label LVentas;
        private Panel panel2;
        private Label label2;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Panel panel3;
        private Label LFecha;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Panel panel4;
        private TextBox textBox6;
        private Label LProducto;
        private Button LBuscar;
        private TextBox textBox7;
        private Label LDesc;
        private Button button1;
        private Label label10;
        private TextBox textBox10;
        private Label label9;
        private TextBox textBox9;
        private Label label8;
        private TextBox textBox8;
        private Label LStockAgregar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn producto_descripcion;
        private DataGridViewTextBoxColumn producto_cantidad;
        private DataGridViewTextBoxColumn producto_costo;
    }
}