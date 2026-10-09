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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {

            string frase = "";

            foreach(char c in txtPalindromo.Text)
            {
                if(Char.IsLetterOrDigit(c))
                {
                    frase += char.ToUpper(c);
                }
            }

            char[] arrInvertido = frase.ToCharArray();

            Array.Reverse(arrInvertido);

            string fraseInvertida = new string(arrInvertido);

            if(frase == fraseInvertida)
            {
                MessageBox.Show($"A frase \"{txtPalindromo.Text}\" é um palíndromo!");
            }
            else
            {
                MessageBox.Show($"A frase \"{txtPalindromo.Text}\" não é um palíndromo!");
            }
        }
    }
}
