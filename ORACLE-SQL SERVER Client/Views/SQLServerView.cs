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
    public partial class SQLServerView : Form
    {
        public SQLServerView(SQLServerConnection connection)
        {
            InitializeComponent();
            this.dbConnection = connection;
            this.HostName.Text += connection.getServerName();
            this.DatabaseName.Text += connection.getDatabaseConnection().Database;
            this.Username.Text += connection.getUsername();


        }

        private void SQLServerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ExecuteQueryButton_Click(object sender, EventArgs e)
        {
            if (this.SQLServerConsole.Text != "")
            {
                String[] array;
                String query = this.SQLServerConsole.Text;
                String operation;
                this.dbConnection.createConnection();
                SqlConnection dbConnection = this.dbConnection.getDatabaseConnection();
                query.ToUpper();
                SqlCommand command = new SqlCommand(query, dbConnection);
                SqlDataReader reader;
                DataTable data = new DataTable();
                array = query.Split();
                operation = array[0];
                if (operation == "SELECT")
                    try
                    {
                        command.CommandText = query;
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                        data.Load(reader);
                        this.SQLServerResults.DataSource = data;

                    }

                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message.ToString());
                    }
                else if (operation == "DROP")
                {
                    MessageBox.Show("This action is not allowed.");
                }
                else
                {
                    try
                    {
                        command.CommandText = query;
                        command.CommandType = CommandType.Text;
                        int rows = command.ExecuteNonQuery();
                        MessageBox.Show("Query Ok. " + rows.ToString() + " rows were affected");
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message.ToString());
                        Console.WriteLine(error);
                    }
                }

            }
        }
        private void ExecutionPlanButton_Click(object sender, EventArgs e)
        {
            if (this.SQLServerConsole.Text.Split()[0] == "SELECT")
            {
                String query = "EXPLAIN PLAN SET statement_id = 'ex_plan' FOR " + this.SQLServerResults.Text;
                SqlConnection dbConnection = this.dbConnection.getDatabaseConnection();
                SqlCommand command = new SqlCommand(query, dbConnection);
                query = "SET SHOWPLAN_ALL ON";
                SqlDataReader reader;
                DataTable data = new DataTable();
                try
                {
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    query = this.SQLServerConsole.Text;
                    command.CommandText = query;
                    reader = command.ExecuteReader();
                    data.Load(reader);
                    this.SQLServerResults.DataSource = data;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message.ToString());
                }
                query = "SET SHOWPLAN_ALL OFF";
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
        }
    }
}
