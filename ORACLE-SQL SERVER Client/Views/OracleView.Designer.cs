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
            this.OracleObjects = new System.Windows.Forms.TreeView();
            this.ViewTableViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewTableView = new System.Windows.Forms.ToolStripMenuItem();
            this.dDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProceduresFunctionsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extraOptions = new System.Windows.Forms.GroupBox();
            this.tablespaceButton = new System.Windows.Forms.Button();
            this.sessionsButton = new System.Windows.Forms.Button();
            this.SqlServerImage = new System.Windows.Forms.Panel();
            this.IndexcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.OracleResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ViewTableViewMenu.SuspendLayout();
            this.ProceduresFunctionsContextMenu.SuspendLayout();
            this.extraOptions.SuspendLayout();
            this.IndexcontextMenuStrip.SuspendLayout();
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
            this.dDLToolStripMenuItem});
            this.ViewTableViewMenu.Name = "ViewTableViewMenu";
            resources.ApplyResources(this.ViewTableViewMenu, "ViewTableViewMenu");
            // 
            // ViewTableView
            // 
            this.ViewTableView.Name = "ViewTableView";
            resources.ApplyResources(this.ViewTableView, "ViewTableView");
            this.ViewTableView.Click += new System.EventHandler(this.ViewTableView_Click);
            // 
            // dDLToolStripMenuItem
            // 
            this.dDLToolStripMenuItem.Name = "dDLToolStripMenuItem";
            resources.ApplyResources(this.dDLToolStripMenuItem, "dDLToolStripMenuItem");
            this.dDLToolStripMenuItem.Click += new System.EventHandler(this.dDLToolStripMenuItem_Click);
            // 
            // ProceduresFunctionsContextMenu
            // 
            this.ProceduresFunctionsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.ProceduresFunctionsContextMenu.Name = "ViewTableView";
            resources.ApplyResources(this.ProceduresFunctionsContextMenu, "ProceduresFunctionsContextMenu");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // extraOptions
            // 
            this.extraOptions.Controls.Add(this.tablespaceButton);
            this.extraOptions.Controls.Add(this.sessionsButton);
            resources.ApplyResources(this.extraOptions, "extraOptions");
            this.extraOptions.Name = "extraOptions";
            this.extraOptions.TabStop = false;
            // 
            // tablespaceButton
            // 
            resources.ApplyResources(this.tablespaceButton, "tablespaceButton");
            this.tablespaceButton.Name = "tablespaceButton";
            this.tablespaceButton.UseVisualStyleBackColor = true;
            this.tablespaceButton.Click += new System.EventHandler(this.tablespaceButton_Click);
            // 
            // sessionsButton
            // 
            resources.ApplyResources(this.sessionsButton, "sessionsButton");
            this.sessionsButton.Name = "sessionsButton";
            this.sessionsButton.UseVisualStyleBackColor = true;
            this.sessionsButton.Click += new System.EventHandler(this.sessionsButton_Click);
            // 
            // SqlServerImage
            // 
            this.SqlServerImage.BackgroundImage = global::ORACLE_SQL_SERVER_Client.Properties.Resources.Oraclelogo;
            resources.ApplyResources(this.SqlServerImage, "SqlServerImage");
            this.SqlServerImage.Name = "SqlServerImage";
            // 
            // IndexcontextMenuStrip
            // 
            this.IndexcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.dDLToolStripMenuItem1});
            this.IndexcontextMenuStrip.Name = "IndexcontextMenuStrip";
            resources.ApplyResources(this.IndexcontextMenuStrip, "IndexcontextMenuStrip");
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // dDLToolStripMenuItem1
            // 
            this.dDLToolStripMenuItem1.Name = "dDLToolStripMenuItem1";
            resources.ApplyResources(this.dDLToolStripMenuItem1, "dDLToolStripMenuItem1");
            this.dDLToolStripMenuItem1.Click += new System.EventHandler(this.dDLToolStripMenuItem1_Click);
            // 
            // OracleView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SqlServerImage);
            this.Controls.Add(this.extraOptions);
            this.Controls.Add(this.OracleObjects);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OracleResults);
            this.Controls.Add(this.OracleConsole);
            this.Name = "OracleView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OracleView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.OracleResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ViewTableViewMenu.ResumeLayout(false);
            this.ProceduresFunctionsContextMenu.ResumeLayout(false);
            this.extraOptions.ResumeLayout(false);
            this.IndexcontextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.TreeView OracleObjects;
        private System.Windows.Forms.ContextMenuStrip ViewTableViewMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewTableView;
        private System.Windows.Forms.ContextMenuStrip ProceduresFunctionsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox extraOptions;
        private System.Windows.Forms.Button tablespaceButton;
        private System.Windows.Forms.Button sessionsButton;
        private System.Windows.Forms.Panel SqlServerImage;
        private System.Windows.Forms.ToolStripMenuItem dDLToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip IndexcontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem dDLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    }
}