using Microsoft.VisualBasic.ApplicationServices;

namespace DobleCinco_BarberanCastillo
{
    public partial class FormMDI : Form
    {
        private int perfilUsuario;

        public FormMDI(int perfil)
        {
            InitializeComponent();
            perfilUsuario = perfil;
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
                }
                else
                {
                    frm.Close();
                }
            }
            Usuarios user = new Usuarios();
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
            usuarioToolStripMenuItem.Enabled = perfilUsuario == 1 || perfilUsuario == 2;
            productosToolStripMenuItem.Enabled = perfilUsuario == 2 || perfilUsuario == 1; // Solo habilita el menú si el perfil es 1 (gerente) o 2 (administrador)
            ventasToolStripMenuItem.Enabled = perfilUsuario == 3; // Habilita el menú si el perfil es 3 (vendedor)
            ReportesToolStripMenuItem.Enabled = perfilUsuario == 1; // Solo habilita el menú si el perfil es 1 (gerente)
            RUsuarioToolStripMenuItem.Enabled = perfilUsuario == 2; // Solo habilita el menú si el perfil es 2 (administrador)
            RVentasToolStripMenuItem.Enabled = perfilUsuario == 3; // Habilita el menú si el perfil es 3 (vendedor)
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is Reportes)
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
            Reportes rtes = new Reportes();
            rtes.MdiParent = this;
            rtes.StartPosition = FormStartPosition.Manual;
            rtes.Location = new Point(0, 0);
            rtes.Show();
        }

        private void RUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is ReporteUsuario)
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
            ReporteUsuario rusr = new ReporteUsuario();
            rusr.MdiParent = this;
            rusr.StartPosition = FormStartPosition.Manual;
            rusr.Location = new Point(0, 0);
            rusr.Show();
        }

        private void RVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is ReporteVenta)
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
            ReporteVenta rvtas = new ReporteVenta();
            rvtas.MdiParent = this;
            rvtas.StartPosition = FormStartPosition.Manual;
            rvtas.Location = new Point(0, 0);
            rvtas.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit(); // Esto fuerza el cierre de toda la aplicación
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.Show();
            this.Hide();

        }
    }
}
