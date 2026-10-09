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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MenuEx1_Click(object sender, EventArgs e)
        {
            int[] arrayNumeros = new int[20];
            string entrada, auxiliar = "";

            for (int i = 0;i < 20; i++)
            {
                entrada = Interaction.InputBox("Digite um número inteiro: ");
                if(!int.TryParse(entrada, out int num))
                {
                    MessageBox.Show("O número digitado deve ser inteiro");
                    i--;
                }
                else
                {
                    arrayNumeros[i] = num;
                }
            }
            Array.Reverse(arrayNumeros);

            foreach (int n in arrayNumeros)
            {
                auxiliar += n + " ";
            }
            MessageBox.Show($"Ordem Inversa: {auxiliar}");
        }
        private void MenuEx2_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList { "Ana", "André", "Beatriz", "Camila", "João", "Joana", "Otávio", "Marcelo", "Pedro", "Thais" };
            alunos.Remove("Otávio");

            string auxiliar = "";
            foreach(string s in alunos)
            {
                auxiliar += s + ", ";
            }
            MessageBox.Show($"Lista de alunos: {auxiliar}");
        }

        private void MenuEx3_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];
            double[] medias = new double[20];
            string entrada, auxiliar = "";

            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    entrada = Interaction.InputBox($"Digite a nota {j+1} do {i+1}º aluno: ");
                    if (!Double.TryParse(entrada, out double num) || num < 0 || num > 10)
                    {
                        MessageBox.Show("Nota inválida");
                        j--;
                    }
                    else
                    {
                        notas[i, j] = num;
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                medias[i] = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;

                auxiliar += $"Aluno {i + 1}: {medias[i]:N2}\n";
            }
            MessageBox.Show(auxiliar);
        }

        private void MenuEx4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmEx4>().Count() > 0)
            {
                Application.OpenForms["FrmEx4"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                FrmEx4 ex4 = new FrmEx4(); // crio o objeto do novo formulario
                ex4.MdiParent = this;
                ex4.WindowState = FormWindowState.Maximized;
                ex4.Show();
            }
        }

        private void MenuEx5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmEx5>().Count() > 0)
            {
                Application.OpenForms["FrmEx5"].BringToFront(); // form existe traz ele para a frente
            }
            else
            {
                FrmEx5 ex5 = new FrmEx5(); // crio o objeto do novo formulario
                ex5.MdiParent = this;
                ex5.WindowState = FormWindowState.Maximized;
                ex5.Show();
            }
        }
    }
}
