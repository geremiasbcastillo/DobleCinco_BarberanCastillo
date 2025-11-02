namespace DobleCinco_BarberanCastillo
{
    partial class BackUp
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
            LTitulo = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel2 = new Panel();
            BRealizar = new Button();
            BElegirCarpeta = new Button();
            TBRuta = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(LTitulo);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1825, 85);
            panel1.TabIndex = 1;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Segoe UI", 25F);
            LTitulo.ForeColor = SystemColors.ControlLightLight;
            LTitulo.Location = new Point(32, 19);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(132, 46);
            LTitulo.TabIndex = 3;
            LTitulo.Text = "BackUp";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(BRealizar);
            panel2.Controls.Add(BElegirCarpeta);
            panel2.Controls.Add(TBRuta);
            panel2.Location = new Point(397, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(679, 277);
            panel2.TabIndex = 2;
            // 
            // BRealizar
            // 
            BRealizar.Location = new Point(278, 162);
            BRealizar.Name = "BRealizar";
            BRealizar.Size = new Size(114, 37);
            BRealizar.TabIndex = 2;
            BRealizar.Text = "Realizar back up";
            BRealizar.UseVisualStyleBackColor = true;
            BRealizar.Click += BRealizar_Click;
            // 
            // BElegirCarpeta
            // 
            BElegirCarpeta.Location = new Point(93, 58);
            BElegirCarpeta.Name = "BElegirCarpeta";
            BElegirCarpeta.Size = new Size(94, 23);
            BElegirCarpeta.TabIndex = 1;
            BElegirCarpeta.Text = "Elegir carpeta";
            BElegirCarpeta.UseVisualStyleBackColor = true;
            BElegirCarpeta.Click += BElegirCarpeta_Click;
            // 
            // TBRuta
            // 
            TBRuta.Location = new Point(325, 58);
            TBRuta.Name = "TBRuta";
            TBRuta.Size = new Size(270, 23);
            TBRuta.TabIndex = 0;
            // 
            // BackUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(1791, 1061);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "BackUp";
            Text = "BackUp";
            Load += BackUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LTitulo;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel2;
        private Button BElegirCarpeta;
        private TextBox TBRuta;
        private Button BRealizar;
    }
}