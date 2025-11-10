namespace DobleCinco_BarberanCastillo
{
    partial class Reportes
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
            panel4 = new Panel();
            BProductos = new Button();
            button2 = new Button();
            BVendedores = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(LVentas);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1602, 85);
            panel1.TabIndex = 0;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(2, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(1601, 800);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 64, 0);
            panel4.Controls.Add(BProductos);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(BVendedores);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(399, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(848, 221);
            panel4.TabIndex = 3;
            // 
            // BProductos
            // 
            BProductos.Font = new Font("Segoe UI", 9F);
            BProductos.Location = new Point(361, 151);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(119, 44);
            BProductos.TabIndex = 5;
            BProductos.Text = "Productos más vendidos";
            BProductos.UseVisualStyleBackColor = true;
            BProductos.Click += BProductos_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(582, 85);
            button2.Name = "button2";
            button2.Size = new Size(137, 44);
            button2.TabIndex = 4;
            button2.Text = "Ventas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BVendedores
            // 
            BVendedores.Font = new Font("Segoe UI", 9F);
            BVendedores.Location = new Point(110, 85);
            BVendedores.Name = "BVendedores";
            BVendedores.Size = new Size(148, 44);
            BVendedores.TabIndex = 3;
            BVendedores.Text = "Vendedores con mas ventas";
            BVendedores.UseVisualStyleBackColor = true;
            BVendedores.Click += BVendedores_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(286, 11);
            label4.Name = "label4";
            label4.Size = new Size(271, 38);
            label4.TabIndex = 2;
            label4.Text = "Generar reporte por:";
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1599, 883);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Reportes";
            Text = "Reportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label LVentas;
        private Panel panel4;
        private Button button2;
        private Button BVendedores;
        private Label label4;
        private Button BProductos;
    }
}