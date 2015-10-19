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
    public partial class SQLServerIndexViewer : Form
    {
        private SQLServerConnection dbConnection;
        private string tableName;

        public SQLServerIndexViewer(String tableName, SQLServerConnection connection, bool option)
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
                query = new StreamReader(_assembly.GetManifestResourceStream("ORACLE_SQL_SERVER_Client.Resources.getindex.txt")).ReadToEnd();
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
            command.Parameters.Add("@indexName", SqlDbType.VarChar);
            command.Parameters["@indexName"].Value = tableName;

            reader = command.ExecuteReader();

            data.Load(reader);

            this.dataGridView1.DataSource = data;



            

        }
    }
}
