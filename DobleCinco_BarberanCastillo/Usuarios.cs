using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleCinco_BarberanCastillo
{
    public partial class Usuarios : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS01;Database=doble_cinco;User Id=sa;Password=12345678;";
        int idSeleccionado = 0;
        private static Usuarios instancia = null;
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
                        u.id_perfil AS [Perfil],
                        e.estado_descripcion AS [Estado] 
                     FROM Usuario u
                     INNER JOIN Estado e ON u.id_estado = e.id_estado";
            var da = new SqlDataAdapter(query, conn);
            var dt = new DataTable();
            da.Fill(dt);
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.Refresh();
        }

        private void BAgregar_Click(object sender, EventArgs e)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CargarDatos();
            LimpiarCampos();
        }

        private void BModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null || idSeleccionado == 0)
            {
                MessageBox.Show("El control de perfil no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {


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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CargarDatos();
            LimpiarCampos();
        }
        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;

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
            }

            CargarDatos();
            LimpiarCampos();
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
                cuPerfil2.IdSeleccionado = Convert.ToInt32(fila.Cells["Perfil"].Value);
                // DTNacimiento no se está cargando porque no está en el DataGridView

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
