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
    public partial class OracleTableSpaceData : Form
    {
        public OracleTableSpaceData(OracleDBConnection connection)
        {
            InitializeComponent();
            this.dbConnection = connection;
            OracleConnection databaseConnection = connection.getDatabaseConnection();
            String query = "SELECT ts.TABLESPACE_NAME, "
                                + "TO_CHAR(SUM(NVL(fs.bytes, 0)) / 1024 / 1024, '99,999,990.99') AS MB_FREE "
                                + "FROM "
                                + "USER_FREE_SPACE fs, "
                                + "USER_TABLESPACES ts, "
                                + "USER_USERS us "
                                + "WHERE fs.TABLESPACE_NAME(+) = ts.TABLESPACE_NAME "
                                + "GROUP BY ts.tablespace_name";

            OracleCommand command = new OracleCommand(query, databaseConnection);
            OracleDataReader reader;
            DataTable data = new DataTable();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            data.Load(reader);
            this.tableSpaceData.DataSource = data;
            reader.Close();
    }
    }
}
