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
    public partial class CUFormaDePago : UserControl
    {
        public CUFormaDePago()
        {
            InitializeComponent();
        }

        public int IdSeleccionado;
        private void UserControl1_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            string connectionString = ConfigurationManager.ConnectionStrings["doble_cinco"].ConnectionString;
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM forma_de_pago", connectionString);
            da.Fill(tb);
            CBFormaDePago.ValueMember = "id_forma_de_pago";
            CBFormaDePago.DisplayMember = "forma_descripcion";
            CBFormaDePago.DataSource = tb;
        }

        private void CBFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdSeleccionado = int.Parse(CBFormaDePago.SelectedValue.ToString());
    }
    }
}
