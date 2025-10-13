﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DobleCinco_BarberanCastillo.Controles
{
    public partial class CUPerfil : UserControl
    {
        public CUPerfil()
        {
            InitializeComponent();
        }

        public int IdSeleccionado;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdSeleccionado = int.Parse(CBPerfil.SelectedValue.ToString());
        }

        private void CUPerfil_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=doble_cinco;integrated security = true;");
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Perfil", sqlConnection);
            da.Fill(tb);
            CBPerfil.ValueMember = "id_perfil";
            CBPerfil.DisplayMember = "perfil_descripcion";
            CBPerfil.DataSource = tb;
        }
    }
}
