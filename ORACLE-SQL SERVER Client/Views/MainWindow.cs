using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ORACLE_SQL_SERVER_Client.Views;

namespace ORACLE_SQL_SERVER_Client
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void OracleButton_Click(object sender, EventArgs e)
        {
            new PasswordForm(this.OracleButton.Name, this).Show();
            this.Hide();
        }

        private void MainWindowContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SQLServerButton_Click(object sender, EventArgs e)
        {
            new PasswordForm(this.SQLServerButton.Name,this).Show();
            this.Hide();
        }
    }
}
