using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;

namespace PFerramentas0030482423057
{
    internal class Fabricante
    {
        public int IdFabricante { get; set; }
        public string NomeFantasia { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daFabricante;
            DataTable dtFabricante = new DataTable();
            try
            {
                daFabricante = new SqlDataAdapter("SELECT * FROM FABRICANTE", frmPrincipal.conexao);
                daFabricante.Fill(dtFabricante);
                daFabricante.FillSchema(dtFabricante, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtFabricante;
        }
        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO FABRICANTE VALUES (@nomeFantasia)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nomeFantasia", SqlDbType.VarChar));

                mycommand.Parameters["@nomeFantasia"].Value = NomeFantasia;

                retorno = mycommand.ExecuteNonQuery();
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

                myCommand = new SqlCommand("UPDATE FABRICANTE SET nomeFantasia = " +
                                           "@nomeFantasia WHERE id = @idfabricante", frmPrincipal.conexao);

                myCommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));

                myCommand.Parameters.Add(new SqlParameter("@nomeFantasia", SqlDbType.VarChar));

                myCommand.Parameters["@idfabricante"].Value = IdFabricante;
                myCommand.Parameters["@nomeFantasia"].Value = NomeFantasia;

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
                myCommand = new SqlCommand("DELETE FROM FABRICANTE WHERE id=@idfabricante", frmPrincipal.conexao);

                myCommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));

                myCommand.Parameters["@idfabricante"].Value = IdFabricante;

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
