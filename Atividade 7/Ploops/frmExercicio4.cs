using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ploops
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        double producao, salario, gratificacao;

        private void txtNome_Validated(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome deve ser preenchido!");
                txtNome.Focus();
            }
        }

        private void txtMatricula_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula deve ser preenchida!");
                txtMatricula.Focus();
            }
        }

        private void txtProducao_Validated(object sender, EventArgs e)
        {
            if(!Double.TryParse(txtProducao.Text, out producao))
            {
                MessageBox.Show("Produção Inválida!");
                txtProducao.Focus();
            }
        }

        private void txtSalario_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("Salário Inválido!");
                txtSalario.Focus();
            }
        }

        private void txtGratificacao_Validated(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtGratificacao.Text, out gratificacao))
            {
                MessageBox.Show("Gratificação Inválida!");
                txtGratificacao.Focus();
            }
        }
        private void btnCalcularSB_Click(object sender, EventArgs e)
        {
            int B = 0, C = 0, D = 0;

            if (producao >= 100)
            {
                B = 1;

                if (producao >= 120)
                {
                    C = 1;

                    if (producao >= 150)
                    {
                        D = 1;
                    }
                }
            }

            double SalarioBruto = salario + salario * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

            if (SalarioBruto >= 7000)
            {
                if (producao >= 150)
                {
                    MessageBox.Show($"Salário Bruto: R$ {SalarioBruto:N2}");
                }
                else
                {
                    MessageBox.Show("Sua produção deve ser superior a 150!");
                }
            }
            else
            {
                MessageBox.Show($"Salário Bruto: R$ {SalarioBruto:N2}");
            }

        }
    }
}
