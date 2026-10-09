using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulo
{
    public partial class Form1 : Form
    {
        Double valorA, valorB, valorC;


        public Form1()
        {
            InitializeComponent();
        }

        private void txtValorA_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtValorA.Text, out valorA) || valorA <=0)
            {
                MessageBox.Show("Valor A inválido!");
                txtValorA.Focus();
            }
        }


        private void txtValorB_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtValorB.Text, out valorB) || valorB <= 0)
            {
                MessageBox.Show("Valor B inválido!");
                txtValorB.Focus();
            }
        }
        private void txtValorC_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtValorC.Text, out valorC) || valorC <= 0)
            {
                MessageBox.Show("Valor C inválido!");
                txtValorC.Focus();
            }
        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (((Math.Abs(valorB - valorC) < valorA) && (valorA < valorB + valorC)) ||
                ((Math.Abs(valorA - valorC) < valorB) && (valorB < valorA + valorC)) ||
                ((Math.Abs(valorA - valorB) < valorC) && (valorC < valorA + valorB)))
            {
                if (valorA == valorB && valorA == valorC)
                {
                    MessageBox.Show("Triângulo Equilátero!");
                }
                else if (valorA != valorB && valorA != valorC)
                {
                    MessageBox.Show("Triângulo Escaleno!");
                }
                else
                {
                    MessageBox.Show("Triângulo Isósceles!");
                }
            }
            else
            {
                MessageBox.Show("Esses valores não podem pertencer a um triângulo");
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
