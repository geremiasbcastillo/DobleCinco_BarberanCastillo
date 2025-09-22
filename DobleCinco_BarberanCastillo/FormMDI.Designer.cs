
namespace DobleCinco_BarberanCastillo
{
    partial class FormMDI
    {
        private const string V = "Usuario";

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            ReportesToolStripMenuItem = new ToolStripMenuItem();
            RUsuarioToolStripMenuItem = new ToolStripMenuItem();
            RVentasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGreen;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, productosToolStripMenuItem, ventasToolStripMenuItem, ReportesToolStripMenuItem, RUsuarioToolStripMenuItem, RVentasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(134, 450);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            usuarioToolStripMenuItem.Image = Properties.Resources.history;
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(121, 40);
            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            productosToolStripMenuItem.Margin = new Padding(0, 15, 0, 15);
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(121, 24);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(121, 24);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // ReportesToolStripMenuItem
            // 
            ReportesToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            ReportesToolStripMenuItem.Margin = new Padding(0, 15, 0, 15);
            ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem";
            ReportesToolStripMenuItem.Size = new Size(121, 24);
            ReportesToolStripMenuItem.Text = "Reportes";
            ReportesToolStripMenuItem.Click += ReportesToolStripMenuItem_Click;
            // 
            // RUsuarioToolStripMenuItem
            // 
            RUsuarioToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            RUsuarioToolStripMenuItem.Margin = new Padding(0, 15, 0, 15);
            RUsuarioToolStripMenuItem.Name = "RUsuarioToolStripMenuItem";
            RUsuarioToolStripMenuItem.Size = new Size(121, 24);
            RUsuarioToolStripMenuItem.Text = "Reporte Usuario";
            RUsuarioToolStripMenuItem.Click += RUsuarioToolStripMenuItem_Click;
            // 
            // RVentasToolStripMenuItem
            // 
            RVentasToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            RVentasToolStripMenuItem.Margin = new Padding(0, 15, 0, 15);
            RVentasToolStripMenuItem.Name = "RVentasToolStripMenuItem";
            RVentasToolStripMenuItem.Size = new Size(121, 24);
            RVentasToolStripMenuItem.Text = "Reportes ventas";
            RVentasToolStripMenuItem.Click += RVentasToolStripMenuItem_Click;
            // 
            // FormMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMDI";
            Text = "Form1";
            Load += FormMDI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem ReportesToolStripMenuItem;
        private ToolStripMenuItem RUsuarioToolStripMenuItem;
        private ToolStripMenuItem RVentasToolStripMenuItem;
    }
}
