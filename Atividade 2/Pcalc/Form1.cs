using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalc
{
    public partial class Form1 : Form
    {
        double num1, num2, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtNumero1.Text, out num1))
            {
                MessageBox.Show("Número 1 inválido!");
                txtNumero1.Focus();
            }
        }
        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero2.Text, out num2))
            {
                MessageBox.Show("Número 2 inválido!");
                txtNumero2.Focus();
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            resultado = num1 + num2;
            txtResultado.Text = resultado.ToString("N2");
        }
        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            resultado = num1 - num2;
            txtResultado.Text = resultado.ToString("N2");
        }
        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            resultado = num1 * num2;
            txtResultado.Text = resultado.ToString("N2");
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumero2.Text, out num2) || num2 == 0)
            {
                txtResultado.Text = "Não é possível dividir por zero";
                txtNumero2.Focus();
            }
            else
            {
                resultado = num1 / num2;
                txtResultado.Text = resultado.ToString("N2");
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
