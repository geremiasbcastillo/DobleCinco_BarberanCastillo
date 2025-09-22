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
        string connectionString = "Server=localhost;Database=doble_cinco;Trusted_Connection=True;";
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
                        id_usuario AS [ID], 
                        nombre_usuario AS [Nombre], 
                        apellido_usuario AS [Apellido], 
                        correo_usuario AS [Correo], 
                        telefono_usuario AS [Teléfono],
                        dni_usuario AS [DNI],
                        direccion_usuario AS [Dirección],
                        id_perfil AS [Perfil],
                        id_estado AS [Estado] 
                     FROM Usuario";
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
                    string query = "INSERT INTO Usuario (nombre_usuario, apellido_usuario, correo_usuario, telefono_usuario, dni_usuario, contraseña_usuario, direccion_usuario, id_perfil, id_estado) VALUES (@Nombre, @Apellido, @Correo, @Telefono, @Dni, @Contraseña, @Direccion, @Perfil, 1)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", TNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", TApellido.Text);
                    cmd.Parameters.AddWithValue("@Correo", TCorreo.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TTelefono.Text);
                    cmd.Parameters.AddWithValue("@Dni", TDni.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", TContraseña.Text);
                    cmd.Parameters.AddWithValue("@Direccion", TDireccion.Text);
                    cmd.Parameters.AddWithValue("@Fecha", DTFecha.Value);
                    cmd.Parameters.AddWithValue("@Perfil", cuPerfil1.IdSeleccionado.ToString());
                    conn.Open();
                    cmd.ExecuteNonQuery();
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
            if (idSeleccionado == 0) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuarios SET nombre_usuario=@Nombre, apellido_usuario=@Apellido, correo_usuario=@Correo, telefono_usuario=@Telefono, dni_usuario=@Dni,contraseña_usuario=@Contraseña, direccion_usuario=@DireccionWHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", TNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", TApellido.Text);
                cmd.Parameters.AddWithValue("@Correo", TCorreo.Text);
                cmd.Parameters.AddWithValue("@Telefono", TTelefono.Text);
                cmd.Parameters.AddWithValue("@Dni", TDni.Text);
                cmd.Parameters.AddWithValue("@Contraseña", TContraseña.Text);
                cmd.Parameters.AddWithValue("@Direccion", TDireccion.Text);
                cmd.Parameters.AddWithValue("@Fecha", DTFecha.Value);
                cmd.Parameters.AddWithValue("@Perfil", cuPerfil1.IdSeleccionado);
                cmd.Parameters.AddWithValue("@Id", idSeleccionado);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarDatos();
            LimpiarCampos();
        }
        private void BEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Usuarios WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", idSeleccionado);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            CargarDatos();
            LimpiarCampos();
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
                TDni.Text = fila.Cells["DNI"].Value.ToString();
                TContraseña.Text = fila.Cells["Contraseña"].Value.ToString();
                TDireccion.Text = fila.Cells["Dirección"].Value.ToString();
                cuPerfil1.IdSeleccionado = Convert.ToInt32(fila.Cells["Perfil"].Value);

            }
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

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        
    }
}
