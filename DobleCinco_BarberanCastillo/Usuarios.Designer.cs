﻿namespace DobleCinco_BarberanCastillo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // LUsuarios
            // 
            LUsuarios.AutoSize = true;
            LUsuarios.Font = new Font("Segoe UI", 25F);
            LUsuarios.ForeColor = SystemColors.ControlLightLight;
            LUsuarios.Location = new Point(64, 43);
            LUsuarios.Name = "LUsuarios";
            LUsuarios.Size = new Size(147, 46);
            LUsuarios.TabIndex = 0;
            LUsuarios.Text = "Usuarios";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 15F);
            LNombre.Location = new Point(268, 163);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(85, 28);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(415, 168);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(228, 23);
            TNombre.TabIndex = 2;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(415, 235);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(228, 23);
            TApellido.TabIndex = 4;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 15F);
            LApellido.Location = new Point(268, 230);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(86, 28);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // TDni
            // 
            TDni.Location = new Point(415, 301);
            TDni.Name = "TDni";
            TDni.Size = new Size(228, 23);
            TDni.TabIndex = 6;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Font = new Font("Segoe UI", 15F);
            LDNI.Location = new Point(268, 296);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(46, 28);
            LDNI.TabIndex = 5;
            LDNI.Text = "DNI";
            // 
            // TCorreo
            // 
            TCorreo.Location = new Point(415, 366);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(228, 23);
            TCorreo.TabIndex = 8;
            TCorreo.KeyPress += TCorreo_KeyPress;
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Segoe UI", 15F);
            LCorreo.Location = new Point(268, 361);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(72, 28);
            LCorreo.TabIndex = 7;
            LCorreo.Text = "Correo";
            // 
            // TContraseña
            // 
            TContraseña.Location = new Point(1087, 171);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(228, 23);
            TContraseña.TabIndex = 10;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Font = new Font("Segoe UI", 15F);
            LContraseña.Location = new Point(838, 163);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(110, 28);
            LContraseña.TabIndex = 9;
            LContraseña.Text = "Contraseña";
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(1087, 235);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(228, 23);
            TTelefono.TabIndex = 12;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Segoe UI", 15F);
            LTelefono.Location = new Point(838, 230);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(86, 28);
            LTelefono.TabIndex = 11;
            LTelefono.Text = "Telefono";
            // 
            // TDireccion
            // 
            TDireccion.Location = new Point(1087, 304);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(228, 23);
            TDireccion.TabIndex = 14;
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Font = new Font("Segoe UI", 15F);
            Direccion.Location = new Point(838, 293);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(94, 28);
            Direccion.TabIndex = 13;
            Direccion.Text = "Direccion";
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.Font = new Font("Segoe UI", 15F);
            LFecha.Location = new Point(838, 361);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(191, 28);
            LFecha.TabIndex = 15;
            LFecha.Text = "Fecha de nacimiento";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.Location = new Point(353, 616);
            dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.Size = new Size(798, 366);
            dgvUsuarios.TabIndex = 19;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // BAgregar
            // 
            BAgregar.ForeColor = SystemColors.ActiveCaptionText;
            BAgregar.Location = new Point(647, 490);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(157, 43);
            BAgregar.TabIndex = 20;
            BAgregar.Text = "Agregar";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // DTFecha
            // 
            DTFecha.Location = new Point(1087, 366);
            DTFecha.Name = "DTFecha";
            DTFecha.Size = new Size(228, 23);
            DTFecha.TabIndex = 21;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1437, 1036);
            Controls.Add(DTFecha);
            Controls.Add(BAgregar);
            Controls.Add(dgvUsuarios);
            Controls.Add(LFecha);
            Controls.Add(TDireccion);
            Controls.Add(Direccion);
            Controls.Add(TTelefono);
            Controls.Add(LTelefono);
            Controls.Add(TContraseña);
            Controls.Add(LContraseña);
            Controls.Add(TCorreo);
            Controls.Add(LCorreo);
            Controls.Add(TDni);
            Controls.Add(LDNI);
            Controls.Add(TApellido);
            Controls.Add(LApellido);
            Controls.Add(TNombre);
            Controls.Add(LNombre);
            Controls.Add(LUsuarios);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Usuarios";
            Text = "Form2";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}