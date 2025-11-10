namespace DobleCinco_BarberanCastillo
{
    partial class ReporteVendedores
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            LVentas = new Label();
            panel3 = new Panel();
            label1 = new Label();
            CHVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            BLimpiar = new Button();
            BBuscar = new Button();
            label2 = new Label();
            label3 = new Label();
            DTPHasta = new DateTimePicker();
            DTPDesde = new DateTimePicker();
            LFiltro = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CHVendedores).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(LVentas);
            panel1.Location = new Point(-301, -143);
            panel1.Name = "panel1";
            panel1.Size = new Size(1602, 85);
            panel1.TabIndex = 2;
            // 
            // LVentas
            // 
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Segoe UI", 25F);
            LVentas.ForeColor = SystemColors.ControlLightLight;
            LVentas.Location = new Point(32, 19);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(153, 46);
            LVentas.TabIndex = 3;
            LVentas.Text = "Reportes";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 56, 0);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(-2, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1306, 101);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(42, 30);
            label1.Name = "label1";
            label1.Size = new Size(398, 46);
            label1.TabIndex = 4;
            label1.Text = "Reportes por vendedores";
            // 
            // CHVendedores
            // 
            CHVendedores.BackColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            CHVendedores.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            CHVendedores.Legends.Add(legend1);
            CHVendedores.Location = new Point(439, 303);
            CHVendedores.Name = "CHVendedores";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            CHVendedores.Series.Add(series1);
            CHVendedores.Size = new Size(493, 300);
            CHVendedores.TabIndex = 3;
            CHVendedores.Text = "chart1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(BLimpiar);
            panel2.Controls.Add(BBuscar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(DTPHasta);
            panel2.Controls.Add(DTPDesde);
            panel2.Controls.Add(LFiltro);
            panel2.Location = new Point(406, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(549, 147);
            panel2.TabIndex = 4;
            // 
            // BLimpiar
            // 
            BLimpiar.Location = new Point(128, 108);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(99, 23);
            BLimpiar.TabIndex = 6;
            BLimpiar.Text = "Limpiar Filtros";
            BLimpiar.UseVisualStyleBackColor = true;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // BBuscar
            // 
            BBuscar.Location = new Point(295, 108);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(86, 23);
            BBuscar.TabIndex = 5;
            BBuscar.Text = "Buscar";
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(389, 31);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "Hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(79, 31);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 3;
            label3.Text = "Desde";
            // 
            // DTPHasta
            // 
            DTPHasta.Format = DateTimePickerFormat.Short;
            DTPHasta.Location = new Point(317, 54);
            DTPHasta.Name = "DTPHasta";
            DTPHasta.Size = new Size(200, 23);
            DTPHasta.TabIndex = 2;
            // 
            // DTPDesde
            // 
            DTPDesde.Format = DateTimePickerFormat.Short;
            DTPDesde.Location = new Point(26, 54);
            DTPDesde.Name = "DTPDesde";
            DTPDesde.Size = new Size(175, 23);
            DTPDesde.TabIndex = 1;
            // 
            // LFiltro
            // 
            LFiltro.AutoSize = true;
            LFiltro.Font = new Font("Segoe UI", 12F);
            LFiltro.ForeColor = SystemColors.ButtonHighlight;
            LFiltro.Location = new Point(198, 9);
            LFiltro.Name = "LFiltro";
            LFiltro.Size = new Size(123, 21);
            LFiltro.TabIndex = 0;
            LFiltro.Text = "Filtrar por fecha:";
            // 
            // ReporteVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(1297, 615);
            Controls.Add(panel2);
            Controls.Add(CHVendedores);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ReporteVendedores";
            Text = "ReporteVendedores";
            Load += ReporteVendedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CHVendedores).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label LVentas;
        private Panel panel3;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHVendedores;
        private Panel panel2;
        private Button BLimpiar;
        private Button BBuscar;
        private Label label2;
        private Label label3;
        private DateTimePicker DTPHasta;
        private DateTimePicker DTPDesde;
        private Label LFiltro;
    }
}