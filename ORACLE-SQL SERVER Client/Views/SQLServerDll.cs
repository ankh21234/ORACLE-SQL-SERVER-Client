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
    public partial class SQLServerDll : Form
    {
        private SQLServerConnection dbConnection;
        private string tableName;

        public SQLServerDll(String tableName, SQLServerConnection connection, bool option)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.dbConnection = connection;
            this.Text = tableName + "@" + dbConnection.getDatabaseConnection().Database;
            refreshInitialize();
        }
        private void refreshInitialize()
        {
            String query = "";
            try
            {

                Assembly _assembly;
                Stream _imageStream;
                StreamReader _textStreamReader;


                _assembly = Assembly.GetExecutingAssembly();
                query = new StreamReader(_assembly.GetManifestResourceStream("ORACLE_SQL_SERVER_Client.Resources.DDL_Extractor_Proc.txt")).ReadToEnd();
            }
            catch
            {
                MessageBox.Show("Error accessing resources!");
            }



            SqlConnection dataBaseConnection = dbConnection.getDatabaseConnection();
            SqlCommand command = new SqlCommand(query, dataBaseConnection);
            DataTable data = new DataTable();
            SqlDataReader reader;
            command.CommandText = query;
            command.CommandType = CommandType.Text;

            command.ExecuteNonQuery();


            query = "Execute sp_GetDDL '" + tableName + "';";

            command = new SqlCommand(query, dataBaseConnection);
            data = new DataTable();
            command.CommandText = query;
            command.CommandType = CommandType.Text;

            reader = command.ExecuteReader();
            data.Load(reader);

            foreach (DataRow row in data.Rows)
            {
                var ColumnData = row[0].ToString();
                this.richTextBox1.AppendText(ColumnData);
            }

            query = "DROP PROCEDURE [dbo].[sp_GetDDL] ;";

            command = new SqlCommand(query, dataBaseConnection);
            data = new DataTable();
            command.CommandText = query;
            command.CommandType = CommandType.Text;

            command.ExecuteNonQuery();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
