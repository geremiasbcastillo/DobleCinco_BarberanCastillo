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
            Usuarios user = new Usuarios();
            user.MdiParent = this;
            user.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto prd = new Producto();
            prd.MdiParent = this;
            prd.Show();
        }
    }
}
