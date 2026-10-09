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
    public partial class FrmEx5: Form
    {
        public FrmEx5()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            char[,] respostas = new char[7, 10];
            char[] gabarito = new char[] { 'C', 'A', 'E', 'B', 'D', 'A', 'C', 'E', 'B', 'D' };
            List<string> itensListBox = new List<string>();
            string entrada;

            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    entrada = Interaction.InputBox($"Digite a resposta da questão {j + 1} do {i + 1}º aluno: ");

                    respostas[i, j] = Convert.ToChar(entrada);
                }
            }

            for(int i = 0; i < 7; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    string statusQuestao = respostas[i, j] == gabarito[j] ? "acertou" : "errou";
                    itensListBox.Add($"O aluno {i + 1}: {statusQuestao} a questão {j + 1} (escolheu {respostas[i, j]}, era {gabarito[j]})");
                }
            }
            LbEx5.DataSource = itensListBox;
        }
    }
}
