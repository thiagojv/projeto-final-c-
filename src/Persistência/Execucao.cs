using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class Execucao : Ancestral
    {
        public int Executar(string SQL)
        {
            SqlCommand sqlcmndComando = new SqlCommand(SQL, Connection.Connection);
            try
            {
                try
                {

                    sqlcmndComando.Connection.Open();
                    return sqlcmndComando.ExecuteNonQuery();
                }
                catch (Exception E)
                {
                    SetMensagem(E.Message);
                    return -1;
                }
            }
            finally
            {
                sqlcmndComando.Connection.Close();        
            }
        }
    }
}
