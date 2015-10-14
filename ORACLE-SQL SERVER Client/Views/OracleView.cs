using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORACLE_SQL_SERVER_Client.Controllers;
using Oracle.ManagedDataAccess.Client;


namespace ORACLE_SQL_SERVER_Client.Views
{
    public partial class OracleView : Form
    {
        public OracleView(OracleDBConnection connection)
        {
            InitializeComponent();
            this.dbConnection = connection;
            this.DatabaseName.Text += " " + connection.getDatabaseConnection().DataSource;
            this.HostName.Text += " " +connection.getDatabaseConnection().HostName;
            this.Username.Text += " " + connection.getUsername();


        }

        private void ExecuteQueryButton_Click(object sender, EventArgs e)
        {
            if (this.OracleConsole.Text != "")
            {
                String [] array;
                String query = this.OracleConsole.Text;
                String operation;
                String invalidOperation;
                this.dbConnection.createConnection();
                OracleConnection dbConnection = this.dbConnection.getDatabaseConnection();
                query.ToUpper();
                OracleCommand command = new OracleCommand(query, dbConnection);
                OracleDataReader reader;
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
                        this.OracleResults.DataSource = data;

                    }

                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message.ToString());
                    }
                else if(operation == "DROP") 
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
            String query = "EXPLAIN PLAN SET statement_id = 'ex_plan' FOR " + this.OracleConsole.Text;
            OracleConnection dbConnection = this.dbConnection.getDatabaseConnection();
            OracleCommand command = new OracleCommand(query, dbConnection);
            OracleDataReader reader;
            DataTable data = new DataTable();
            try
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                query = "SELECT * FROM TABLE(DBMS_XPLAN.display)";
                command.CommandText = query;
                reader = command.ExecuteReader();
                data.Load(reader);
                this.OracleResults.DataSource = data;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void OracleView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
