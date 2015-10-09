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

namespace ORACLE_SQL_SERVER_Client.Views
{
    public partial class PasswordForm : Form
    {
        public PasswordForm(string name, MainWindow window)
        {
            InitializeComponent();
            if (name == "OracleButton")
            {
                this.Text = "Oracle";
                this.ConnectionDetails1.Text = "SID";
                this.ConnectionDetails2.Text = "Username";
                this.ConnectionDetails3.Hide();
                this.ConnectionDetailsText3.Hide();
                this.ConnectionDetails4.Text = "Password";
            }
            else
            {
                this.Text = "SQL Server";
                this.ConnectionDetails1.Text = "Server Name";
                this.ConnectionDetails2.Text = "Database Name";
                this.ConnectionDetails3.Text = "Username";
                this.ConnectionDetails4.Text = "Password";
            }
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            if (this.ConnectionDetails1.Text == "Server Name")
            {
                SQLServerConnection databaseConnection = SQLServerConnection.getConnectionObject(this.ConnectionDetailsText1.Text,
                    this.ConnectionDetailsText2.Text, this.ConnectionDetailsText3.Text);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
