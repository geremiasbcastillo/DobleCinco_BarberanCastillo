namespace DobleCinco_BarberanCastillo
{
    partial class BuscarProducto
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
            dgvProductos = new DataGridView();
            BAceptar = new Button();
            BCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(60, 29);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(607, 250);
            dgvProductos.TabIndex = 0;
            // 
            // BAceptar
            // 
            BAceptar.Location = new Point(191, 319);
            BAceptar.Name = "BAceptar";
            BAceptar.Size = new Size(91, 25);
            BAceptar.TabIndex = 1;
            BAceptar.Text = "Aceptar";
            BAceptar.UseVisualStyleBackColor = true;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(405, 319);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(91, 25);
            BCancelar.TabIndex = 2;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            // 
            // BuscarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(800, 450);
            Controls.Add(BCancelar);
            Controls.Add(BAceptar);
            Controls.Add(dgvProductos);
            Name = "BuscarProducto";
            Text = "BuscarProducto";
            Load += BuscarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Button BAceptar;
        private Button BCancelar;
    }
}