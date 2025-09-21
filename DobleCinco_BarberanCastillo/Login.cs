﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleCinco_BarberanCastillo
{
    public partial class Login : Form
    {
        string connectionString = "Server=localhost;Database=doble_cinco;Trusted_Connection=True;";
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

        private void IniciarSesion(string dni, string contraseña)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE dni_usuario = @Dni AND contraseña_usuario = @Contraseña";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Dni", dni);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // Credenciales correctas, abrir el formulario principal
                    FormMDI mainForm = new FormMDI();
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
    }
}
