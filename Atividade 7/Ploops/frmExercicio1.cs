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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }
        private void rchtxtEx1_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(rchtxtEx1.Text))
            {
                MessageBox.Show("A caixa de texto deve estar preenchida!");
                rchtxtEx1.Focus();
            }
        }

        private void btnContarWhiteSpaces_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (var i = 0; i < rchtxtEx1.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchtxtEx1.Text[i]))
                {
                    contador++;
                }
            }
            MessageBox.Show($"O texto possui {contador} espaços em branco");
        }

        private void btnContarR_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char x in rchtxtEx1.Text)
            {
                if (char.ToUpper(x) == 'R')
                {
                    contador++;
                }
            }
            MessageBox.Show($"O texto possui {contador} letras 'R'");
        }

        private void btnContarPares_Click(object sender, EventArgs e)
        {
            int i = 0, contador = 0;

            while (i < rchtxtEx1.Text.Length - 1)
            {
                if (i == 0)
                {
                    if (rchtxtEx1.Text[i] == rchtxtEx1.Text[i+1])
                    {
                        contador++;
                    }
                }
                else if (rchtxtEx1.Text[i] == rchtxtEx1.Text[i-1])
                {
                    contador++;
                }

                i++;
            }
            MessageBox.Show($"O texto possui {contador} pares de letras");
        }
    }
}
