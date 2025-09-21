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
            panel1 = new Panel();
            LVentas = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(LVentas);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1624, 96);
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
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-7, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(1629, 539);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 64, 0);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(582, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 268);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(217, 168);
            button1.Name = "button1";
            button1.Size = new Size(98, 34);
            button1.TabIndex = 5;
            button1.Text = "Generar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(337, 105);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(104, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(88, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(104, 23);
            dateTimePicker1.TabIndex = 3;
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
            // ReporteVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 622);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReporteVenta";
            Text = "ReporteVenta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
    }
}