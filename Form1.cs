using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenguaje3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(txtnumero.Text);

            if (numero % 2 ==0)
            {
                txtpar.Text = "numero par.";
            }
            else
            {
                txtpar.Text = "numero impar.";
            }

            if (numero>0)
            {
                txtresultado.Text = " el numero es positivo.";
            }
            else if (numero < 0)
            {
                txtresultado.Text = "el numero es negativo.";
            }
            else
            {
                txtresultado.Text = "el numero es cero.";
            }
        }

        private void btnvaciar_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtpar.Clear();
            txtresultado.Clear();
        }
    }
}
