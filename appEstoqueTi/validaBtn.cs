using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace pizzariaMeister
{
    internal class validaBtn
    {
        public static int ValidaCor(int quantidade, int quantidadeClick, Button botao)
        {

           


            if (quantidade > quantidadeClick ) 
                {
                    quantidadeClick += 1;
                    botao.BackColor = Color.Green;
                    
                }

          
            
            else 
            {

                if (botao.BackColor == SystemColors.Control)
                {
                    botao.BackColor = Color.Green;
                    quantidadeClick += 1;
                }


                if (botao.BackColor == Color.Green)
                {
                    
                    botao.BackColor = SystemColors.Control;
                    quantidadeClick -= 1;
                    Console.WriteLine(quantidadeClick);
                }
               
            }
                
                
               




            return quantidadeClick;
        }

        public static List<string> PegaSabor(Button botao,string sabor, List<string> sabores)
        {
            if (botao.BackColor == Color.Green)
            {
                sabores.Add(sabor);           
            }

            return sabores;
        }

    }



}
