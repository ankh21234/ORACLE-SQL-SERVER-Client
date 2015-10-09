using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ORACLE_SQL_SERVER_Client.Controllers
{
    class SQLServerConnection
    {
        private static SQLServerConnection instance = null;
        private String serverName;
        private String databaseName;
        private String username;
        private String connection;
        private SqlConnection dbConnection;

        private SQLServerConnection(String pServerName, String pDatabaseName, String pUsername)
        {
            this.serverName = pServerName;
            this.databaseName = pDatabaseName;
            this.username = pUsername;
            connection = "Server =" + this.serverName + ";Database =" + this.databaseName +
                ";Integrated Security= true; user = " + this.username;
            dbConnection = new SqlConnection(connection);

            try
            {
                dbConnection.Open();
                Console.WriteLine("Connection Works");
            }
            catch (Exception e)
            {
                String error = e.ToString();
                Console.WriteLine(error);
            }
        }

        public static SQLServerConnection getConnectionObject(String pServerName, String pDatabaseName, String pUsername)
        {
            if (instance == null)
            {
                instance = new SQLServerConnection(pServerName, pDatabaseName, pUsername);
            }
            return instance;
        }

        public SqlConnection getDatabaseConnection()
        {
            return dbConnection;
        }
    }
}
