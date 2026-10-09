using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimc
{
    public partial class Form1 : Form
    {
        double peso, altura, imc;

        public Form1()
        {
            InitializeComponent();
        }

        private void mskbxPeso_Validated(object sender, EventArgs e)
        {
            try
            {
                peso = Convert.ToDouble(mskbxPeso.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Peso iválido!");
                mskbxPeso.Focus();
            }
        }
        private void mskbxAltura_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(mskbxAltura.Text, out altura) || altura <= 0)
            {
                MessageBox.Show("Altura inválida!");
                mskbxAltura.Focus();
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            imc = peso / Math.Pow(altura, 2);
            imc = Math.Round(imc, 1);
            txtImc.Text = imc.ToString();

            if(imc < 18.5)
            {
                MessageBox.Show("Magreza!");
            }
            else if(imc <= 24.9)
            {
                MessageBox.Show("Normal!");
            }
            else if(imc <= 29.9)
            {
                MessageBox.Show("Sobrepeso! (Grau I)");
            }
            else if(imc <= 39.9)
            {
                MessageBox.Show("Obesidade! (Grau II)");
            }
            else
                MessageBox.Show("Obesidade Grave! (Grau III)");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxPeso.Clear();
            mskbxAltura.Clear();
            txtImc.Clear();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
