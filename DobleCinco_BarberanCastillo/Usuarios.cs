using DobleCinco_BarberanCastillo.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DobleCinco_BarberanCastillo
{

    public partial class Usuarios : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
        int idSeleccionado = 0;
        private static Usuarios instancia = null;
        int estadoFiltro = 0;
        public static Usuarios VentanaUnica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Usuarios();
                return instancia;
            }
            return instancia;
        }
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            using var conn = new SqlConnection(connectionString);
            // Selecciona solo las columnas que quieres mostrar y les pones alias para los headers
            string query = @"SELECT 
                        u.id_usuario AS [ID], 
                        u.nombre_usuario AS [Nombre], 
                        u.apellido_usuario AS [Apellido], 
                        u.correo_usuario AS [Correo], 
                        u.telefono_usuario AS [Teléfono],
                        u.contraseña_usuario AS [Contraseña],
                        u.dni_usuario AS [DNI],
                        u.direccion_usuario AS [Dirección],
                        u.id_perfil AS [IdPerfil],           -- Agrega el ID del perfil
                        p.perfil_descripcion AS [Perfil],    -- Mantén la descripción para mostrar
                        u.id_estado AS [Estado]
                     FROM Usuario u
                     INNER JOIN perfil p ON u.id_perfil = p.id_perfil";

            /*var parametros = new List<SqlParameter>();
            var condiciones = new List<string>();

            // 1. Filtrar por Nombre (si se proporcionó)
            if (!string.IsNullOrWhiteSpace(TBNombreSearch.Text))
            {
                condiciones.Add("u.nombre_usuario LIKE @Nombre");
                parametros.Add(new SqlParameter("@Nombre", "%" + TBNombreSearch.Text + "%"));
            }

            // 2. Filtrar por DNI (si se proporcionó)
            if (!string.IsNullOrWhiteSpace(TBDniSearch.Text))
            {
                condiciones.Add("u.dni_usuario LIKE @Dni");
                parametros.Add(new SqlParameter("@Dni", "%" + TBDniSearch.Text + "%"));
            }

            // 3. Filtrar por Rol/Perfil (si se seleccionó uno válido)
            if (CBRolSearch.SelectedIndex > 0)
            {
                condiciones.Add("u.id_perfil = @IdPerfil");
                parametros.Add(new SqlParameter("@IdPerfil", CBRolSearch.SelectedIndex));
            }

            // 3. Filtrar por Estado (si se seleccionó uno válido)
            if (CBEstadoSearch.SelectedIndex > -1)
            {
                condiciones.Add("u.id_estado = @EstadoUsuario");
                parametros.Add(new SqlParameter("@EstadoUsuario", CBEstadoSearch.SelectedIndex));
            }

            // Si hay alguna condición, se agrega el WHERE a la consulta
            if (condiciones.Any())
            {
                query += " WHERE " + string.Join(" AND ", condiciones);
            }
            */
            var da = new SqlDataAdapter(query, conn);
            /*da.SelectCommand.Parameters.AddRange(parametros.ToArray());
            */
            var dt = new DataTable();
            da.Fill(dt);
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.Refresh();

            // Oculta la columna id_estado
            if (dgvUsuarios.Columns.Contains("Estado"))
                dgvUsuarios.Columns["Estado"].Visible = false;

            if (dgvUsuarios.Columns.Contains("IdPerfil"))
                dgvUsuarios.Columns["IdPerfil"].Visible = false;
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            accionActual = "agregar";
            TNombre.Enabled = true;
            TApellido.Enabled = true;
            TCorreo.Enabled = true;
            TTelefono.Enabled = true;
            TContraseña.Enabled = true;
            TDni.Enabled = true;
            TDireccion.Enabled = true;
            cuPerfil2.Enabled = true;
            DTNacimiento.Enabled = true;

            BAgregar.Enabled = false;
            BEliminar.Enabled = false;
            BModificar.Enabled = false;
            BAceptar.Enabled = true;
            BCancelar.Enabled = true;
            CargarDatos();
        }

        private void AgregarUsuario()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                try
                {
                    // 1. Verificar si el DNI o el correo ya existen
                    string checkQuery = "SELECT COUNT(*) FROM Usuario WHERE dni_usuario = @Dni OR correo_usuario = @Correo";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Dni", TDni.Text);
                    checkCmd.Parameters.AddWithValue("@Correo", TCorreo.Text);

                    conn.Open();
                    int count = (int)checkCmd.ExecuteScalar();
                    conn.Close();

                    if (count > 0)
                    {
                        // Verificar cuál de los dos campos está duplicado
                        string checkDni = "SELECT COUNT(*) FROM Usuario WHERE dni_usuario = @Dni";
                        string checkCorreo = "SELECT COUNT(*) FROM Usuario WHERE correo_usuario = @Correo";
                        SqlCommand cmdDni = new SqlCommand(checkDni, conn);
                        SqlCommand cmdCorreo = new SqlCommand(checkCorreo, conn);
                        cmdDni.Parameters.AddWithValue("@Dni", TDni.Text);
                        cmdCorreo.Parameters.AddWithValue("@Correo", TCorreo.Text);

                        conn.Open();
                        int dniDuplicado = (int)cmdDni.ExecuteScalar();
                        int correoDuplicado = (int)cmdCorreo.ExecuteScalar();
                        conn.Close();

                        if (dniDuplicado > 0 && correoDuplicado > 0)
                        {
                            MessageBox.Show("El DNI y el correo ingresados ya están registrados. Por favor, ingresa datos diferentes.", "Datos duplicados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (dniDuplicado > 0)
                        {
                            MessageBox.Show("El DNI ingresado ya está registrado. Por favor, ingresa uno diferente.", "DNI duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("El correo ingresado ya está registrado. Por favor, ingresa uno diferente.", "Correo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        TDni.Clear();
                        TCorreo.Clear();
                        TDni.Focus();
                        return;
                    }
                    // Validar formato de correo electrónico
                    string correo = TCorreo.Text.Trim();

                    string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                    if (!Regex.IsMatch(correo, patronCorreo))
                    {
                        MessageBox.Show("Ingrese un correo electrónico válido (ejemplo: usuario@dominio.com)",
                                        "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TCorreo.Focus(); // Vuelve a enfocar el campo
                    }
                    else
                    {
                        // 2. Insertar el usuario si no hay duplicados
                        string query = "INSERT INTO Usuario (nombre_usuario, apellido_usuario, correo_usuario, telefono_usuario, dni_usuario, contraseña_usuario, direccion_usuario, id_perfil, id_estado, fecha_nacimiento_usuario) VALUES (@Nombre, @Apellido, @Correo, @Telefono, @Dni, @Contraseña, @Direccion, @Perfil, 1, @Fecha)";
                        SqlCommand cmdInsert = new SqlCommand(query, conn);
                        cmdInsert.Parameters.AddWithValue("@Nombre", TNombre.Text);
                        cmdInsert.Parameters.AddWithValue("@Apellido", TApellido.Text);
                        cmdInsert.Parameters.AddWithValue("@Correo", TCorreo.Text);
                        cmdInsert.Parameters.AddWithValue("@Telefono", TTelefono.Text);
                        cmdInsert.Parameters.AddWithValue("@Dni", TDni.Text);
                        cmdInsert.Parameters.AddWithValue("@Contraseña", TContraseña.Text);
                        cmdInsert.Parameters.AddWithValue("@Direccion", TDireccion.Text);
                        cmdInsert.Parameters.AddWithValue("@Fecha", DTNacimiento.Value);
                        cmdInsert.Parameters.AddWithValue("@Perfil", cuPerfil2.IdSeleccionado.ToString());
                        conn.Open();
                        cmdInsert.ExecuteNonQuery();
                        conn.Close();
                        LimpiarCampos();
                        accionActual = "";
                        TNombre.Enabled = false;
                        TApellido.Enabled = false;
                        TCorreo.Enabled = false;
                        TTelefono.Enabled = false;
                        TContraseña.Enabled = false;
                        TDni.Enabled = false;
                        TDireccion.Enabled = false;
                        cuPerfil2.Enabled = false;
                        DTNacimiento.Enabled = false;

                        BAgregar.Enabled = true;
                        BEliminar.Enabled = true;
                        BModificar.Enabled = true;
                        BAceptar.Enabled = true;
                        BCancelar.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCampos();
                }
            }
        }

        private void ModificarUsuario()
        {
            string correo = TCorreo.Text.Trim();

            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";


            if (!Regex.IsMatch(correo, patronCorreo))
            {
                MessageBox.Show("Ingrese un correo electrónico válido (ejemplo: usuario@dominio.com)",
                                "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TCorreo.Focus(); // Vuelve a enfocar el campo
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {

                        string checkQuery = "SELECT COUNT(*) FROM Usuario WHERE (dni_usuario = @Dni OR correo_usuario = @Correo) AND id_usuario != @IdUsuario";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                        checkCmd.Parameters.AddWithValue("@Dni", TDni.Text);
                        checkCmd.Parameters.AddWithValue("@Correo", TCorreo.Text);
                        checkCmd.Parameters.AddWithValue("@IdUsuario", idSeleccionado); // Aquí se pasa el ID

                        conn.Open();
                        int count = (int)checkCmd.ExecuteScalar();
                        conn.Close();

                        if (count > 0)
                        {
                            // Verificar cuál de los dos campos está duplicado
                            string checkDni = "SELECT COUNT(*) FROM Usuario WHERE dni_usuario = @Dni AND id_usuario != @IdUsuario";
                            string checkCorreo = "SELECT COUNT(*) FROM Usuario WHERE correo_usuario = @Correo AND id_usuario != @IdUsuario";
                            SqlCommand cmdDni = new SqlCommand(checkDni, conn);
                            SqlCommand cmdCorreo = new SqlCommand(checkCorreo, conn);
                            cmdDni.Parameters.AddWithValue("@Dni", TDni.Text);
                            cmdCorreo.Parameters.AddWithValue("@Correo", TCorreo.Text);
                            cmdDni.Parameters.AddWithValue("@IdUsuario", idSeleccionado);
                            cmdCorreo.Parameters.AddWithValue("@IdUsuario", idSeleccionado);

                            conn.Open();
                            int dniDuplicado = (int)cmdDni.ExecuteScalar();
                            int correoDuplicado = (int)cmdCorreo.ExecuteScalar();
                            conn.Close();

                            if (dniDuplicado > 0 && correoDuplicado > 0)
                            {
                                MessageBox.Show("El DNI y el correo ingresados ya están registrados. Por favor, ingresa datos diferentes.", "Datos duplicados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TDni.Clear();
                                TCorreo.Clear();
                                TDni.Focus();
                            }
                            else if (dniDuplicado > 0)
                            {
                                MessageBox.Show("El DNI ingresado ya está registrado. Por favor, ingresa uno diferente.", "DNI duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TDni.Clear();
                                TDni.Focus();
                            }
                            else
                            {
                                MessageBox.Show("El correo ingresado ya está registrado. Por favor, ingresa uno diferente.", "Correo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                TCorreo.Clear();
                                TCorreo.Focus();
                            }
                            return;
                        }

                        string query = "UPDATE Usuario SET nombre_usuario=@Nombre, apellido_usuario=@Apellido, correo_usuario=@Correo, telefono_usuario=@Telefono, dni_usuario=@Dni,contraseña_usuario=@Contraseña, direccion_usuario=@Direccion, fecha_nacimiento_usuario=@Fecha, id_perfil=@Perfil WHERE id_usuario=@Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Nombre", TNombre.Text);
                        cmd.Parameters.AddWithValue("@Apellido", TApellido.Text);
                        cmd.Parameters.AddWithValue("@Correo", TCorreo.Text);
                        cmd.Parameters.AddWithValue("@Telefono", TTelefono.Text);
                        cmd.Parameters.AddWithValue("@Dni", TDni.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", TContraseña.Text);
                        cmd.Parameters.AddWithValue("@Direccion", TDireccion.Text);
                        cmd.Parameters.AddWithValue("@Fecha", DTNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Perfil", cuPerfil2.IdSeleccionado);
                        cmd.Parameters.AddWithValue("@Id", idSeleccionado);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        LimpiarCampos();
                        accionActual = "";
                        TNombre.Enabled = false;
                        TApellido.Enabled = false;
                        TCorreo.Enabled = false;
                        TTelefono.Enabled = false;
                        TContraseña.Enabled = false;
                        TDni.Enabled = false;
                        TDireccion.Enabled = false;
                        cuPerfil2.Enabled = false;
                        DTNacimiento.Enabled = false;

                        BAgregar.Enabled = true;
                        BEliminar.Enabled = true;
                        BModificar.Enabled = true;
                        BAceptar.Enabled = true;
                        BCancelar.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                LimpiarCampos();
            }
        }

        private void EliminarUsuario()
        {
            int estadoUsuario = -1;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT id_estado FROM Usuario WHERE id_usuario=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idSeleccionado);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int estado))
                {
                    estadoUsuario = estado;
                }
                conn.Close();

            }

            int nuevoEstado = (estadoUsuario == 1) ? 0 : 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuario SET id_estado=@NuevoEstado WHERE id_usuario=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                cmd.Parameters.AddWithValue("@Id", idSeleccionado);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LimpiarCampos();
                accionActual = "";
                TNombre.Enabled = false;
                TApellido.Enabled = false;
                TCorreo.Enabled = false;
                TTelefono.Enabled = false;
                TContraseña.Enabled = false;
                TDni.Enabled = false;
                TDireccion.Enabled = false;
                cuPerfil2.Enabled = false;
                DTNacimiento.Enabled = false;

                BAgregar.Enabled = true;
                BEliminar.Enabled = true;
                BModificar.Enabled = true;
                BAceptar.Enabled = true;
                BCancelar.Enabled = true;
            }
        }


        private void BModificar_Click(object sender, EventArgs e)
        {

            if (idSeleccionado == null || idSeleccionado == 0)
            {
                MessageBox.Show("El control de perfil no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            accionActual = "modificar";

            TNombre.Enabled = true;
            TApellido.Enabled = true;
            TCorreo.Enabled = true;
            TTelefono.Enabled = true;
            TContraseña.Enabled = true;
            TDni.Enabled = true;
            TDireccion.Enabled = true;
            cuPerfil2.Enabled = true;
            DTNacimiento.Enabled = true;

            BAgregar.Enabled = false;
            BEliminar.Enabled = false;
            BModificar.Enabled = false;
            BAceptar.Enabled = true;
            BCancelar.Enabled = true;

            // Validar formato de correo electrónico

            CargarDatos();
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            accionActual = "eliminar";



            CargarDatos();
        }


        private void LimpiarCampos()
        {
            TNombre.Clear();
            TApellido.Clear();
            TCorreo.Clear();
            TTelefono.Clear();
            TDni.Clear();
            TContraseña.Clear();
            TDireccion.Clear();
            idSeleccionado = 0;
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_' && e.KeyChar != '-')
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuPerfil2_Load(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
                TNombre.Text = fila.Cells["Nombre"].Value.ToString();
                TApellido.Text = fila.Cells["Apellido"].Value.ToString();
                TCorreo.Text = fila.Cells["Correo"].Value.ToString();
                TTelefono.Text = fila.Cells["Teléfono"].Value.ToString();
                TContraseña.Text = fila.Cells["Contraseña"].Value.ToString();
                TDni.Text = fila.Cells["DNI"].Value.ToString();
                TDireccion.Text = fila.Cells["Dirección"].Value.ToString();
                cuPerfil2.IdSeleccionado = Convert.ToInt32(fila.Cells["IdPerfil"].Value);
                // DTNacimiento no se está cargando porque no está en el DataGridView

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            switch (accionActual)
            {
                case "agregar":
                    AgregarUsuario();
                    break;
                case "modificar":
                    ModificarUsuario();
                    break;
                case "eliminar":
                    EliminarUsuario();
                    break;
                default:
                    MessageBox.Show("No se ha seleccionado ninguna acción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            CargarDatos();

        }
        private string accionActual = ""; // "agregar", "modificar", "eliminar"

        private void BCancelar_Click(object sender, EventArgs e)
        {
            TNombre.Enabled = false;
            TApellido.Enabled = false;
            TCorreo.Enabled = false;
            TTelefono.Enabled = false;
            TContraseña.Enabled = false;
            TDni.Enabled = false;
            TDireccion.Enabled = false;
            cuPerfil2.Enabled = false;
            DTNacimiento.Enabled = false;

            BAgregar.Enabled = true;
            BEliminar.Enabled = true;
            BModificar.Enabled = true;
            BAceptar.Enabled = true;
            BCancelar.Enabled = true;
            LimpiarCampos();
            accionActual = "";
        }

        //FILTROS
        /*private void BBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreFiltro = TBNombreSearch.Text.Trim();
                string dniFiltro = TBDniSearch.Text.Trim();
                int perfilFiltro = Convert.ToInt32(CBRolSearch.SelectedValue);
                int estadoFiltro = CBEstadoSearch.SelectedIndex; // 0: Todos, 1: Activo, 2: Inactivo

                // Llamar a CargarDatos con los filtros
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
        private void BBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreFiltro = TBNombreSearch.Text.Trim();
                string dniFiltro = TBDniSearch.Text.Trim();
                int perfilFiltro = CBRolSearch.SelectedIndex; // Asume que 0 es "Todos"
                int estadoFiltro = CBEstadoSearch.SelectedIndex; // 0: Todos, 1: Activo, 2: Inactivo

                string query = @"SELECT 
                u.id_usuario AS [ID], 
                u.nombre_usuario AS [Nombre], 
                u.apellido_usuario AS [Apellido], 
                u.correo_usuario AS [Correo], 
                u.telefono_usuario AS [Teléfono],
                u.contraseña_usuario AS [Contraseña],
                u.dni_usuario AS [DNI],
                u.direccion_usuario AS [Dirección],
                u.id_perfil AS [IdPerfil],
                p.perfil_descripcion AS [Perfil],
                u.id_estado AS [Estado]
                FROM Usuario u
                INNER JOIN perfil p ON u.id_perfil = p.id_perfil";

                List<string> condiciones = new();
                SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrEmpty(nombreFiltro))
                {
                    condiciones.Add("u.nombre_usuario LIKE @Nombre");
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombreFiltro + "%");
                }
                if (!string.IsNullOrEmpty(dniFiltro))
                {
                    condiciones.Add("u.dni_usuario LIKE @Dni");
                    cmd.Parameters.AddWithValue("@Dni", "%" + dniFiltro + "%");
                }
                if (perfilFiltro > 0) // 0 es "Todos"
                {
                    condiciones.Add("u.id_perfil = @Perfil");
                    cmd.Parameters.AddWithValue("@Perfil", perfilFiltro);
                }
                if (estadoFiltro > 0) // 0 es "Todos", 1: Activo, 2: Inactivo
                {
                    condiciones.Add("u.id_estado = @Estado");
                    cmd.Parameters.AddWithValue("@Estado", estadoFiltro == 1 ? 1 : 0);
                }

                if (condiciones.Count > 0)
                    query += " WHERE " + string.Join(" AND ", condiciones);

                cmd.CommandText = query;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    cmd.Connection = conn;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsuarios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dgvUsuarios.Columns.Contains("Estado"))
                dgvUsuarios.Columns["Estado"].Visible = false;
        }

        // Evento para el botón "Limpiar Filtros"
        private void BLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los controles de búsqueda
            TBNombreSearch.Clear();
            TBDniSearch.Clear();
            CBRolSearch.SelectedIndex = 0; // Vuelve a "[Todos los roles]"
            CBEstadoSearch.SelectedIndex = -1; // Vuelve a "[Todos los estados]"

            // Recargar la grilla con todos los datos
            CargarDatos();
            LimpiarCampos(); // Llama a tu método para limpiar los campos de datos inferiores
        }

        private void TBDniSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUsuarios_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dgv = dgvUsuarios;
            if (dgv.Rows[e.RowIndex].Cells["Estado"].Value != null)
            {
                if (int.TryParse(dgv.Rows[e.RowIndex].Cells["Estado"].Value.ToString(), out int estado) && estado == 0)
                {
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkRed;
                    dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        }
    }
