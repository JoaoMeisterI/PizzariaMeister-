using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzariaMeister
{
    public partial class frmPedidoTotal : Form
    {
        public frmPedidoTotal()
        {
            InitializeComponent();
        }

        public frmPedidoTotal(float total, List<string> sabores)
        {
            InitializeComponent();

            lbl_ValorTotal.Text = total.ToString();
            string textoConcatenado = string.Join(Environment.NewLine, sabores);
            lbl_saboresEscolhidos.Text = textoConcatenado;

        }

        private void lbl_tamanho_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
