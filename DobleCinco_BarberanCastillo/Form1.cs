using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DobleCinco_BarberanCastillo
{
    public partial class Form1 : Form
    {
        string connectionString ="Server=localhost;Database=doble_cinco;Trusted_Connection=True;";
        int idSeleccionado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
