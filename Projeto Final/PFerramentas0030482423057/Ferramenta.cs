using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PFerramentas0030482423057
{
    internal class Ferramenta
    {
        public int IdFerramenta { get; set; }
        public string Nome {  get; set; }
        public char Distribuicao { get; set; }
        public DateTime DtCadastro { get; set; }
        public string SiteOficial {  get; set; }
        public int IdCategoria { get; set; }
        public int IdFabricante { get; set; }
        
        public DataTable Listar()
        {
            SqlDataAdapter daFerramenta;
            DataTable dtFerramenta = new DataTable();
            try
            {
                daFerramenta = new SqlDataAdapter("SELECT * FROM FERRAMENTA", frmPrincipal.conexao);
                daFerramenta.Fill(dtFerramenta);
                daFerramenta.FillSchema(dtFerramenta, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtFerramenta;
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand myCommand;
                myCommand = new SqlCommand("INSERT INTO FERRAMENTA VALUES" +
                    "(@nome, @distribuicao, @dtcadastro, @siteoficial," +
                    "@idcategoria, @idfabricante)", frmPrincipal.conexao);
                   

                myCommand.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar));
                myCommand.Parameters.Add(new SqlParameter("@distribuicao", SqlDbType.Char));
                myCommand.Parameters.Add(new SqlParameter("@dtcadastro", SqlDbType.DateTime));
                myCommand.Parameters.Add(new SqlParameter("@siteoficial", SqlDbType.VarChar));
                myCommand.Parameters.Add(new SqlParameter("@idcategoria", SqlDbType.Int));
                myCommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));

                myCommand.Parameters["@nome"].Value = Nome;
                myCommand.Parameters["@distribuicao"].Value = Distribuicao;
                myCommand.Parameters["@dtcadastro"].Value = DtCadastro;
                myCommand.Parameters["@siteoficial"].Value = SiteOficial;
                myCommand.Parameters["@idcategoria"].Value = IdCategoria;
                myCommand.Parameters["@idfabricante"].Value = IdFabricante;

                retorno = myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;
            try
            {
                SqlCommand myCommand;

                myCommand = new SqlCommand("UPDATE FERRAMENTA SET nome = @nome, " +
                    "distribuicao = @distribuicao, " +
                    "dtcadastro = @dtcadastro, siteoficial = @siteoficial, "+
                    "idcategoria = @idcategoria, idfabricante = @idfabricante " +
                    " WHERE id = @idferramenta", frmPrincipal.conexao);

                myCommand.Parameters.Add(new SqlParameter("@idferramenta", SqlDbType.Int));
                myCommand.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar));
                myCommand.Parameters.Add(new SqlParameter("@distribuicao", SqlDbType.Char));
                myCommand.Parameters.Add(new SqlParameter("@dtcadastro", SqlDbType.DateTime));
                myCommand.Parameters.Add(new SqlParameter("@siteoficial", SqlDbType.VarChar));
                myCommand.Parameters.Add(new SqlParameter("@idcategoria", SqlDbType.Int));
                myCommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));

                myCommand.Parameters["@idFerramenta"].Value = IdFerramenta; 
                myCommand.Parameters["@nome"].Value = Nome;
                myCommand.Parameters["@distribuicao"].Value = Distribuicao;
                myCommand.Parameters["@dtcadastro"].Value = DtCadastro;
                myCommand.Parameters["@siteoficial"].Value = SiteOficial;
                myCommand.Parameters["@idcategoria"].Value = IdCategoria;
                myCommand.Parameters["@idfabricante"].Value = IdFabricante;

                retorno = myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Excluir()
        {
            int retorno = 0;
            try
            {
                SqlCommand myCommand;
                myCommand = new SqlCommand("DELETE FROM FERRAMENTA WHERE id=@idferramenta", frmPrincipal.conexao);
                myCommand.Parameters.Add(new SqlParameter("@idferramenta", SqlDbType.Int));
                myCommand.Parameters["@idferramenta"].Value = IdFerramenta;

                retorno = myCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

    }
}
