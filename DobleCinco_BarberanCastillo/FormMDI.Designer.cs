
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
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGreen;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, productosToolStripMenuItem, ventasToolStripMenuItem, ReportesToolStripMenuItem, RUsuarioToolStripMenuItem, RVentasToolStripMenuItem, cerrarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(134, 450);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.BackColor = Color.LightGreen;
            usuarioToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            usuarioToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            usuarioToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            usuarioToolStripMenuItem.ImageAlign = ContentAlignment.TopRight;
            usuarioToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usuarioToolStripMenuItem.Margin = new Padding(0, 70, 0, 0);
            usuarioToolStripMenuItem.MergeIndex = 0;
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Padding = new Padding(0);
            usuarioToolStripMenuItem.Size = new Size(121, 24);
            usuarioToolStripMenuItem.Text = "Usuario";
            usuarioToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.BackColor = Color.LightGreen;
            productosToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            productosToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            productosToolStripMenuItem.Margin = new Padding(0, 15, 0, 0);
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(121, 24);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.BackColor = Color.LightGreen;
            ventasToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            ventasToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            ventasToolStripMenuItem.Margin = new Padding(0, 15, 0, 0);
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(121, 24);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // ReportesToolStripMenuItem
            // 
            ReportesToolStripMenuItem.BackColor = Color.LightGreen;
            ReportesToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            ReportesToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            ReportesToolStripMenuItem.Margin = new Padding(0, 15, 0, 0);
            ReportesToolStripMenuItem.MergeAction = MergeAction.Remove;
            ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem";
            ReportesToolStripMenuItem.Size = new Size(121, 24);
            ReportesToolStripMenuItem.Text = "Reportes";
            ReportesToolStripMenuItem.Click += ReportesToolStripMenuItem_Click;
            // 
            // RUsuarioToolStripMenuItem
            // 
            RUsuarioToolStripMenuItem.BackColor = Color.LightGreen;
            RUsuarioToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            RUsuarioToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            RUsuarioToolStripMenuItem.Margin = new Padding(0, 15, 0, 0);
            RUsuarioToolStripMenuItem.Name = "RUsuarioToolStripMenuItem";
            RUsuarioToolStripMenuItem.Size = new Size(121, 24);
            RUsuarioToolStripMenuItem.Text = "Reporte Usuario";
            RUsuarioToolStripMenuItem.Click += RUsuarioToolStripMenuItem_Click;
            // 
            // RVentasToolStripMenuItem
            // 
            RVentasToolStripMenuItem.BackColor = Color.LightGreen;
            RVentasToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            RVentasToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            RVentasToolStripMenuItem.Margin = new Padding(0, 15, 0, 0);
            RVentasToolStripMenuItem.Name = "RVentasToolStripMenuItem";
            RVentasToolStripMenuItem.Size = new Size(121, 24);
            RVentasToolStripMenuItem.Text = "Reporte ventas";
            RVentasToolStripMenuItem.Click += RVentasToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            cerrarSesionToolStripMenuItem.Font = new Font("Segoe UI", 11F);
            cerrarSesionToolStripMenuItem.Image = Properties.Resources.salida;
            cerrarSesionToolStripMenuItem.Margin = new Padding(0, 0, 0, 10);
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(121, 24);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
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
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}
