namespace DobleCinco_BarberanCastillo.Controles
{
    partial class CUFormaDePago
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
            CBFormaDePago = new ComboBox();
            SuspendLayout();
            // 
            // CBFormaDePago
            // 
            CBFormaDePago.FormattingEnabled = true;
            CBFormaDePago.Location = new Point(0, 0);
            CBFormaDePago.Name = "CBFormaDePago";
            CBFormaDePago.Size = new Size(195, 23);
            CBFormaDePago.TabIndex = 0;
            CBFormaDePago.SelectedIndexChanged += CBFormaDePago_SelectedIndexChanged;
            // 
            // CUFormaDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CBFormaDePago);
            Name = "CUFormaDePago";
            Size = new Size(210, 24);
            Load += UserControl1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CBFormaDePago;
    }
}
