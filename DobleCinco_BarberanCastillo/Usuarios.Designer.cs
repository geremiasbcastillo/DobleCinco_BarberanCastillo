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
            dgvUsuarios = new DataGridView();
            panel5 = new Panel();
            panel1 = new Panel();
            CBEstadoSearch = new ComboBox();
            LEstado = new Label();
            BCancelar = new Button();
            BAceptar = new Button();
            DTNacimiento = new DateTimePicker();
            LFechaNac = new Label();
            cuPerfil2 = new DobleCinco_BarberanCastillo.Controles.CUPerfil();
            LCategoria = new Label();
            BEliminar = new Button();
            BModificar = new Button();
            BAgregar = new Button();
            TDireccion = new TextBox();
            Direccion = new Label();
            TTelefono = new TextBox();
            LTelefono = new Label();
            TContraseña = new TextBox();
            LContraseña = new Label();
            TCorreo = new TextBox();
            LCorreo = new Label();
            TDni = new TextBox();
            LDNI = new Label();
            TApellido = new TextBox();
            LApellido = new Label();
            TNombre = new TextBox();
            LNombre = new Label();
            BLimpiar = new Button();
            BBuscar = new Button();
            CBRolSearch = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            TBDniSearch = new TextBox();
            label1 = new Label();
            TBNombreSearch = new TextBox();
            LBusqueda = new Label();
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
            dgvUsuarios.Location = new Point(39, 162);
            dgvUsuarios.Name = "dgvUsuarios";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlLightLight;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1156, 366);
            dgvUsuarios.TabIndex = 19;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            dgvUsuarios.RowPrePaint += dgvUsuarios_RowPrePaint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 64, 0);
            panel5.Controls.Add(LUsuarios);
            panel5.Location = new Point(45, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(1267, 86);
            panel5.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Controls.Add(CBEstadoSearch);
            panel1.Controls.Add(LEstado);
            panel1.Controls.Add(BCancelar);
            panel1.Controls.Add(BAceptar);
            panel1.Controls.Add(DTNacimiento);
            panel1.Controls.Add(LFechaNac);
            panel1.Controls.Add(cuPerfil2);
            panel1.Controls.Add(LCategoria);
            panel1.Controls.Add(BEliminar);
            panel1.Controls.Add(BModificar);
            panel1.Controls.Add(BAgregar);
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
            panel1.Controls.Add(BLimpiar);
            panel1.Controls.Add(BBuscar);
            panel1.Controls.Add(CBRolSearch);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TBDniSearch);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TBNombreSearch);
            panel1.Controls.Add(LBusqueda);
            panel1.Controls.Add(dgvUsuarios);
            panel1.Location = new Point(45, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(1267, 926);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // CBEstadoSearch
            // 
            CBEstadoSearch.FormattingEnabled = true;
            CBEstadoSearch.Items.AddRange(new object[] { "Inactivo", "Activo" });
            CBEstadoSearch.Location = new Point(987, 35);
            CBEstadoSearch.Name = "CBEstadoSearch";
            CBEstadoSearch.Size = new Size(135, 23);
            CBEstadoSearch.TabIndex = 62;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Font = new Font("Segoe UI", 15F);
            LEstado.Location = new Point(910, 31);
            LEstado.Name = "LEstado";
            LEstado.Size = new Size(71, 28);
            LEstado.TabIndex = 61;
            LEstado.Text = "Estado";
            // 
            // BCancelar
            // 
            BCancelar.Font = new Font("Segoe UI", 12F);
            BCancelar.ForeColor = SystemColors.ActiveCaptionText;
            BCancelar.Location = new Point(687, 823);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(171, 47);
            BCancelar.TabIndex = 60;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = true;
            BCancelar.Click += BCancelar_Click;
            // 
            // BAceptar
            // 
            BAceptar.Font = new Font("Segoe UI", 12F);
            BAceptar.ForeColor = SystemColors.ActiveCaptionText;
            BAceptar.Location = new Point(339, 823);
            BAceptar.Name = "BAceptar";
            BAceptar.Size = new Size(171, 47);
            BAceptar.TabIndex = 59;
            BAceptar.Text = "Aceptar";
            BAceptar.UseVisualStyleBackColor = true;
            BAceptar.Click += BAceptar_Click;
            // 
            // DTNacimiento
            // 
            DTNacimiento.Enabled = false;
            DTNacimiento.Format = DateTimePickerFormat.Short;
            DTNacimiento.Location = new Point(770, 754);
            DTNacimiento.Name = "DTNacimiento";
            DTNacimiento.Size = new Size(228, 23);
            DTNacimiento.TabIndex = 58;
            // 
            // LFechaNac
            // 
            LFechaNac.AutoSize = true;
            LFechaNac.Font = new Font("Segoe UI", 15F);
            LFechaNac.Location = new Point(564, 749);
            LFechaNac.Name = "LFechaNac";
            LFechaNac.Size = new Size(168, 28);
            LFechaNac.TabIndex = 57;
            LFechaNac.Text = "Fecha Nacimiento";
            // 
            // cuPerfil2
            // 
            cuPerfil2.BackColor = Color.Transparent;
            cuPerfil2.Enabled = false;
            cuPerfil2.Location = new Point(770, 700);
            cuPerfil2.Name = "cuPerfil2";
            cuPerfil2.Size = new Size(228, 28);
            cuPerfil2.TabIndex = 56;
            // 
            // LCategoria
            // 
            LCategoria.AutoSize = true;
            LCategoria.Font = new Font("Segoe UI", 15F);
            LCategoria.Location = new Point(564, 697);
            LCategoria.Name = "LCategoria";
            LCategoria.Size = new Size(97, 28);
            LCategoria.TabIndex = 55;
            LCategoria.Text = "Categoria";
            // 
            // BEliminar
            // 
            BEliminar.Font = new Font("Segoe UI", 10F);
            BEliminar.ForeColor = SystemColors.ActiveCaptionText;
            BEliminar.Location = new Point(1039, 650);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(171, 43);
            BEliminar.TabIndex = 54;
            BEliminar.Text = "Dar de baja / Dar de alta";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BModificar
            // 
            BModificar.Font = new Font("Segoe UI", 12F);
            BModificar.ForeColor = SystemColors.ActiveCaptionText;
            BModificar.Location = new Point(1039, 555);
            BModificar.Name = "BModificar";
            BModificar.Size = new Size(171, 43);
            BModificar.TabIndex = 53;
            BModificar.Text = "Modificar";
            BModificar.UseVisualStyleBackColor = true;
            BModificar.Click += BModificar_Click;
            // 
            // BAgregar
            // 
            BAgregar.Font = new Font("Segoe UI", 12F);
            BAgregar.ForeColor = SystemColors.ActiveCaptionText;
            BAgregar.Location = new Point(1039, 744);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(171, 43);
            BAgregar.TabIndex = 52;
            BAgregar.Text = "Agregar Usuario";
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // TDireccion
            // 
            TDireccion.Enabled = false;
            TDireccion.Location = new Point(770, 655);
            TDireccion.Name = "TDireccion";
            TDireccion.Size = new Size(228, 23);
            TDireccion.TabIndex = 51;
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.Font = new Font("Segoe UI", 15F);
            Direccion.Location = new Point(564, 650);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(94, 28);
            Direccion.TabIndex = 50;
            Direccion.Text = "Direccion";
            // 
            // TTelefono
            // 
            TTelefono.Enabled = false;
            TTelefono.Location = new Point(770, 605);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(228, 23);
            TTelefono.TabIndex = 49;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Font = new Font("Segoe UI", 15F);
            LTelefono.Location = new Point(564, 600);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(86, 28);
            LTelefono.TabIndex = 48;
            LTelefono.Text = "Telefono";
            // 
            // TContraseña
            // 
            TContraseña.Enabled = false;
            TContraseña.Location = new Point(770, 555);
            TContraseña.Name = "TContraseña";
            TContraseña.Size = new Size(228, 23);
            TContraseña.TabIndex = 47;
            // 
            // LContraseña
            // 
            LContraseña.AutoSize = true;
            LContraseña.Font = new Font("Segoe UI", 15F);
            LContraseña.Location = new Point(564, 550);
            LContraseña.Name = "LContraseña";
            LContraseña.Size = new Size(110, 28);
            LContraseña.TabIndex = 46;
            LContraseña.Text = "Contraseña";
            // 
            // TCorreo
            // 
            TCorreo.Enabled = false;
            TCorreo.Location = new Point(223, 705);
            TCorreo.Name = "TCorreo";
            TCorreo.Size = new Size(228, 23);
            TCorreo.TabIndex = 45;
            // 
            // LCorreo
            // 
            LCorreo.AutoSize = true;
            LCorreo.Font = new Font("Segoe UI", 15F);
            LCorreo.Location = new Point(39, 700);
            LCorreo.Name = "LCorreo";
            LCorreo.Size = new Size(72, 28);
            LCorreo.TabIndex = 44;
            LCorreo.Text = "Correo";
            // 
            // TDni
            // 
            TDni.Enabled = false;
            TDni.Location = new Point(223, 655);
            TDni.Name = "TDni";
            TDni.Size = new Size(228, 23);
            TDni.TabIndex = 43;
            // 
            // LDNI
            // 
            LDNI.AutoSize = true;
            LDNI.Font = new Font("Segoe UI", 15F);
            LDNI.Location = new Point(39, 650);
            LDNI.Name = "LDNI";
            LDNI.Size = new Size(46, 28);
            LDNI.TabIndex = 42;
            LDNI.Text = "DNI";
            // 
            // TApellido
            // 
            TApellido.Enabled = false;
            TApellido.Location = new Point(223, 605);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(228, 23);
            TApellido.TabIndex = 41;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Font = new Font("Segoe UI", 15F);
            LApellido.Location = new Point(39, 600);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(86, 28);
            LApellido.TabIndex = 40;
            LApellido.Text = "Apellido";
            // 
            // TNombre
            // 
            TNombre.Enabled = false;
            TNombre.Location = new Point(223, 555);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(228, 23);
            TNombre.TabIndex = 39;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Font = new Font("Segoe UI", 15F);
            LNombre.Location = new Point(39, 550);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(85, 28);
            LNombre.TabIndex = 38;
            LNombre.Text = "Nombre";
            // 
            // BLimpiar
            // 
            BLimpiar.Font = new Font("Segoe UI", 15F);
            BLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            BLimpiar.Location = new Point(321, 99);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(163, 40);
            BLimpiar.TabIndex = 37;
            BLimpiar.Text = "Limpiar filtros";
            BLimpiar.TextAlign = ContentAlignment.TopCenter;
            BLimpiar.UseVisualStyleBackColor = true;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // BBuscar
            // 
            BBuscar.Font = new Font("Segoe UI", 15F);
            BBuscar.ForeColor = SystemColors.ActiveCaptionText;
            BBuscar.Location = new Point(709, 99);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(131, 40);
            BBuscar.TabIndex = 36;
            BBuscar.Text = "Buscar";
            BBuscar.TextAlign = ContentAlignment.TopCenter;
            BBuscar.UseVisualStyleBackColor = true;
            BBuscar.Click += BBuscar_Click;
            // 
            // CBRolSearch
            // 
            CBRolSearch.FormattingEnabled = true;
            CBRolSearch.Items.AddRange(new object[] { "Gerente", "Administrador", "Vendedor" });
            CBRolSearch.Location = new Point(738, 35);
            CBRolSearch.Name = "CBRolSearch";
            CBRolSearch.Size = new Size(135, 23);
            CBRolSearch.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(692, 31);
            label3.Name = "label3";
            label3.Size = new Size(40, 28);
            label3.TabIndex = 34;
            label3.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(467, 31);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 32;
            label2.Text = "DNI";
            // 
            // TBDniSearch
            // 
            TBDniSearch.Location = new Point(519, 35);
            TBDniSearch.Name = "TBDniSearch";
            TBDniSearch.Size = new Size(139, 23);
            TBDniSearch.TabIndex = 31;
            TBDniSearch.Click += TBDniSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(178, 31);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 30;
            label1.Text = "Nombre";
            // 
            // TBNombreSearch
            // 
            TBNombreSearch.Location = new Point(269, 35);
            TBNombreSearch.Name = "TBNombreSearch";
            TBNombreSearch.Size = new Size(167, 23);
            TBNombreSearch.TabIndex = 29;
            // 
            // LBusqueda
            // 
            LBusqueda.AutoSize = true;
            LBusqueda.Font = new Font("Segoe UI", 15F);
            LBusqueda.Location = new Point(39, 30);
            LBusqueda.Name = "LBusqueda";
            LBusqueda.Size = new Size(108, 28);
            LBusqueda.TabIndex = 28;
            LBusqueda.Text = "Buscar por:";
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
        private Label LFecha;
        private DataGridView dgvUsuarios;
        private DateTimePicker DTFecha;
        private Panel panel5;
        private Panel panel1;
        private Controles.CUPerfil cuPerfil1;
        private Label LBusqueda;
        private TextBox TBNombreSearch;
        private Label label2;
        private TextBox TBDniSearch;
        private Label label1;
        private ComboBox CBRolSearch;
        private Label label3;
        private Button BBuscar;
        private Button BLimpiar;
        private DateTimePicker DTNacimiento;
        private Label LFechaNac;
        private Controles.CUPerfil cuPerfil2;
        private Label LCategoria;
        private Button BEliminar;
        private Button BModificar;
        private Button BAgregar;
        private TextBox TDireccion;
        private Label Direccion;
        private TextBox TTelefono;
        private Label LTelefono;
        private TextBox TContraseña;
        private Label LContraseña;
        private TextBox TCorreo;
        private Label LCorreo;
        private TextBox TDni;
        private Label LDNI;
        private TextBox TApellido;
        private Label LApellido;
        private TextBox TNombre;
        private Label LNombre;
        private Button BAceptar;
        private Button BCancelar;
        private ComboBox CBEstadoSearch;
        private Label LEstado;
    }
}