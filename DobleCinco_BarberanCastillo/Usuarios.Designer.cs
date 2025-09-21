namespace DobleCinco_BarberanCastillo
{
    partial class Usuarios
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
            LUsuarios = new Label();
            LNombre = new Label();
            TNombre = new TextBox();
            TApellido = new TextBox();
            LApellido = new Label();
            TDni = new TextBox();
            LDNI = new Label();
            TCorreo = new TextBox();
            LCorreo = new Label();
            TContraseña = new TextBox();
            LContraseña = new Label();
            TTelefono = new TextBox();
            LTelefono = new Label();
            TDireccion = new TextBox();
            Direccion = new Label();
            LFecha = new Label();
            dgvUsuarios = new DataGridView();
            BAgregar = new Button();
            DTFecha = new DateTimePicker();
            panel5 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LUsuarios
            // 
            LUsuarios.AutoSize = true;
            LUsuarios.Font = new Font("Segoe UI", 25F);
            LUsuarios.ForeColor = SystemColors.ControlLightLight;
            LUsuarios.Location = new Point(21, 18);
            LUsuarios.Name = "LUsuarios";
            LUsuarios.Size = new Size(147, 46);
            LUsuarios.TabIndex = 0;
            LUsuarios.Text = "Usuarios";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 15F);
            LNombre.Location = new Point(100, 15);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(85, 28);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(284, 20);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(228, 23);
            TNombre.TabIndex = 2;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(284, 70);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(228, 23);
            TApellido.TabIndex = 4;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 15F);
            LApellido.Location = new Point(100, 65);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(86, 28);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // TDni
            // 
            TDni.Location = new Point(284, 120);
            TDni.Name = "TDni";
            TDni.Size = new Size(228, 23);
            TDni.TabIndex = 6;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Font = new Font("Segoe UI", 15F);
            LDNI.Location = new Point(100, 115);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(46, 28);
            LDNI.TabIndex = 5;
            LDNI.Text = "DNI";
            // 
            // TCorreo
            // 
            TCorreo.Location = new Point(284, 170);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(228, 23);
            TCorreo.TabIndex = 8;
            TCorreo.KeyPress += TCorreo_KeyPress;
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Segoe UI", 15F);
            LCorreo.Location = new Point(100, 165);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(72, 28);
            LCorreo.TabIndex = 7;
            LCorreo.Text = "Correo";
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(831, 20);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(228, 23);
            TContraseña.TabIndex = 10;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Font = new Font("Segoe UI", 15F);
            LContraseña.Location = new Point(625, 15);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(110, 28);
            LContraseña.TabIndex = 9;
            LContraseña.Text = "Contraseña";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(831, 70);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(228, 23);
            TTelefono.TabIndex = 12;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Segoe UI", 15F);
            LTelefono.Location = new Point(625, 65);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(86, 28);
            LTelefono.TabIndex = 11;
            LTelefono.Text = "Telefono";
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(831, 120);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(228, 23);
            TDireccion.TabIndex = 14;
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Font = new Font("Segoe UI", 15F);
            Direccion.Location = new Point(625, 115);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(94, 28);
            Direccion.TabIndex = 13;
            Direccion.Text = "Direccion";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Font = new Font("Segoe UI", 15F);
            LFecha.Location = new Point(625, 165);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(191, 28);
            LFecha.TabIndex = 15;
            LFecha.Text = "Fecha de nacimiento";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(205, 310);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(798, 366);
            dgvUsuarios.TabIndex = 19;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Segoe UI", 12F);
            BAgregar.ForeColor = SystemColors.ActiveCaptionText;
            BAgregar.Location = new Point(522, 230);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(157, 43);
            BAgregar.TabIndex = 20;
            BAgregar.Text = "Agregar usuario";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // DTFecha
            // 
            DTFecha.Location = new Point(831, 170);
            DTFecha.Name = "DTFecha";
            DTFecha.Size = new Size(228, 23);
            DTFecha.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 64, 0);
            panel5.Controls.Add(LUsuarios);
            panel5.Location = new Point(45, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(1213, 86);
            panel5.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Controls.Add(DTFecha);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(dgvUsuarios);
            panel1.Controls.Add(LFecha);
            panel1.Controls.Add(TDireccion);
            panel1.Controls.Add(Direccion);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(TContraseña);
            panel1.Controls.Add(LContraseña);
            panel1.Controls.Add(TCorreo);
            panel1.Controls.Add(LCorreo);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(LDNI);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(45, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 721);
            panel1.TabIndex = 23;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1437, 1036);
            Controls.Add(panel1);
            Controls.Add(panel5);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Usuarios";
            Text = "Form2";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LUsuarios;
        private Label LNombre;
        private TextBox TNombre;
        private TextBox TApellido;
        private Label LApellido;
        private TextBox TDni;
        private Label LDNI;
        private TextBox TCorreo;
        private Label LCorreo;
        private TextBox TContraseña;
        private Label LContraseña;
        private TextBox TTelefono;
        private Label LTelefono;
        private TextBox TDireccion;
        private Label Direccion;
        private Label LFecha;
        private DataGridView dgvUsuarios;
        private Button BAgregar;
        private DateTimePicker DTFecha;
        private Panel panel5;
        private Panel panel1;
    }
}