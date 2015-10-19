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
            this.dbConnection.createConnection();
            InitializeRefresh();
        }

        private void ExecuteQueryButton_Click(object sender, EventArgs e)
        {
            if (this.OracleConsole.Text != "")
            {
                String [] array;
                String query = this.OracleConsole.Text;
                String operation;
                String invalidOperation;
                OracleConnection dbConnection = this.dbConnection.getDatabaseConnection();
                query = query.Remove(query.Length - 1);
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
                        reader.Close();

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
            if (this.OracleConsole.Text.Split()[0] == "SELECT")
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
                    reader.Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
        }

        private void OracleObjects_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.OracleObjects.SelectedNode = this.OracleObjects.GetNodeAt(e.X, e.Y);
            }
        }

        private void ViewTableView_Click(object sender, EventArgs e)
        {
            String name = this.OracleObjects.SelectedNode.Text;
            TableViewerOracle tableViewer;
            if (this.OracleObjects.SelectedNode.Parent.Text == "VIEW" ||
                this.OracleObjects.SelectedNode.Parent.Text == "MATERIALIZED VIEW")
            {
                tableViewer = new TableViewerOracle(name, dbConnection, true);
            }
            else
            {
                tableViewer = new TableViewerOracle(name, dbConnection, false);
            }

            tableViewer.ShowDialog();
        }

        private void InitializeRefresh()
        {
            this.OracleObjects.Nodes[0].Nodes.Clear();

            this.OracleObjects.Nodes[0].Text = this.dbConnection.getDatabaseConnection().DataSource;
            OracleConnection dbConnection = this.dbConnection.getDatabaseConnection();

            String query = "SELECT OBJECT_NAME, OBJECT_TYPE FROM USER_OBJECTS";
            OracleCommand command = new OracleCommand(query, dbConnection);
            OracleDataReader reader;
            Dictionary<String, List<String>> dbObjects = new Dictionary<String, List<String>>();
            String key;
            String value;

            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            List<String> iterator;
            TreeNode objectNode;
            TreeNode subObjectNode;

            while (reader.Read())
            {
                key = reader["OBJECT_TYPE"].ToString();
                value = reader["OBJECT_NAME"].ToString();
                if (!dbObjects.ContainsKey(key))
                {
                    iterator = new List<String>();
                    iterator.Add(value);
                    dbObjects.Add(key, iterator);
                }
                else
                {
                    iterator = new List<String>(dbObjects[key]);
                    iterator.Add(value);
                    dbObjects[key] = iterator;
                }
            }

            foreach (String i in dbObjects.Keys)
            {
                objectNode = new TreeNode();
                objectNode.Text = i;
                objectNode.Name = i;
                objectNode.ForeColor = System.Drawing.Color.Black;
                List<String> childObjs = new List<String>(dbObjects[i]);
                foreach (String j in childObjs)
                {
                    subObjectNode = new TreeNode();
                    subObjectNode.Name = j;
                    subObjectNode.Text = j;
                    subObjectNode.ForeColor = System.Drawing.Color.Black;

                    if (i == "TABLE" || i == "VIEW" || i == "MATERIALIZED VIEW")
                    {
                        subObjectNode.ContextMenuStrip = this.ViewTableViewMenu;
                    }
                    if (i == "INDEX")
                    {
                        subObjectNode.ContextMenuStrip = this.IndexcontextMenuStrip; 
                    }
                    if (i == "PROCEDURE" || i == "TRIGGER" || i == "SEQUENCE")
                    {
                        subObjectNode.ContextMenuStrip = this.ProceduresFunctionsContextMenu; 
                    }

                    objectNode.Nodes.Add(subObjectNode);

                }
                this.OracleObjects.Nodes[0].Nodes.Add(objectNode);
                reader.Close();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            InitializeRefresh();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            dbConnection.getDatabaseConnection().Close();
            new MainWindow().Show();
            this.Dispose();
        }

        private void sessionsButton_Click(object sender, EventArgs e)
        {
            new OracleSessionDetails(dbConnection).ShowDialog();
        }

        private void tablespaceButton_Click(object sender, EventArgs e)
        {
            new OracleTableSpaceData(dbConnection).ShowDialog();
        }

        private void OracleView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String objectType = this.OracleObjects.SelectedNode.Parent.Text;
            String objectName = this.OracleObjects.SelectedNode.Text;
            new OracleDll(dbConnection, objectType, objectName).ShowDialog();


        }

        private void dDLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String objectType = this.OracleObjects.SelectedNode.Parent.Text;
            String objectName = this.OracleObjects.SelectedNode.Text;
            new OracleDll(dbConnection, objectType, objectName).ShowDialog();

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String objectName = this.OracleObjects.SelectedNode.Text;
            new OracleIndexes(dbConnection, objectName).ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String objectType = this.OracleObjects.SelectedNode.Parent.Text;
            String objectName = this.OracleObjects.SelectedNode.Text;
            new OracleDll(dbConnection, objectType, objectName).ShowDialog();
        }
    }
}
