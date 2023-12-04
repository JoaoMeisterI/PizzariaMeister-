namespace appEstoqueTi
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_mostraPizza_Click(object sender, EventArgs e)
        {
            frmTamanhoPizza appTamanho = new frmTamanhoPizza();
            appTamanho.ShowDialog();
        }
    }
}
