using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ORACLE_SQL_SERVER_Client.Controllers;

namespace ORACLE_SQL_SERVER_Client.Views
{
    public partial class SQLServerSessionDetails : Form
    {
        public SQLServerSessionDetails(SQLServerConnection connection)
        {
            InitializeComponent();
            this.dbConnection = connection;
            SqlConnection databaseConnection = connection.getDatabaseConnection();
            String query = "SELECT spid, hostname, db_name(dbid) as DatabaseName, loginame, cmd, status "
                           + "FROM master.dbo.sysprocesses "
                           + "WHERE program_name = 'ORACLE-SQL-SERVER-CLIENT'"
                           + "AND db_name(dbid) = '" 
                           + this.dbConnection.getDatabaseConnection().Database + "'";
            SqlCommand command = new SqlCommand(query, databaseConnection);
            SqlDataReader reader;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                this.sessionListing.Rows.Add("SPID", reader["spid"]);
                this.sessionListing.Rows.Add("HOST", reader["hostname"]);
                this.sessionListing.Rows.Add("DATABASE", reader["DatabaseName"]);
                this.sessionListing.Rows.Add("USER", reader["loginame"]);
                this.sessionListing.Rows.Add("COMMAND", reader["cmd"]);
                this.sessionListing.Rows.Add("STATUS", reader["status"]);
            }
            reader.Close();
           
        }
    }
}
