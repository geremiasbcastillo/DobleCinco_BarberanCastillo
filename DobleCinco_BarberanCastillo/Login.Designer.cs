namespace DobleCinco_BarberanCastillo
{
    partial class Login
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
            panel2 = new Panel();
            label1 = new Label();
            TBDni = new TextBox();
            TBContraseña = new TextBox();
            label2 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 129, 0);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 468);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(TBContraseña);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TBDni);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(111, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 276);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // TBDni
            // 
            TBDni.Location = new Point(129, 32);
            TBDni.Name = "TBDni";
            TBDni.Size = new Size(137, 23);
            TBDni.TabIndex = 1;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(129, 117);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(137, 23);
            TBContraseña.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(18, 114);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(96, 191);
            button1.Name = "button1";
            button1.Size = new Size(87, 32);
            button1.TabIndex = 4;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 64, 0);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(533, 62);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(11, 20);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 0;
            label3.Text = "Iniciar Sesión";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 465);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private Button button1;
        private TextBox TBContraseña;
        private Label label2;
        private TextBox TBDni;
    }
}