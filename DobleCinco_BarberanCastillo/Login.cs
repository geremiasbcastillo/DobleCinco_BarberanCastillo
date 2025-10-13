using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace DobleCinco_BarberanCastillo
{
    public partial class Login : Form
    {
        // string connectionString = "Server=localhost\\SQLEXPRESS;Database=doble_cinco;integrated security = true;";



        // Accessing an appSetting


        // Accessing a connection string
        string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;

        SqlCommand cmd;
        SqlDataReader dr;

        int idSeleccionado = 0;


        public Login()
        {
            InitializeComponent();
        }

        private void BInicio_Click(object sender, EventArgs e)
        {
            string dni = TBDni.Text, contraseña = TBContraseña.Text;
            IniciarSesion(dni, contraseña);
        }

        private void IniciarSesion(string pDni, string pContraseña)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE dni_usuario = @Dni AND contraseña_usuario = @Contraseña AND id_estado=1";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Dni", pDni);
                cmd.Parameters.AddWithValue("@Contraseña", pContraseña);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int idPerfil = Convert.ToInt32(dr["id_perfil"]); // Asegúrate de que la consulta traiga este campo
                    FormMDI mainForm = new FormMDI(idPerfil);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    // Credenciales incorrectas, mostrar mensaje de error
                    MessageBox.Show("DNI o contraseña incorrectos. Inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBContraseña.Clear();
                    TBDni.Clear();
                    TBDni.Focus();
                }
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento, evitando que el carácter se ingrese
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit(); // Esto fuerza el cierre de toda la aplicación
        }
    }
}
