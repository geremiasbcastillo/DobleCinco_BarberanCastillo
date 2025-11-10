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
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CHVendedores).BeginInit();
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
            CHVendedores.Location = new Point(260, 209);
            CHVendedores.Name = "CHVendedores";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            CHVendedores.Series.Add(series1);
            CHVendedores.Size = new Size(493, 300);
            CHVendedores.TabIndex = 3;
            CHVendedores.Text = "chart1";
            // 
            // ReporteVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(1297, 596);
            Controls.Add(CHVendedores);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ReporteVendedores";
            Text = "ReporteVendedores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CHVendedores).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label LVentas;
        private Panel panel3;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHVendedores;
    }
}