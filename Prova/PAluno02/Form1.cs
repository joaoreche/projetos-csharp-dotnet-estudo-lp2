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

namespace PAluno02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            
            double[,] notas = new double[2, 3];
            double[] medias = new double[2];
            double mediaGeral = 0;
            string entrada;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    entrada = Interaction.InputBox($"Digite a nota do aluno {i+1} no professor {j+1}: ");
                    if (!Double.TryParse(entrada, out double num) || num < 0 || num > 10)
                    {
                        MessageBox.Show("Digite uma nota válida!");
                        j--;
                    }
                    else
                    {
                        notas[i, j] = num;
                    }
                }
            }

            for(int i = 0 ; i < 2; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    medias[i] += notas[i, j];
                }
                medias[i] /= 3;
                mediaGeral += medias[i];
            }

            for(int i = 0; i < 2; i++)
            {
                LstBxResultado.Items.Add($"Aluno {i+1}: Nota professor 1: {notas[i, 0]:N2};" +
                                   $" Nota professor 2: {notas[i, 1]:N2};" +
                                   $" Nota professor 3: {notas[i, 2]:N2};" +
                                   $" Média: {medias[i]:N2}");
            }

            mediaGeral /= 2;
            LstBxResultado.Items.Add("-------------------------------");
            LstBxResultado.Items.Add($"Média Geral: {mediaGeral:N2}");
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LstBxResultado.Items.Clear();
        }
    }
}
