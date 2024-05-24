using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Uninove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            /* declaração de variáveis*/
            int x, y; 
            /* entrada de dados, converte o texto do textbox para int*/

            x= Convert.ToInt32(txtResultado.Text);
            /* Incremento pré-fixado */
            y = ++x;
            /*Saída de dados*/
            MessageBox.Show("Y = " + y + " x = " + x + "Incremento pré-fixado");
        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            /* declaração de variáveis*/
            int x, y;
            /* entrada de dados, converte o texto do textbox para int*/

            x = Convert.ToInt32(txtResultado.Text);
            /*Incremento pós-fixado */
            y = x++;
            /*Saída de dados*/
            MessageBox.Show(" Y = " + y + " X = " + x + "Incremento pós-fixado");

            int a, b;
            a = 26;
            b = a % 3;
            MessageBox.Show("O resultado é " + b);
        }
    }
}
