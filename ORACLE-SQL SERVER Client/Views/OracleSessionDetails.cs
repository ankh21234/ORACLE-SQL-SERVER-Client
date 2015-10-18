using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using ORACLE_SQL_SERVER_Client.Controllers;

namespace ORACLE_SQL_SERVER_Client.Views
{
    public partial class OracleSessionDetails : Form
    {
        public OracleSessionDetails(OracleDBConnection connection)
        {
        
            InitializeComponent();
            this.dbConnection = connection;
            OracleConnection databaseConnection = dbConnection.getDatabaseConnection();
            String query;
            OracleCommand command = new OracleCommand("DBMS_SESSION.set_identifier",databaseConnection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(dbConnection.getUsername(), OracleDbType.Char);
            command.ExecuteNonQuery();

            query = "SELECT SYS_CONTEXT('userenv', 'SID') AS SID, "
                    + "SYS_CONTEXT('userenv', 'HOST') AS HOST, "
                    + "USER AS username "
                    + "FROM dual";
            command = new OracleCommand(query, databaseConnection);
            OracleDataReader reader;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                this.sessionListing.Rows.Add("SID", reader["SID"]);
                this.sessionListing.Rows.Add("HOST", reader["HOST"]);
                this.sessionListing.Rows.Add("DATABASE", dbConnection.getDatabaseConnection().DataSource);
                this.sessionListing.Rows.Add("USER", reader["USERNAME"]);
            }
            reader.Close();

        }
    }
}
