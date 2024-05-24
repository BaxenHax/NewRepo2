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

        private void btnReais_Click(object sender, EventArgs e)
        {
            double a, b, soma;
            /* Entrada de dados*/
            a = Convert.ToDouble(txtA.Text);
            b = double.Parse(txtB.Text);

            /* Processamento */
            soma = a + b;

            /* Saída de dados */
            txtResultado.Text = soma.ToString();

        }

        private void btnInteiros_Click(object sender, EventArgs e)
        {
            double a, b, soma;

            /*Entrada de dados */
             a = Int32.Parse(txtA.Text);
             b = Int32.Parse(txtB.Text);

            soma = a + b;
            txtResultado.Text = soma.ToString();
        }
    }
}
