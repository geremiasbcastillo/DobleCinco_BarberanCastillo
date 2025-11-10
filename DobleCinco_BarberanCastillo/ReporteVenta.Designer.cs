namespace DobleCinco_BarberanCastillo
{
    partial class ReporteVenta
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
            panel1 = new Panel();
            LVentas = new Label();
            panel2 = new Panel();
            dgvVentas = new DataGridView();
            label4 = new Label();
            panel3 = new Panel();
            BGenerar = new Button();
            button1 = new Button();
            DTFechaHasta = new DateTimePicker();
            DTFechaDesde = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(LVentas);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 96);
            panel1.TabIndex = 0;
            // 
            // LVentas
            // 
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Segoe UI", 25F);
            LVentas.ForeColor = SystemColors.ControlLightLight;
            LVentas.Location = new Point(11, 27);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(294, 46);
            LVentas.TabIndex = 2;
            LVentas.Text = "Reporte de Ventas";
            LVentas.Click += LVentas_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(dgvVentas);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(1, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1022, 678);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(106, 338);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(795, 274);
            dgvVentas.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(430, 295);
            label4.Name = "label4";
            label4.Size = new Size(163, 28);
            label4.TabIndex = 1;
            label4.Text = "Listado de ventas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 64, 0);
            panel3.Controls.Add(BGenerar);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(DTFechaHasta);
            panel3.Controls.Add(DTFechaDesde);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(242, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 202);
            panel3.TabIndex = 0;
            // 
            // BGenerar
            // 
            BGenerar.Location = new Point(218, 165);
            BGenerar.Name = "BGenerar";
            BGenerar.Size = new Size(108, 23);
            BGenerar.TabIndex = 6;
            BGenerar.Text = "Generar";
            BGenerar.UseVisualStyleBackColor = true;
            BGenerar.Click += BGenerar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(564, 9);
            button1.Name = "button1";
            button1.Size = new Size(98, 34);
            button1.TabIndex = 5;
            button1.Text = "Generar";
            button1.UseVisualStyleBackColor = true;
            // 
            // DTFechaHasta
            // 
            DTFechaHasta.Format = DateTimePickerFormat.Short;
            DTFechaHasta.Location = new Point(337, 105);
            DTFechaHasta.Name = "DTFechaHasta";
            DTFechaHasta.Size = new Size(104, 23);
            DTFechaHasta.TabIndex = 4;
            // 
            // DTFechaDesde
            // 
            DTFechaDesde.Format = DateTimePickerFormat.Short;
            DTFechaDesde.Location = new Point(88, 105);
            DTFechaDesde.Name = "DTFechaDesde";
            DTFechaDesde.Size = new Size(104, 23);
            DTFechaDesde.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(353, 67);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 2;
            label3.Text = "Hasta: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(70, 67);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 1;
            label2.Text = "Generar desde: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(207, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "--- Fecha ---";
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // ReporteVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 1061);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReporteVenta";
            Text = "ReporteVenta";
            Load += ReporteVenta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LVentas;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Button button1;
        private DateTimePicker DTFechaHasta;
        private DateTimePicker DTFechaDesde;
        private Label label3;
        private BindingSource bindingSource1;
        private Label label4;
        private DataGridView dgvVentas;
        private Button BGenerar;
    }
}