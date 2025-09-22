using Microsoft.VisualBasic.ApplicationServices;

namespace DobleCinco_BarberanCastillo
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is Usuarios)
                {
                    frm.BringToFront();
                    frm.Focus();
                    return;
                } else
                {
                    frm.Close();
                }
            }
            Usuarios user = Usuarios.VentanaUnica();
            user.MdiParent = this;
            user.StartPosition = FormStartPosition.Manual;
            user.Location = new Point(0, 0);
            user.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is Producto)
                {
                    frm.BringToFront();
                    frm.Focus();
                    return;
                }
                else
                {
                    frm.Close();
                }
            }
            Producto prd = new Producto();
            prd.MdiParent = this;
            prd.StartPosition = FormStartPosition.Manual;
            prd.Location = new Point(0, 0);
            prd.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is Ventas)
                {
                    frm.BringToFront();
                    frm.Focus();
                    return;
                }
                else
                {
                    frm.Close();
                }
            }
            Ventas vts = new Ventas();
            vts.MdiParent = this;
            vts.StartPosition = FormStartPosition.Manual;
            vts.Location = new Point(0, 0);
            vts.Show();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }
    }
}
