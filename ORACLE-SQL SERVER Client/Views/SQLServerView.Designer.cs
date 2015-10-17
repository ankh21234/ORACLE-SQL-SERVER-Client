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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("INDEX");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Database", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.SQLServerConsole = new System.Windows.Forms.RichTextBox();
            this.SQLServerResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.ExecutionPlanButton = new System.Windows.Forms.Button();
            this.ExecuteQueryButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Username = new System.Windows.Forms.Label();
            this.DatabaseName = new System.Windows.Forms.Label();
            this.HostName = new System.Windows.Forms.Label();
            this.SQLServerObjects = new System.Windows.Forms.TreeView();
            this.TableViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewTableView = new System.Windows.Forms.ToolStripMenuItem();
            this.AddColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.ProceduresFunctionsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewProceduresFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcedureFunctionEdit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SQLServerResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TableViewContextMenu.SuspendLayout();
            this.ProceduresFunctionsContextMenu.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.disconnectButton);
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.ExecutionPlanButton);
            this.groupBox1.Controls.Add(this.ExecuteQueryButton);
            this.groupBox1.Location = new System.Drawing.Point(889, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // disconnectButton
            // 
            this.disconnectButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.disconnectButton.Location = new System.Drawing.Point(134, 49);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(88, 23);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.refreshButton.Location = new System.Drawing.Point(36, 49);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(92, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh Connection";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
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
            // SQLServerObjects
            // 
            this.SQLServerObjects.Location = new System.Drawing.Point(13, 13);
            this.SQLServerObjects.Name = "SQLServerObjects";
            treeNode5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            treeNode5.Name = "Node0";
            treeNode5.Text = "INDEX";
            treeNode6.ForeColor = System.Drawing.Color.Black;
            treeNode6.Name = "Database";
            treeNode6.Text = "Database";
            this.SQLServerObjects.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.SQLServerObjects.Size = new System.Drawing.Size(193, 667);
            this.SQLServerObjects.TabIndex = 6;
            this.SQLServerObjects.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SQLServerObjects_MouseUp);
            // 
            // TableViewContextMenu
            // 
            this.TableViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewTableView,
            this.AddColumn});
            this.TableViewContextMenu.Name = "TableViewContextMenu";
            this.TableViewContextMenu.Size = new System.Drawing.Size(141, 48);
            // 
            // ViewTableView
            // 
            this.ViewTableView.AutoToolTip = true;
            this.ViewTableView.Name = "ViewTableView";
            this.ViewTableView.Size = new System.Drawing.Size(140, 22);
            this.ViewTableView.Text = "View";
            this.ViewTableView.ToolTipText = "View table properties";
            this.ViewTableView.Click += new System.EventHandler(this.ViewTableView_Click);
            // 
            // AddColumn
            // 
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.Size = new System.Drawing.Size(140, 22);
            this.AddColumn.Text = "Add column";
            this.AddColumn.ToolTipText = "Add column to table";
            this.AddColumn.Click += new System.EventHandler(this.AddColumn_Click);
            // 
            // ProceduresFunctionsContextMenu
            // 
            this.ProceduresFunctionsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewProceduresFunctions,
            this.ProcedureFunctionEdit});
            this.ProceduresFunctionsContextMenu.Name = "ProceduresFunctionsContextMenu";
            this.ProceduresFunctionsContextMenu.Size = new System.Drawing.Size(100, 48);
            // 
            // ViewProceduresFunctions
            // 
            this.ViewProceduresFunctions.AutoToolTip = true;
            this.ViewProceduresFunctions.Name = "ViewProceduresFunctions";
            this.ViewProceduresFunctions.Size = new System.Drawing.Size(99, 22);
            this.ViewProceduresFunctions.Text = "View";
            this.ViewProceduresFunctions.ToolTipText = "View code contents";
            // 
            // ProcedureFunctionEdit
            // 
            this.ProcedureFunctionEdit.AutoToolTip = true;
            this.ProcedureFunctionEdit.Name = "ProcedureFunctionEdit";
            this.ProcedureFunctionEdit.Size = new System.Drawing.Size(99, 22);
            this.ProcedureFunctionEdit.Text = "Edit";
            this.ProcedureFunctionEdit.ToolTipText = "Edit code";
            // 
            // SQLServerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 692);
            this.Controls.Add(this.SQLServerObjects);
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
            this.TableViewContextMenu.ResumeLayout(false);
            this.ProceduresFunctionsContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox SQLServerConsole;
        private System.Windows.Forms.DataGridView SQLServerResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button ExecutionPlanButton;
        private System.Windows.Forms.Button ExecuteQueryButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label DatabaseName;
        private System.Windows.Forms.Label HostName;
        private ORACLE_SQL_SERVER_Client.Controllers.SQLServerConnection dbConnection;
        private System.Windows.Forms.TreeView SQLServerObjects;
        private System.Windows.Forms.ContextMenuStrip TableViewContextMenu;
        private System.Windows.Forms.ContextMenuStrip ProceduresFunctionsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewTableView;
        private System.Windows.Forms.ToolStripMenuItem AddColumn;
        private System.Windows.Forms.ToolStripMenuItem ViewProceduresFunctions;
        private System.Windows.Forms.ToolStripMenuItem ProcedureFunctionEdit;
    }
}