using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DobleCinco_BarberanCastillo
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReporteVenta rv = new ReporteVenta();
            rv.MdiParent = this.MdiParent;
            rv.StartPosition = FormStartPosition.Manual;
            rv.Location = new Point(0, 0);
            rv.Show();

        }

        private void BProductos_Click(object sender, EventArgs e)
        {
            ReporteProducto rp = new ReporteProducto();
            rp.MdiParent = this.MdiParent;
            rp.StartPosition = FormStartPosition.Manual;
            rp.Location = new Point(0, 0);
            rp.Show();
        }

        private void BVendedores_Click(object sender, EventArgs e)
        {

        }
    }
}
