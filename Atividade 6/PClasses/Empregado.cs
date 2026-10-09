using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract internal class Empregado
    {
        //criacao de atributos
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;

        //criacao de propriedades
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }
        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        //criacao de metodos -> sao acoes/comportamentos
        //virtual -> pode ser sobre-escrito
        public virtual int TempoTrabalho()
        {
            //representa um espaço de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days);
        }
        //quando uma classe eh abstrata nao eh possivel criar objetos a partir delas
        public abstract double SalarioBruto();

        public Empregado()//Constructor
        {
            System.Windows.Forms.MessageBox.Show("Aqui é empregado");
        }

        //public static String empresa = "Toyota";
    }
}
