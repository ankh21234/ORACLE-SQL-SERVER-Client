﻿using System;
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
        private String connection;
        private SqlConnection dbConnection;

        public SQLServerConnection(String pServerName, String pDatabaseName, String pUsername)
        {
            this.serverName = pServerName;
            this.databaseName = pDatabaseName;
            this.username = pUsername;
        }

        public String createConnection()
        {
            connection = "Server =" + this.serverName + ";Database =" + this.databaseName +
            ";Integrated Security= true; user = " + this.username;
            dbConnection = new SqlConnection(connection);

            try
            {
                dbConnection.Open();
                return "Connection established. Press OK to continue.";
            }
            catch (Exception e)
            {
                String error = e.ToString();
                return error;
            }
        }

        public SqlConnection getDatabaseConnection()
        {
            return dbConnection;
        }
    }
}
