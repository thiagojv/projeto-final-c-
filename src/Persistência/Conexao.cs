using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace Persistencia
{
    public class Conexao
    {
        private SqlConnection sqlcnctnConnection;

        public Conexao()
        {
            sqlcnctnConnection = new SqlConnection(RetornarConnectionString());
        }

        private string RetornarConnectionString()
        {
            return "Data Source=junqueira-03;Initial Catalog=PFC_I;Integrated Security=True";
        }

        public SqlConnection Connection
        {
            get { return sqlcnctnConnection; }
            set { sqlcnctnConnection = value; }
        }
    }
}
