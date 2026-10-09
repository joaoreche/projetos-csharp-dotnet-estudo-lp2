using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodod
{
    public partial class FrmExercicio5 : Form
    {
        int num1,num2;
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void BtnSortear_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtNumero1.Text, out num1) || !int.TryParse(TxtNumero2.Text, out num2) || num2 <= num1)
            {
                MessageBox.Show("Números inválidos!");
                TxtNumero1.Focus();
            }
            else
            {
                Random objR = new Random();

                int numAleatorio = objR.Next(num1, num2);
                MessageBox.Show("O número aleatório é: " + numAleatorio);
            }
        }
    }
}
