namespace DobleCinco_BarberanCastillo
{
    partial class ReporteProducto
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            LVentas = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            BLimpiar = new Button();
            BBuscar = new Button();
            label2 = new Label();
            label1 = new Label();
            DTPHasta = new DateTimePicker();
            DTPDesde = new DateTimePicker();
            LFiltro = new Label();
            groupBox1 = new GroupBox();
            RBMonto = new RadioButton();
            RBCantidad = new RadioButton();
            CHProductosPorMonto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CHProductosPorCantidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CHProductosPorMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CHProductosPorCantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(LVentas);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1624, 99);
            panel1.TabIndex = 1;
            // 
            // LVentas
            // 
            LVentas.AutoSize = true;
            LVentas.Font = new Font("Segoe UI", 25F);
            LVentas.ForeColor = SystemColors.ControlLightLight;
            LVentas.Location = new Point(11, 27);
            LVentas.Name = "LVentas";
            LVentas.Size = new Size(385, 46);
            LVentas.TabIndex = 2;
            LVentas.Text = "Productos mas vendidos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(CHProductosPorMonto);
            panel2.Controls.Add(CHProductosPorCantidad);
            panel2.Location = new Point(1, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(1629, 892);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 64, 0);
            panel3.Controls.Add(BLimpiar);
            panel3.Controls.Add(BBuscar);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(DTPHasta);
            panel3.Controls.Add(DTPDesde);
            panel3.Controls.Add(LFiltro);
            panel3.Location = new Point(417, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(549, 147);
            panel3.TabIndex = 3;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(79, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "Desde";
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
            LFiltro.Click += LFiltro_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RBMonto);
            groupBox1.Controls.Add(RBCantidad);
            groupBox1.Font = new Font("Segoe UI", 13F);
            groupBox1.Location = new Point(53, 381);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(263, 111);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ver gráfico por:";
            // 
            // RBMonto
            // 
            RBMonto.AutoSize = true;
            RBMonto.Location = new Point(10, 76);
            RBMonto.Name = "RBMonto";
            RBMonto.Size = new Size(119, 29);
            RBMonto.TabIndex = 1;
            RBMonto.TabStop = true;
            RBMonto.Text = "Por monto:";
            RBMonto.UseVisualStyleBackColor = true;
            RBMonto.CheckedChanged += RBMonto_CheckedChanged;
            // 
            // RBCantidad
            // 
            RBCantidad.AutoSize = true;
            RBCantidad.Location = new Point(10, 39);
            RBCantidad.Name = "RBCantidad";
            RBCantidad.Size = new Size(133, 29);
            RBCantidad.TabIndex = 0;
            RBCantidad.TabStop = true;
            RBCantidad.Text = "Por cantidad:";
            RBCantidad.UseVisualStyleBackColor = true;
            RBCantidad.CheckedChanged += RBCantidad_CheckedChanged;
            // 
            // CHProductosPorMonto
            // 
            CHProductosPorMonto.BackColor = Color.Transparent;
            CHProductosPorMonto.BorderlineColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            CHProductosPorMonto.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            CHProductosPorMonto.Legends.Add(legend1);
            CHProductosPorMonto.Location = new Point(399, 305);
            CHProductosPorMonto.Name = "CHProductosPorMonto";
            CHProductosPorMonto.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            CHProductosPorMonto.Series.Add(series1);
            CHProductosPorMonto.Size = new Size(667, 299);
            CHProductosPorMonto.TabIndex = 1;
            CHProductosPorMonto.Text = "chart1";
            CHProductosPorMonto.Click += CHProductosPorMonto_Click;
            // 
            // CHProductosPorCantidad
            // 
            CHProductosPorCantidad.BackColor = Color.Transparent;
            CHProductosPorCantidad.BorderlineColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            CHProductosPorCantidad.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            CHProductosPorCantidad.Legends.Add(legend2);
            CHProductosPorCantidad.Location = new Point(399, 305);
            CHProductosPorCantidad.Name = "CHProductosPorCantidad";
            CHProductosPorCantidad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            CHProductosPorCantidad.Series.Add(series2);
            CHProductosPorCantidad.Size = new Size(667, 299);
            CHProductosPorCantidad.TabIndex = 0;
            CHProductosPorCantidad.Text = "chart1";
            // 
            // ReporteProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1603, 978);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReporteProducto";
            Text = "ReporteProducto";
            Load += ReporteProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CHProductosPorMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)CHProductosPorCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LVentas;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHProductosPorCantidad;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHProductosPorMonto;
        private GroupBox groupBox1;
        private RadioButton RBMonto;
        private RadioButton RBCantidad;
        private Panel panel3;
        private DateTimePicker DTPDesde;
        private Label LFiltro;
        private Label label1;
        private DateTimePicker DTPHasta;
        private Button BBuscar;
        private Label label2;
        private Button BLimpiar;
    }
}