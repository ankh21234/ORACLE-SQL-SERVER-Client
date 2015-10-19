using ORACLE_SQL_SERVER_Client.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORACLE_SQL_SERVER_Client.Views
{
    public partial class procedureViewerSQLServer : Form
    {
        private SQLServerConnection dbConnection;
        private string procedureName;
        

        public procedureViewerSQLServer(String procedureName, SQLServerConnection connection, bool option)
        {
            InitializeComponent();
            this.procedureName = procedureName;
            this.dbConnection = connection;
            this.Text = procedureName + "@" + dbConnection.getDatabaseConnection().Database;
            refreshInitialize();
        }

        private void procedureViewerSQLServer_Load(object sender, EventArgs e)
        {

        }
         private void refreshInitialize()
        {



            String query = "DECLARE @find NVARCHAR(4000);"+
                            "SELECT @find = '"+ procedureName + "';"+
                            " WITH definitions AS(SELECT  so.name, OBJECT_DEFINITION(id) AS TEXT"+
                            " FROM sys.sysobjects so WHERE name NOT LIKE 'sys%') "+
                            " SELECT name, SUBSTRING(TEXT,0, 5000) "+
                            " AS context FROM definitions"+
                            " WHERE CHARINDEX(@find, TEXT COLLATE Latin1_General_CI_AI) <> 0";

            SqlConnection dataBaseConnection = dbConnection.getDatabaseConnection();
            SqlCommand command = new SqlCommand(query, dataBaseConnection);
            DataTable data = new DataTable();
            SqlDataReader reader;
            command.CommandText = query;
            command.CommandType = CommandType.Text;

            reader = command.ExecuteReader();
            data.Load(reader);

            foreach (DataRow row in data.Rows)
            {
                var ColumnData = row[1].ToString();
                this.richTextBox_DDL.AppendText(ColumnData);
            }

            


              
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox_DDL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
