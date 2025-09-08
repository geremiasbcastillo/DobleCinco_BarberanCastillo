namespace DobleCinco_BarberanCastillo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.MdiParent = this;
            user.Show();
        }
    }
}
