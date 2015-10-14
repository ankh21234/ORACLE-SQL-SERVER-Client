namespace ORACLE_SQL_SERVER_Client.Views
{
    partial class SQLServerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SQLServerConsole = new System.Windows.Forms.RichTextBox();
            this.SQLServerResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ExecutionPlanButton = new System.Windows.Forms.Button();
            this.ExecuteQueryButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Username = new System.Windows.Forms.Label();
            this.DatabaseName = new System.Windows.Forms.Label();
            this.HostName = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.SQLServerResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SQLServerConsole
            // 
            this.SQLServerConsole.AcceptsTab = true;
            this.SQLServerConsole.Location = new System.Drawing.Point(212, 13);
            this.SQLServerConsole.Name = "SQLServerConsole";
            this.SQLServerConsole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SQLServerConsole.Size = new System.Drawing.Size(668, 433);
            this.SQLServerConsole.TabIndex = 2;
            this.SQLServerConsole.Text = "";
            // 
            // SQLServerResults
            // 
            this.SQLServerResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SQLServerResults.Location = new System.Drawing.Point(212, 452);
            this.SQLServerResults.Name = "SQLServerResults";
            this.SQLServerResults.Size = new System.Drawing.Size(668, 228);
            this.SQLServerResults.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.ExecutionPlanButton);
            this.groupBox1.Controls.Add(this.ExecuteQueryButton);
            this.groupBox1.Location = new System.Drawing.Point(889, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // button4
            // 
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(134, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(36, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ExecutionPlanButton
            // 
            this.ExecutionPlanButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExecutionPlanButton.Location = new System.Drawing.Point(134, 20);
            this.ExecutionPlanButton.Name = "ExecutionPlanButton";
            this.ExecutionPlanButton.Size = new System.Drawing.Size(88, 23);
            this.ExecutionPlanButton.TabIndex = 1;
            this.ExecutionPlanButton.Text = "Execution Plan";
            this.ExecutionPlanButton.UseVisualStyleBackColor = true;
            this.ExecutionPlanButton.Click += new System.EventHandler(this.ExecutionPlanButton_Click);
            // 
            // ExecuteQueryButton
            // 
            this.ExecuteQueryButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExecuteQueryButton.Location = new System.Drawing.Point(36, 20);
            this.ExecuteQueryButton.Name = "ExecuteQueryButton";
            this.ExecuteQueryButton.Size = new System.Drawing.Size(92, 23);
            this.ExecuteQueryButton.TabIndex = 0;
            this.ExecuteQueryButton.Text = "Execute Query";
            this.ExecuteQueryButton.UseVisualStyleBackColor = true;
            this.ExecuteQueryButton.Click += new System.EventHandler(this.ExecuteQueryButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Username);
            this.groupBox2.Controls.Add(this.DatabaseName);
            this.groupBox2.Controls.Add(this.HostName);
            this.groupBox2.Location = new System.Drawing.Point(889, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 123);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SessionDetails";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Username.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Username.Location = new System.Drawing.Point(6, 64);
            this.Username.Name = "Username";
            this.Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Username.Size = new System.Drawing.Size(54, 24);
            this.Username.TabIndex = 2;
            this.Username.Text = "User:";
            // 
            // DatabaseName
            // 
            this.DatabaseName.AutoSize = true;
            this.DatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DatabaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DatabaseName.Location = new System.Drawing.Point(6, 40);
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.Size = new System.Drawing.Size(93, 24);
            this.DatabaseName.TabIndex = 1;
            this.DatabaseName.Text = "Database:";
            // 
            // HostName
            // 
            this.HostName.AutoSize = true;
            this.HostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.HostName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HostName.Location = new System.Drawing.Point(6, 16);
            this.HostName.Name = "HostName";
            this.HostName.Size = new System.Drawing.Size(58, 24);
            this.HostName.TabIndex = 0;
            this.HostName.Text = "Host: ";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(193, 667);
            this.treeView1.TabIndex = 6;
            // 
            // SQLServerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 692);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SQLServerResults);
            this.Controls.Add(this.SQLServerConsole);
            this.Name = "SQLServerView";
            this.Text = "SQLServerView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SQLServerView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SQLServerResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox SQLServerConsole;
        private System.Windows.Forms.DataGridView SQLServerResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ExecutionPlanButton;
        private System.Windows.Forms.Button ExecuteQueryButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label DatabaseName;
        private System.Windows.Forms.Label HostName;
        private ORACLE_SQL_SERVER_Client.Controllers.SQLServerConnection dbConnection;
        private System.Windows.Forms.TreeView treeView1;
    }
}