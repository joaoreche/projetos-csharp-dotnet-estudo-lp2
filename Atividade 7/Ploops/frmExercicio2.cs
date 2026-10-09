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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void txtNumero_Validated(object sender, EventArgs e)
        {
            double H = 0;

            if (!Double.TryParse(txtNumero.Text, out double num) || num == 0)
            {
                MessageBox.Show("Número Inválido!");
                txtNumero.Focus();
            }
            else
            {
                for(int i = 1;i <= num; i++)
                {
                    H += 1 / (double)i;
                }
                MessageBox.Show($"O número H eh: {H:N2}");
            }
        }
    }
}
