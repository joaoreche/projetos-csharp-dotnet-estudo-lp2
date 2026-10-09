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
    internal class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }

        //CRUD
        public DataTable Listar()
        {
            SqlDataAdapter daCategoria;
            DataTable dtCategoria = new DataTable();
            try
            {
                daCategoria = new SqlDataAdapter("SELECT * FROM CATEGORIA", frmPrincipal.conexao);
                daCategoria.Fill(dtCategoria);
                daCategoria.FillSchema(dtCategoria, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCategoria;
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand myCommand;
                myCommand = new SqlCommand("INSERT INTO CATEGORIA VALUES (@descricao)",
                    frmPrincipal.conexao);

                myCommand.Parameters.Add(new SqlParameter("@descricao", SqlDbType.VarChar));

                myCommand.Parameters["@descricao"].Value = Descricao;

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

                myCommand = new SqlCommand("UPDATE CATEGORIA SET descricao = " +
                                           "@descricao WHERE id = @idcategoria", frmPrincipal.conexao);

                myCommand.Parameters.Add(new SqlParameter("@idcategoria", SqlDbType.Int));

                myCommand.Parameters.Add(new SqlParameter("@descricao", SqlDbType.VarChar));

                myCommand.Parameters["@idcategoria"].Value = IdCategoria;
                myCommand.Parameters["@descricao"].Value = Descricao;

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
                myCommand = new SqlCommand("DELETE FROM CATEGORIA WHERE id=@idcategoria", frmPrincipal.conexao);

                myCommand.Parameters.Add(new SqlParameter("@idcategoria", SqlDbType.Int));

                myCommand.Parameters["@idcategoria"].Value = IdCategoria;

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
