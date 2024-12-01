namespace GestaoHotel
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHotel frm = new frmHotel();
            frm.Show();
        }

        private void mnuCadastroHotel_Click(object sender, EventArgs e)
        {
            frmHotel frm = new frmHotel();
            frm.Show();
        }
    }
}
