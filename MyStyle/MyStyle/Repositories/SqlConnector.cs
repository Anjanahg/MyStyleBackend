using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace MyStyle.Repositories
{
    public class SqlConnector
    {
        private static SqlConnection sqlConnection = null;

        private SqlConnector()
        {
        }

        public static SqlConnection Connection()
        {
            return  new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
        }
    }
}