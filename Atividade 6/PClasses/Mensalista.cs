using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    internal class Mensalista : Empregado
    {
        public Double SalarioMensal 
        { 
            //get e set tambem pode ser criado dessa forma, porem nao pode ter acao nehuma
            get;
            set; 
        }

        //sobre-escrevendo o metodo
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
        public Mensalista()
        {
            System.Windows.Forms.MessageBox.Show("Aqui é mensalista");
        }

        public Mensalista(int matx, string nomex, DateTime datax, double salx)
        {
            this.NomeEmpregado = nomex;
            this.Matricula = matx;
            this.DataEntradaEmpresa = datax;
            this.SalarioMensal = salx;
        }
    }
}
