using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace Parray
{
    public partial class FrmEx4: Form
    {
        public FrmEx4()
        {
            InitializeComponent();
        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[10];
            int[] tamanho = new int[10];
            List<string> itensListBox = new List<string>();
            string entrada;

            for (int i = 0; i < 10; i++)
            {
                entrada = Interaction.InputBox($"Digite o nome completo da pessoa {i + 1}: ");
                if (String.IsNullOrEmpty(entrada))
                {
                    MessageBox.Show("O campo deve ser preenchido!");
                    i--;
                }
                else
                {
                    nomes[i] = entrada;
                }
            }

            for(int i = 0; i < 10; i++)
            {
                tamanho[i] = nomes[i].Length;

                for(int j = 0; j < nomes[i].Length; j++)
                {
                    if (nomes[i].Substring(j, 1) == " ")
                    {
                        tamanho[i]--;
                    }
                }
            }
                
            for(int i = 0; i < 10; i++)
            {
                itensListBox.Add($"Nome: {nomes[i]} possui {tamanho[i]} caracteres");
            }
            LbEx4.DataSource = itensListBox;
        }
    }
}
