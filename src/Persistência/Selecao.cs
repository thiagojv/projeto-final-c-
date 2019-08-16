using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class Selecao : Ancestral
    {
        public SqlDataReader Selecionar(string SQL)
        {
            try
            {
                SqlCommand sqlcmndComando = new SqlCommand(SQL, Connection.Connection);
                sqlcmndComando.Connection.Open();
                return sqlcmndComando.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }

        public object Buscar(string SQL)
        {
            try
            {
                SqlCommand sqlcmndComando = new SqlCommand(SQL, Connection.Connection);
                sqlcmndComando.Connection.Open();
                return sqlcmndComando.ExecuteScalar();
            }
            catch (Exception E)
            {
                SetMensagem(E.Message);
                return null;
            }
        }
    }
}
