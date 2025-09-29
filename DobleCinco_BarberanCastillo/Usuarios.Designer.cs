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
            dgvUsuarios = new DataGridView();
            BAgregar = new Button();
            panel5 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            LBusqueda = new Label();
            DTNacimiento = new DateTimePicker();
            LFechaNac = new Label();
            cuPerfil2 = new DobleCinco_BarberanCastillo.Controles.CUPerfil();
            LCategoria = new Label();
            BEliminar = new Button();
            BModificar = new Button();
            BLimpiar = new Button();
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
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.Location = new Point(182, 485);
            dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLightLight;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(798, 366);
            dgvUsuarios.TabIndex = 19;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Segoe UI", 12F);
            BAgregar.ForeColor = SystemColors.ActiveCaptionText;
            BAgregar.Location = new Point(790, 266);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(171, 43);
            BAgregar.TabIndex = 20;
            BAgregar.Text = "Agregar Usuario";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
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
            panel1.Controls.Add(BLimpiar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(LBusqueda);
            panel1.Controls.Add(DTNacimiento);
            panel1.Controls.Add(LFechaNac);
            panel1.Controls.Add(cuPerfil2);
            panel1.Controls.Add(LCategoria);
            panel1.Controls.Add(BEliminar);
            panel1.Controls.Add(BModificar);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(dgvUsuarios);
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
            panel1.Size = new Size(1210, 926);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(682, 429);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 36;
            button1.Text = "Buscar";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gerente", "Administrador", "Vendedor" });
            comboBox1.Location = new Point(914, 366);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 23);
            comboBox1.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(868, 362);
            label3.Name = "label3";
            label3.Size = new Size(40, 28);
            label3.TabIndex = 34;
            label3.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(564, 362);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 32;
            label2.Text = "DNI";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(616, 366);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(203, 362);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 30;
            label1.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 366);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 29;
            // 
            // LBusqueda
            // 
            LBusqueda.AutoSize = true;
            LBusqueda.Font = new Font("Segoe UI", 15F);
            LBusqueda.Location = new Point(64, 361);
            LBusqueda.Name = "LBusqueda";
            LBusqueda.Size = new Size(108, 28);
            LBusqueda.TabIndex = 28;
            LBusqueda.Text = "Buscar por:";
            // 
            // DTNacimiento
            // 
            DTNacimiento.Format = DateTimePickerFormat.Short;
            DTNacimiento.Location = new Point(831, 219);
            DTNacimiento.Name = "DTNacimiento";
            DTNacimiento.Size = new Size(228, 23);
            DTNacimiento.TabIndex = 27;
            // 
            // LFechaNac
            // 
            LFechaNac.AutoSize = true;
            LFechaNac.Font = new Font("Segoe UI", 15F);
            LFechaNac.Location = new Point(625, 214);
            LFechaNac.Name = "LFechaNac";
            LFechaNac.Size = new Size(168, 28);
            LFechaNac.TabIndex = 26;
            LFechaNac.Text = "Fecha Nacimiento";
            // 
            // cuPerfil2
            // 
            cuPerfil2.BackColor = Color.Transparent;
            cuPerfil2.Location = new Point(831, 165);
            cuPerfil2.Name = "cuPerfil2";
            cuPerfil2.Size = new Size(228, 28);
            cuPerfil2.TabIndex = 25;
            cuPerfil2.Load += cuPerfil2_Load;
            // 
            // LCategoria
            // 
            LCategoria.AutoSize = true;
            LCategoria.Font = new Font("Segoe UI", 15F);
            LCategoria.Location = new Point(625, 162);
            LCategoria.Name = "LCategoria";
            LCategoria.Size = new Size(97, 28);
            LCategoria.TabIndex = 24;
            LCategoria.Text = "Categoria";
            // 
            // BEliminar
            // 
            BEliminar.Font = new Font("Segoe UI", 10F);
            BEliminar.ForeColor = SystemColors.ActiveCaptionText;
            BEliminar.Location = new Point(540, 266);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(169, 43);
            BEliminar.TabIndex = 23;
            BEliminar.Text = "Dar de baja / Dar de alta";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BModificar
            // 
            BModificar.Font = new Font("Segoe UI", 12F);
            BModificar.ForeColor = SystemColors.ActiveCaptionText;
            BModificar.Location = new Point(290, 265);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(157, 43);
            BModificar.TabIndex = 22;
            BModificar.Text = "Modificar";
            BModificar.UseVisualStyleBackColor = true;
            BModificar.Click += BModificar_Click;
            // 
            // BLimpiar
            // 
            BLimpiar.Font = new Font("Segoe UI", 15F);
            BLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            BLimpiar.Location = new Point(294, 429);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(163, 40);
            BLimpiar.TabIndex = 37;
            BLimpiar.Text = "Limpiar filtros";
            BLimpiar.TextAlign = ContentAlignment.TopCenter;
            BLimpiar.UseVisualStyleBackColor = true;
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
            Text = "Usuarios";
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
        private Button BEliminar;
        private Button BModificar;
        private Label LCategoria;
        private Controles.CUPerfil cuPerfil2;
        private Controles.CUPerfil cuPerfil1;
        private DateTimePicker DTNacimiento;
        private Label LFechaNac;
        private Label LBusqueda;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private Button BLimpiar;
    }
}