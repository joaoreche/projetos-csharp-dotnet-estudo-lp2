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
    public partial class frmMensalista: Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void BtnInstanciar_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            objMensalista.Matricula = Convert.ToInt32(TxtMatricula.Text);
            objMensalista.NomeEmpregado = TxtNome.Text;
            objMensalista.SalarioMensal = Convert.ToDouble(TxtSalarioMensal.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(TxtDataEntrada.Text);

            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                            "Nome: " + objMensalista.NomeEmpregado + "\n" +
                            "Salário Final: " + objMensalista.SalarioBruto() + "\n" +
                            "Tempo de Trabalho: " + objMensalista.TempoTrabalho().ToString());

            //MessageBox.Show(Mensalista.empresa);
        }

        private void BtnInstanciarParametros_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(Convert.ToInt32(TxtMatricula.Text), TxtNome.Text,
                                                      Convert.ToDateTime(TxtDataEntrada.Text), Convert.ToDouble(TxtSalarioMensal.Text));

            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                            "Nome: " + objMensalista.NomeEmpregado + "\n" +
                            "Salário Final: " + objMensalista.SalarioBruto() + "\n" +
                            "Tempo de Trabalho: " + objMensalista.TempoTrabalho().ToString());
        }
    }
}
