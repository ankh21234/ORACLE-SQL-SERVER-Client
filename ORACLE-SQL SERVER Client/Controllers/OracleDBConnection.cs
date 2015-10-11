using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ORACLE_SQL_SERVER_Client.Controllers
{
    class OracleDBConnection
    {
        private static OracleDBConnection instance = null;
        private String SID;
        private String username;
        private String password;
        private String connection;
        private OracleConnection dbConnection;

        private OracleDBConnection(String pServerName, String pUsername, String pPassword)
        {
            this.SID = pServerName;
            this.username = pUsername;
            this.password = pPassword;
        }

        public String createConnection()
        {
            connection = String.Format("Data Source={0};User Id={1};Password={2};", this.SID, this.username, this.password);
            dbConnection = new OracleConnection();
            try
            {
                dbConnection.ConnectionString = connection;
                dbConnection.Open();
                return "Success";
            }
            catch (Exception e)
            {
                String error = e.Message.ToString();
                Console.WriteLine(e.ToString());
                return error;
            }

            finally
            {
                dbConnection.Dispose();
            }
        }

        public static OracleDBConnection getConnectionObject(String pServerName, String pUsername, String pPassword)
        {
            if (instance == null)
            {
                instance = new OracleDBConnection(pServerName, pUsername, pPassword);
            }
            return instance;
        }

        public OracleConnection getDatabaseConnection()
        {
            return dbConnection;
        }
    }
}
