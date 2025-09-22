namespace DobleCinco_BarberanCastillo.Controles
{
    partial class CUPerfil
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            CBPerfil = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // CBPerfil
            // 
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Location = new Point(0, 0);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(233, 23);
            CBPerfil.TabIndex = 0;
            CBPerfil.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // CUPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(CBPerfil);
            Name = "CUPerfil";
            Size = new Size(234, 24);
            Load += CUPerfil_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CBPerfil;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
