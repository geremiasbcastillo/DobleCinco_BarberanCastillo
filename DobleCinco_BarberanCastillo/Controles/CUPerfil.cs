using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Perfil", connectionString);
            da.Fill(tb);
            CBPerfil.ValueMember = "id_perfil";
            CBPerfil.DisplayMember = "perfil_descripcion";
            CBPerfil.DataSource = tb;
        }
    }
}
