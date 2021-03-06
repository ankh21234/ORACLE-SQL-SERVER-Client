﻿using System;
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
    public partial class TableViewerSQLServer : Form
    {
        public TableViewerSQLServer(String tableName, SQLServerConnection connection, bool option)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.dbConnection = connection;
            this.Text = tableName + "@" + dbConnection.getDatabaseConnection().Database;

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

            refreshInitialize();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = this.dbConnection.getDatabaseConnection();


            String query = "ALTER TABLE " + this.tableName + " " +
                "ADD " + this.columnNameText.Text + " " + this.dataType.Text;

            if (this.notNullCheckbox.Checked)
            {
                query += " NOT NULL ";
            }

            query.ToUpper();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandText = query;
            command.CommandType = CommandType.Text;

            try
            {
                command.ExecuteNonQuery();
                this.okText.Text = "Column added succesfully.";
                refreshInitialize();
                this.precisionText.Text = "";
                this.columnNameText.Text = "";
                this.dataType.ResetText();
            }
            catch (Exception error)
            {
                if (this.columnNameText.Text == "" || this.columnDataType.Text == "") 
                {
                    MessageBox.Show("Column name or data type fields are empty.");
                }
                else 
                {
                    MessageBox.Show(error.Message.ToString());
                }
            }
        }

        private void refreshInitialize()
        {
            String query = "SELECT COLUMN_NAME, IS_NULLABLE, DATA_TYPE, COLUMN_DEFAULT "
                         + "FROM INFORMATION_SCHEMA.COLUMNS "
                         + "WHERE TABLE_NAME = '" + this.tableName + "'";
            SqlConnection dataBaseConnection = dbConnection.getDatabaseConnection();
            SqlCommand command = new SqlCommand(query, dataBaseConnection);
            DataTable data = new DataTable();
            SqlDataReader reader;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            data.Load(reader);
            this.tableDetails.DataSource = data;
            reader.Close();
        }

        private void partitions()
        {
            String query = "SELECT PARTITION_NUMBER " 
                   + "FROM sys.partitions, sys.tables " 
                   + "WHERE sys.partitions.object_id = sys.tables.object_id " 
                   + "AND NAME = '" + this.tableName + "'";
            SqlConnection dataBaseConnection = dbConnection.getDatabaseConnection();
            SqlCommand command = new SqlCommand(query, dataBaseConnection);
            DataTable data = new DataTable();
            SqlDataReader reader;
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                this.tablePartitions.Text = reader["PARTITION_NUMBER"].ToString();
            }
            this.tablePartitions.Enabled = false;
            reader.Close();
        }
    }
}
