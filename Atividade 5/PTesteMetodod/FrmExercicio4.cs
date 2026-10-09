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
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcularNum_Click(object sender, EventArgs e)
        {
            int contNum = 0;

            for (var i=0; i < rchTxtFrase.Text.Length; i++)
            {
                if (char.IsNumber(rchTxtFrase.Text[i]))
                {
                    contNum++;
                }
            }
            MessageBox.Show("Possui " + contNum + " caracteres numéricos!");
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            int indice=0;

            for(var i=0; i < rchTxtFrase.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchTxtFrase.Text[i]))
                {
                    indice = i;
                    break;
                }
            }
            MessageBox.Show("O primeiro caracter em branco está na posição " + indice + "!");
        }
    
        private void btnCalcularAlfa_Click(object sender, EventArgs e)
        {
            int contLetras = 0;

            foreach (char letra in rchTxtFrase.Text)
            {
                if (char.IsLetter(letra)) 
                {
                    contLetras++;
                }
            }
            MessageBox.Show("Possui " + contLetras + " caracteres alfabéticos!");
        }
    }
}