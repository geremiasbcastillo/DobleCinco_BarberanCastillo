namespace DobleCinco_BarberanCastillo
{
    partial class ReporteUsuario
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
            LVentas.Size = new Size(322, 46);
            LVentas.TabIndex = 2;
            LVentas.Text = "Reporte de Usuarios";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(1, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(1629, 539);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 64, 0);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(555, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 268);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(221, 188);
            button1.Name = "button1";
            button1.Size = new Size(96, 39);
            button1.TabIndex = 5;
            button1.Text = "Generar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(36, 44);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 6;
            label1.Text = "Tipo de usuario:";
            // 
            // ReporteUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1603, 632);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReporteUsuario";
            Text = "ReporteUsuario";
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
        private Label label1;
        private Button button1;
    }
}