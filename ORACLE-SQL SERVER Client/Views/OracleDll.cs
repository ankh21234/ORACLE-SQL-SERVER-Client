using Oracle.ManagedDataAccess.Client;
using ORACLE_SQL_SERVER_Client.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORACLE_SQL_SERVER_Client.Views
{
    public partial class OracleDll : Form
    {
        private OracleDBConnection dbConnection;

        public OracleDll(OracleDBConnection connection, String objectType, String objectName)
        {
            InitializeComponent();
            this.dbConnection = connection;
            DataTable data = new DataTable();
            OracleConnection databaseConnection = connection.getDatabaseConnection();
            String query = "SELECT DBMS_METADATA.GET_DDL('" + objectType + "',"
                + "'" + objectName +"')AS DDL FROM DUAL";
            Console.WriteLine(query);
            OracleCommand command = new OracleCommand(query, databaseConnection);
            OracleDataReader reader;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();


            data.Load(reader);

            foreach (DataRow row in data.Rows)
            {
                String ColumnData = row[0].ToString();
                this.richTextBox1.AppendText(ColumnData);
            }

            
            reader.Close();
        }
    }
}
