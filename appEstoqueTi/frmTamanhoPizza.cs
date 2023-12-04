using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appEstoqueTi
{
    public partial class frmTamanhoPizza : Form
    {
        public frmTamanhoPizza()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_pequena_Click(object sender, EventArgs e)
        {
            frmSabores appSabores = new frmSabores(3,35);
            appSabores.ShowDialog();
        }

        private void btn_media_Click(object sender, EventArgs e)
        {
            frmSabores appSabores = new frmSabores(4,50);
            appSabores.ShowDialog();
        }

        private void btn_grande_Click(object sender, EventArgs e)
        {
            frmSabores appSabores = new frmSabores(5,75);
            appSabores.ShowDialog();
        }
    }
}
