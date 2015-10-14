using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ORACLE_SQL_SERVER_Client.Controllers
{
    public class SQLServerConnection
    {
        private String serverName;
        private String databaseName;
        private String username;
        private String password;
        private String connection;
        private SqlConnection dbConnection;

        public SQLServerConnection(String pServerName, String pDatabaseName, String pUsername, String pPassword = "")
        {
            this.serverName = pServerName;
            this.databaseName = pDatabaseName;
            this.username = pUsername;
            this.password = pPassword;
        }

        public String createConnection()
        {
            if (password == "")
            {
                connection = "Server =" + this.serverName + ";Database =" + this.databaseName +
                ";Integrated Security= true; user = " + this.username;
                dbConnection = new SqlConnection(connection);
            }
            else
            {
                connection = "Server =" + this.serverName + ";Database =" + this.databaseName +
                ";Integrated Security= true; user = " + this.username + ";password =" + this.password;
                dbConnection = new SqlConnection(connection);
            }

            try
            {
                dbConnection.Open();
                return "Connection Established. Press OK to continue.";
            }
            catch (Exception e)
            {
                String error = e.Message.ToString();
                return error;
            }
        }

        public SqlConnection getDatabaseConnection()
        {
            return dbConnection;
        }

        public  String getServerName()
        {
            return serverName;
        }

        public String getUsername()
        {
            return username;
        }

        
    }
}
