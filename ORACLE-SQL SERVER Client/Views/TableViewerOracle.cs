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
    public partial class TableViewerOracle : Form
    {
        public TableViewerOracle(String tableName, OracleDBConnection connection, bool option)
        {
            InitializeComponent();
            this.dbConnection = connection;
            this.tableName = tableName;
            if (option)
            {
                this.TableOptions.TabPages.Remove(TableAddColumn);
                this.partitionNumber.Dispose();
                this.tablePartitions.Dispose();
            }
            else
            {
                partitions();
            }
            refreshInitializeTable();

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            OracleConnection connection = this.dbConnection.getDatabaseConnection();
            String query;
           
            if (dataType.Text == "BLOB" || dataType.Text == "CLOB" || dataType.Text == "DATE" 
                || dataType.Text == "BFILE")
            {
                    query = "ALTER TABLE " + this.tableName + " " +
                    "ADD " + this.columnNameText.Text + " " + this.dataType.Text;
            }
            else
            {
                    query = "ALTER TABLE " + this.tableName + " " +
                    "ADD " + this.columnNameText.Text + " " + this.dataType.Text + "(" + this.precisionText.Text + ")";
            }


            if (this.notNullCheckbox.Checked)
            {
                query += " NOT NULL ";
            }

            query.ToUpper();
            OracleCommand command = new OracleCommand(query, connection);
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            Console.WriteLine(query);

            try
            {
                command.ExecuteNonQuery();
                this.okText.Text = "Column added succesfully.";
                refreshInitializeTable();
                this.precisionText.Text = "";
                this.columnNameText.Text = "";
                this.dataType.ResetText();
            }
            catch (Exception error)
            {
                if (this.columnNameText.Text == "" || this.precisionText.Text == "")
                {
                    MessageBox.Show("Column name or data type fields are empty.");
                }
                else
                {
                    MessageBox.Show(error.Message.ToString());
                }
            }
        }

        private void dataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataType.Text == "BLOB" || dataType.Text == "CLOB" || dataType.Text == "DATE" || 
                dataType.Text == "BFILE")
            {
                this.precisionText.Enabled = false;
            }
            else
            {
                this.precisionText.Enabled = true;
            }
        }

        private void refreshInitializeTable()
        {
            String query = "SELECT COLUMN_NAME, DATA_TYPE, NULLABLE, DATA_DEFAULT "
            + "FROM USER_TAB_COLUMNS "
            + "WHERE TABLE_NAME = '" + this.tableName + "'";
            OracleConnection dataBaseConnection = dbConnection.getDatabaseConnection();
            OracleCommand command = new OracleCommand(query, dataBaseConnection);
            DataTable data = new DataTable();
            OracleDataReader reader;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            data.Load(reader);
            this.tableDetails.DataSource = data;
            reader.Close();
        }

        private void partitions()
        {
            String query = "SELECT PARTITION_COUNT FROM USER_PART_TABLES "
            + "WHERE TABLE_NAME = '" + this.tableName + "'";
            OracleConnection dataBaseConnection = dbConnection.getDatabaseConnection();
            OracleCommand command = new OracleCommand(query, dataBaseConnection);
            DataTable data = new DataTable();
            OracleDataReader reader;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.tablePartitions.Text = reader["PARTITION_COUNT"].ToString();  
            }
            this.tablePartitions.Enabled = false;
            reader.Close();

        }
    }
}

