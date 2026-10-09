using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void BtnInstanciar_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = TxtNome.Text;
            objHorista.Matricula = Convert.ToInt32(TxtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(TxtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(TxtHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(TxtData.Text);
            objHorista.DiasFalta = Convert.ToInt32(TxtFaltas.Text);
            //mostrando valores
            MessageBox.Show($"Nome: {objHorista.NomeEmpregado}\n" +
                            $"Matrícula: {objHorista.Matricula}\n" +
                            $"Tempo de Trabalho: {objHorista.TempoTrabalho()}\n" +
                            $"Salario: {objHorista.SalarioBruto().ToString("N2")}");
        }
    }
}
