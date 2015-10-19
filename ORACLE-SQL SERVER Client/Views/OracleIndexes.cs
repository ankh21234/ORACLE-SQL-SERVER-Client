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
    public partial class OracleIndexes : Form
    {
        public OracleIndexes(OracleDBConnection connection, String indexName)
        {
            InitializeComponent();
            this.dbConnection = connection;
            OracleConnection databaseConnection = connection.getDatabaseConnection();
            String query = "SELECT INDEX_NAME, INDEX_TYPE, USER_INDEXES.TABLE_NAME, UNIQUENESS "
                           + "FROM USER_INDEXES, USER_TABLES "
                           + "WHERE INDEX_NAME = '" + indexName + "' "
                           + "AND USER_INDEXES.TABLE_NAME = USER_TABLES.TABLE_NAME";
            OracleCommand command = new OracleCommand(query, databaseConnection);
            OracleDataReader reader;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                this.indexList.Rows.Add("NAME", reader["INDEX_NAME"]);
                this.indexList.Rows.Add("TYPE", reader["INDEX_TYPE"]);
                this.indexList.Rows.Add("TABLE", reader["TABLE_NAME"]);
                this.indexList.Rows.Add("UNIQUENESS", reader["UNIQUENESS"]);
            }
            reader.Close();
        }
    }
}
