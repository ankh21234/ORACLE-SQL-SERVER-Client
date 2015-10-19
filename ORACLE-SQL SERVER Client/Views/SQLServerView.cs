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
            refreshInitialize();
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
                query = query.Remove(query.Length - 1);
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
                        reader.Close();
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
                    reader.Close();
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

        private void SQLServerObjects_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.SQLServerObjects.SelectedNode = this.SQLServerObjects.GetNodeAt(e.X, e.Y);
            }
        }

        private void ViewTableView_Click(object sender, EventArgs e)
        {

            TableViewerSQLServer tableViewer;
            String name = this.SQLServerObjects.SelectedNode.Text;
            if (this.SQLServerObjects.SelectedNode.Parent.Text == "VIEW")
            {
                tableViewer = new TableViewerSQLServer(name, dbConnection, true);
            }
            else
            {
                tableViewer = new TableViewerSQLServer(name, dbConnection, false);
            }
            tableViewer.ShowDialog();
        }


        private void refreshInitialize()
        {
            this.SQLServerObjects.Nodes[0].Nodes.Clear();
            this.SQLServerObjects.Nodes[0].Text = this.dbConnection.getDatabaseConnection().Database;
            SqlConnection dbConnection = this.dbConnection.getDatabaseConnection();

            String query = "SELECT NAME,TYPE_DESC FROM SYS.OBJECTS " +
                           " WHERE TYPE != 'IT' " +
                           " AND TYPE != 'S'  " +
                           " AND TYPE != 'SQ' " +
                           " AND TYPE != 'L'  " +
                           " AND TYPE != 'PC' " +
                           " AND TYPE != 'TA' " +
                           " AND TYPE != 'X'  " +
                           " AND TYPE != 'RF' " +
                           " AND TYPE != 'IF' " +
                           " AND TYPE != 'TT'";
            SqlCommand command = new SqlCommand(query, dbConnection);
            SqlDataReader reader;
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
                key = reader["TYPE_DESC"].ToString();
                value = reader["NAME"].ToString();
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
            reader.Close();

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
                    if (i == "USER_TABLE" || i == "VIEW")
                    {
                        subObjectNode.ContextMenuStrip = this.TableViewContextMenu;
                    }
                    if (i == "SQL_STORED_PROCEDURE")
                    {
                        subObjectNode.ContextMenuStrip = this.ProceduresFunctionsContextMenu;
                    }
                    objectNode.Nodes.Add(subObjectNode);

                }
                this.SQLServerObjects.Nodes[0].Nodes.Add(objectNode);
            }

            query = "SELECT sys.objects.name, sys.indexes.name AS IndexName, sys.indexes.type_desc FROM sys.indexes, sys.objects "
                    + "WHERE sys.indexes.object_id = sys.objects.object_id "
                    + "AND sys.objects.type = 'U'"
                    + "AND sys.indexes.name != ''";
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();

            TreeNode indexes = new TreeNode();
            indexes.Text = "INDEX";
            indexes.ForeColor = System.Drawing.Color.Black;
            while (reader.Read())
            {
                TreeNode indexNode = new TreeNode();
                indexNode.ForeColor = System.Drawing.Color.Black;
                indexes.Nodes.Add(reader["INDEXNAME"].ToString());
            }
            this.SQLServerObjects.Nodes[0].Nodes.Add(indexes);
            reader.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshInitialize();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            dbConnection.getDatabaseConnection().Close();
            new MainWindow().Show();
            this.Dispose();
        }

        private void sessionsButton_Click(object sender, EventArgs e)
        {
            new SQLServerSessionDetails(dbConnection).ShowDialog();
        }

        private void fileGroupButton_Click(object sender, EventArgs e)
        {
            new SQLServerFileGroupData(dbConnection).ShowDialog();
        }

        private void SQLServerView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ViewProceduresFunctions_Click(object sender, EventArgs e)
        {
            String tableName = this.SQLServerObjects.SelectedNode.Text;
            Views.procedureViewerSQLServer tableViewer = new procedureViewerSQLServer(tableName, dbConnection, false);
            tableViewer.ShowDialog();
        }

        private void dDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tableName = this.SQLServerObjects.SelectedNode.Text;
            Views.SQLServerDll tableViewer = new SQLServerDll(tableName, dbConnection, false);
            tableViewer.ShowDialog();
        }
    }
}