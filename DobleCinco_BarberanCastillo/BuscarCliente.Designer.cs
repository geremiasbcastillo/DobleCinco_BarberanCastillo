namespace DobleCinco_BarberanCastillo
{
    partial class BuscarCliente
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
            dgvClientes = new DataGridView();
            BCancelar = new Button();
            BAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(67, 54);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(607, 250);
            dgvClientes.TabIndex = 1;
            // 
            // BCancelar
            // 
            BCancelar.Location = new Point(441, 360);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(91, 25);
            BCancelar.TabIndex = 4;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            BCancelar.Click += BCancelar_Click;
            // 
            // BAceptar
            // 
            BAceptar.Location = new Point(227, 360);
            BAceptar.Name = "BAceptar";
            BAceptar.Size = new Size(91, 25);
            BAceptar.TabIndex = 3;
            BAceptar.Text = "Aceptar";
            BAceptar.UseVisualStyleBackColor = true;
            BAceptar.Click += BAceptar_Click;
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(800, 450);
            Controls.Add(BCancelar);
            Controls.Add(BAceptar);
            Controls.Add(dgvClientes);
            Name = "BuscarCliente";
            Text = "Buscar Cliente";
            Load += BuscarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Button BCancelar;
        private Button BAceptar;
    }
}