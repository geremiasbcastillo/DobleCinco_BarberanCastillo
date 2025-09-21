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
            using var conn = new SqlConnection(connectionString); // Simplifica 'using' y 'new'
            string query = "SELECT * FROM Usuario";
            var da = new SqlDataAdapter(query, conn); // Simplifica 'new'
            var dt = new DataTable(); // Simplifica 'new'
            da.Fill(dt);
            dgvUsuarios.DataSource = dt;


        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuario (nombre_usuario, apellido_usuario, correo_usuario, telefono_usuario, dni_usuario, contraseña_usuario, direccion_usuario, id_perfil, id_estado, fecha_nacimiento_usuario) VALUES (@Nombre, @Apellido, @Correo, @Telefono, @Dni, @Contraseña, @Direccion, 1, 1, @Fecha)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", TNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", TApellido.Text);
                cmd.Parameters.AddWithValue("@Correo", TCorreo.Text);
                cmd.Parameters.AddWithValue("@Telefono", TTelefono.Text);
                cmd.Parameters.AddWithValue("@Dni", TDni.Text);
                cmd.Parameters.AddWithValue("@Contraseña", TContraseña.Text);
                cmd.Parameters.AddWithValue("@Direccion", TDireccion.Text);
                cmd.Parameters.AddWithValue("@Fecha", DTFecha.Value);

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
    }
}
