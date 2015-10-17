namespace ORACLE_SQL_SERVER_Client.Views
{
    partial class OracleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OracleView));
            this.OracleConsole = new System.Windows.Forms.RichTextBox();
            this.OracleResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ExecutionPlanButton = new System.Windows.Forms.Button();
            this.ExecuteQueryButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Username = new System.Windows.Forms.Label();
            this.DatabaseName = new System.Windows.Forms.Label();
            this.HostName = new System.Windows.Forms.Label();
            this.OracleObjects = new System.Windows.Forms.TreeView();
            this.ViewTableViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewTableView = new System.Windows.Forms.ToolStripMenuItem();
            this.AddColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.ProceduresFunctionsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.OracleResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ViewTableViewMenu.SuspendLayout();
            this.ProceduresFunctionsContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // OracleConsole
            // 
            this.OracleConsole.AcceptsTab = true;
            resources.ApplyResources(this.OracleConsole, "OracleConsole");
            this.OracleConsole.Name = "OracleConsole";
            // 
            // OracleResults
            // 
            this.OracleResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.OracleResults, "OracleResults");
            this.OracleResults.Name = "OracleResults";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisconnectButton);
            this.groupBox1.Controls.Add(this.RefreshButton);
            this.groupBox1.Controls.Add(this.ExecutionPlanButton);
            this.groupBox1.Controls.Add(this.ExecuteQueryButton);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // DisconnectButton
            // 
            resources.ApplyResources(this.DisconnectButton, "DisconnectButton");
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // RefreshButton
            // 
            resources.ApplyResources(this.RefreshButton, "RefreshButton");
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ExecutionPlanButton
            // 
            resources.ApplyResources(this.ExecutionPlanButton, "ExecutionPlanButton");
            this.ExecutionPlanButton.Name = "ExecutionPlanButton";
            this.ExecutionPlanButton.UseVisualStyleBackColor = true;
            this.ExecutionPlanButton.Click += new System.EventHandler(this.ExecutionPlanButton_Click);
            // 
            // ExecuteQueryButton
            // 
            resources.ApplyResources(this.ExecuteQueryButton, "ExecuteQueryButton");
            this.ExecuteQueryButton.Name = "ExecuteQueryButton";
            this.ExecuteQueryButton.UseVisualStyleBackColor = true;
            this.ExecuteQueryButton.Click += new System.EventHandler(this.ExecuteQueryButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Username);
            this.groupBox2.Controls.Add(this.DatabaseName);
            this.groupBox2.Controls.Add(this.HostName);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Username
            // 
            resources.ApplyResources(this.Username, "Username");
            this.Username.Name = "Username";
            // 
            // DatabaseName
            // 
            resources.ApplyResources(this.DatabaseName, "DatabaseName");
            this.DatabaseName.Name = "DatabaseName";
            // 
            // HostName
            // 
            resources.ApplyResources(this.HostName, "HostName");
            this.HostName.Name = "HostName";
            // 
            // OracleObjects
            // 
            this.OracleObjects.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.OracleObjects, "OracleObjects");
            this.OracleObjects.Name = "OracleObjects";
            this.OracleObjects.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("OracleObjects.Nodes")))});
            this.OracleObjects.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OracleObjects_MouseUp);
            // 
            // ViewTableViewMenu
            // 
            this.ViewTableViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewTableView,
            this.AddColumn});
            this.ViewTableViewMenu.Name = "ViewTableViewMenu";
            resources.ApplyResources(this.ViewTableViewMenu, "ViewTableViewMenu");
            // 
            // ViewTableView
            // 
            this.ViewTableView.Name = "ViewTableView";
            resources.ApplyResources(this.ViewTableView, "ViewTableView");
            this.ViewTableView.Click += new System.EventHandler(this.ViewTableView_Click);
            // 
            // AddColumn
            // 
            this.AddColumn.Name = "AddColumn";
            resources.ApplyResources(this.AddColumn, "AddColumn");
            this.AddColumn.Click += new System.EventHandler(this.AddColumn_Click);
            // 
            // ProceduresFunctionsContextMenu
            // 
            this.ProceduresFunctionsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.ProceduresFunctionsContextMenu.Name = "ViewTableView";
            resources.ApplyResources(this.ProceduresFunctionsContextMenu, "ProceduresFunctionsContextMenu");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // OracleView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OracleObjects);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OracleResults);
            this.Controls.Add(this.OracleConsole);
            this.Name = "OracleView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OracleView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.OracleResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ViewTableViewMenu.ResumeLayout(false);
            this.ProceduresFunctionsContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox OracleConsole;
        private System.Windows.Forms.DataGridView OracleResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button ExecutionPlanButton;
        private System.Windows.Forms.Button ExecuteQueryButton;
        private Controllers.OracleDBConnection dbConnection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label DatabaseName;
        private System.Windows.Forms.Label HostName;
        private System.Windows.Forms.TreeView OracleObjects;
        private System.Windows.Forms.ContextMenuStrip ViewTableViewMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewTableView;
        private System.Windows.Forms.ToolStripMenuItem AddColumn;
        private System.Windows.Forms.ContextMenuStrip ProceduresFunctionsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}