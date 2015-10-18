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
    public partial class SQLServerFileGroupData : Form
    {
        public SQLServerFileGroupData(SQLServerConnection connection)
        {
            InitializeComponent();
            this.dbConnection = connection;
            SqlConnection databaseConnection = connection.getDatabaseConnection();
            String query = "SELECT name AS FileName, CAST(FILEPROPERTY(name, 'SpaceUsed') AS INT) / 128.0 AS UsedSpaceMB, "
                         + " size/ 128.0 AS CurrentSizeMB, "
                         + " size/ 128.0 - CAST(FILEPROPERTY(name, 'SpaceUsed') AS INT) / 128.0 AS FreeSpaceMB "
                         + "  FROM dbo.sysfiles";

            SqlCommand command = new SqlCommand(query, databaseConnection);
            SqlDataReader reader;
            DataTable data = new DataTable();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            data.Load(reader);
            this.fileGroupData.DataSource = data;
            reader.Close();
        }
    }
}
