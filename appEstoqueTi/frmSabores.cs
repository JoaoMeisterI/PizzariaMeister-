using pizzariaMeister;
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
    public partial class frmSabores : Form
    {
        private int contadorClick;
        private int quantidade;
        private List<string> sabores = new List<string>();
        private float valor;
        frmPedidoTotal pedido = new frmPedidoTotal();

        public frmSabores()
        {
            InitializeComponent();
        }

        public frmSabores(int quantidade, float valor)
        {
            InitializeComponent();

            this.quantidade = quantidade;
            this.valor = valor;

            if (quantidade == 3)
            {
                lbl_quantidade.Text = "Até 3 sabores";
            }
            else if (quantidade == 4)
            {
                lbl_quantidade.Text = "Até 4 sabores";
            }
            else
            {
                lbl_quantidade.Text = "Até 5 sabores";
            }



        }



        private void btn_peperone_Click(object sender, EventArgs e)
        {
            contadorClick = validaBtn.ValidaCor(quantidade, contadorClick, btn_peperone); ;

            sabores = validaBtn.PegaSabor(btn_peperone, "Peperone", sabores);

            if (btn_peperone.BackColor == Color.Green)
            {
                pedido = new frmPedidoTotal(valor, sabores);
            }
        }

        private void btn_4queijos_Click(object sender, EventArgs e)
        {
            contadorClick = validaBtn.ValidaCor(quantidade, contadorClick, btn_4queijos);

            sabores = validaBtn.PegaSabor(btn_4queijos, "4 Queijos", sabores);

            if (btn_4queijos.BackColor == Color.Green)
            {
                pedido = new frmPedidoTotal(valor, sabores);
            }
        }

        private void btn_calabresa_Click(object sender, EventArgs e)
        {

            contadorClick = validaBtn.ValidaCor(quantidade, contadorClick, btn_calabresa);

            sabores = validaBtn.PegaSabor(btn_calabresa, "Calabresa", sabores);

            if (btn_calabresa.BackColor == Color.Green)
            {
                pedido = new frmPedidoTotal(valor, sabores);
            }

        }

        private void btn_Picanha_Click(object sender, EventArgs e)
        {
            contadorClick = validaBtn.ValidaCor(quantidade, contadorClick, btn_Picanha); ;

            sabores = validaBtn.PegaSabor(btn_Picanha, "Picanha", sabores);

            if (btn_Picanha.BackColor == Color.Green)
            {
                pedido = new frmPedidoTotal(valor, sabores);
            }
        }

        private void btn_Marguerita_Click(object sender, EventArgs e)
        {
            contadorClick = validaBtn.ValidaCor(quantidade, contadorClick, btn_Marguerita); ;

            sabores = validaBtn.PegaSabor(btn_Marguerita, "Marguerita", sabores);

            if (btn_Marguerita.BackColor == Color.Green)
            {
                pedido = new frmPedidoTotal(valor, sabores);
            }
        }

        private void btn_Mignon_Click(object sender, EventArgs e)
        {

            contadorClick = validaBtn.ValidaCor(quantidade, contadorClick, btn_Mignon); ;

            sabores = validaBtn.PegaSabor(btn_Mignon, "Mignon", sabores);

            if (btn_Mignon.BackColor == Color.Green)
            {
                pedido = new frmPedidoTotal(valor, sabores);
            }
        }

        private void btn_FrangoBacon_Click(object sender, EventArgs e)
        {
            contadorClick = validaBtn.ValidaCor(quantidade, contadorClick, btn_FrangoBacon); ;

            sabores = validaBtn.PegaSabor(btn_FrangoBacon, "Frango e Bacon", sabores);

            if (btn_FrangoBacon.BackColor == Color.Green)
            {
                pedido = new frmPedidoTotal(valor, sabores);
            }
        }

        private void btn_vegetariana_Click(object sender, EventArgs e)
        {
            contadorClick = validaBtn.ValidaCor(quantidade, contadorClick, btn_vegetariana); ;

            sabores = validaBtn.PegaSabor(btn_vegetariana, "Vegetariana", sabores);

            if (btn_vegetariana.BackColor == Color.Green)
            {
                pedido = new frmPedidoTotal(valor, sabores);

            }
        }

        private void btn_bacon_Click(object sender, EventArgs e)
        {
            contadorClick = validaBtn.ValidaCor(quantidade, contadorClick, btn_bacon); ;

            sabores = validaBtn.PegaSabor(btn_bacon, "Bacon", sabores);

            if (btn_bacon.BackColor == Color.Green)
            {
                pedido = new frmPedidoTotal(valor, sabores);
            }
        }

        private void btn_finalizaPedido_Click(object sender, EventArgs e)
        {
            pedido.ShowDialog();
        }
    }
}
