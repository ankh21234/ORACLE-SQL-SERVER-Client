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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("INDEX");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Database", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.SQLServerConsole = new System.Windows.Forms.RichTextBox();
            this.SQLServerResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.ExecutionPlanButton = new System.Windows.Forms.Button();
            this.ExecuteQueryButton = new System.Windows.Forms.Button();
            this.SQLServerObjects = new System.Windows.Forms.TreeView();
            this.TableViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewTableView = new System.Windows.Forms.ToolStripMenuItem();
            this.dDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProceduresFunctionsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewProceduresFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.extraOptions = new System.Windows.Forms.GroupBox();
            this.fileGroupButton = new System.Windows.Forms.Button();
            this.sessionsButton = new System.Windows.Forms.Button();
            this.SqlServerImage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SQLServerResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TableViewContextMenu.SuspendLayout();
            this.ProceduresFunctionsContextMenu.SuspendLayout();
            this.extraOptions.SuspendLayout();
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
            // SQLServerObjects
            // 
            this.SQLServerObjects.Location = new System.Drawing.Point(13, 13);
            this.SQLServerObjects.Name = "SQLServerObjects";
            treeNode1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            treeNode1.Name = "Node0";
            treeNode1.Text = "INDEX";
            treeNode2.ForeColor = System.Drawing.Color.Black;
            treeNode2.Name = "Database";
            treeNode2.Text = "Database";
            this.SQLServerObjects.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.SQLServerObjects.Size = new System.Drawing.Size(193, 667);
            this.SQLServerObjects.TabIndex = 6;
            this.SQLServerObjects.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SQLServerObjects_MouseUp);
            // 
            // TableViewContextMenu
            // 
            this.TableViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewTableView,
            this.dDLToolStripMenuItem});
            this.TableViewContextMenu.Name = "TableViewContextMenu";
            this.TableViewContextMenu.Size = new System.Drawing.Size(100, 48);
            // 
            // ViewTableView
            // 
            this.ViewTableView.AutoToolTip = true;
            this.ViewTableView.Name = "ViewTableView";
            this.ViewTableView.Size = new System.Drawing.Size(99, 22);
            this.ViewTableView.Text = "View";
            this.ViewTableView.ToolTipText = "View table properties";
            this.ViewTableView.Click += new System.EventHandler(this.ViewTableView_Click);
            // 
            // dDLToolStripMenuItem
            // 
            this.dDLToolStripMenuItem.Name = "dDLToolStripMenuItem";
            this.dDLToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.dDLToolStripMenuItem.Text = "DDL";
            this.dDLToolStripMenuItem.Click += new System.EventHandler(this.dDLToolStripMenuItem_Click);
            // 
            // ProceduresFunctionsContextMenu
            // 
            this.ProceduresFunctionsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewProceduresFunctions});
            this.ProceduresFunctionsContextMenu.Name = "ProceduresFunctionsContextMenu";
            this.ProceduresFunctionsContextMenu.Size = new System.Drawing.Size(97, 26);
            // 
            // ViewProceduresFunctions
            // 
            this.ViewProceduresFunctions.AutoToolTip = true;
            this.ViewProceduresFunctions.Name = "ViewProceduresFunctions";
            this.ViewProceduresFunctions.Size = new System.Drawing.Size(96, 22);
            this.ViewProceduresFunctions.Text = "DDL";
            this.ViewProceduresFunctions.ToolTipText = "View code contents";
            this.ViewProceduresFunctions.Click += new System.EventHandler(this.ViewProceduresFunctions_Click);
            // 
            // extraOptions
            // 
            this.extraOptions.Controls.Add(this.fileGroupButton);
            this.extraOptions.Controls.Add(this.sessionsButton);
            this.extraOptions.Location = new System.Drawing.Point(889, 120);
            this.extraOptions.Name = "extraOptions";
            this.extraOptions.Size = new System.Drawing.Size(264, 75);
            this.extraOptions.TabIndex = 7;
            this.extraOptions.TabStop = false;
            this.extraOptions.Text = "Extra Options";
            // 
            // fileGroupButton
            // 
            this.fileGroupButton.Location = new System.Drawing.Point(134, 36);
            this.fileGroupButton.Name = "fileGroupButton";
            this.fileGroupButton.Size = new System.Drawing.Size(92, 23);
            this.fileGroupButton.TabIndex = 1;
            this.fileGroupButton.Text = "File Group Data";
            this.fileGroupButton.UseVisualStyleBackColor = true;
            this.fileGroupButton.Click += new System.EventHandler(this.fileGroupButton_Click);
            // 
            // sessionsButton
            // 
            this.sessionsButton.Location = new System.Drawing.Point(36, 36);
            this.sessionsButton.Name = "sessionsButton";
            this.sessionsButton.Size = new System.Drawing.Size(92, 23);
            this.sessionsButton.TabIndex = 0;
            this.sessionsButton.Text = "Session Data";
            this.sessionsButton.UseVisualStyleBackColor = true;
            this.sessionsButton.Click += new System.EventHandler(this.sessionsButton_Click);
            // 
            // SqlServerImage
            // 
            this.SqlServerImage.BackgroundImage = global::ORACLE_SQL_SERVER_Client.Properties.Resources.SqlServerIcon;
            this.SqlServerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SqlServerImage.Location = new System.Drawing.Point(889, 422);
            this.SqlServerImage.Name = "SqlServerImage";
            this.SqlServerImage.Size = new System.Drawing.Size(283, 258);
            this.SqlServerImage.TabIndex = 8;
            // 
            // SQLServerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 692);
            this.Controls.Add(this.SqlServerImage);
            this.Controls.Add(this.extraOptions);
            this.Controls.Add(this.SQLServerObjects);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SQLServerResults);
            this.Controls.Add(this.SQLServerConsole);
            this.Name = "SQLServerView";
            this.Text = "SQLServerView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SQLServerView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SQLServerResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.TableViewContextMenu.ResumeLayout(false);
            this.ProceduresFunctionsContextMenu.ResumeLayout(false);
            this.extraOptions.ResumeLayout(false);
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
        private ORACLE_SQL_SERVER_Client.Controllers.SQLServerConnection dbConnection;
        private System.Windows.Forms.TreeView SQLServerObjects;
        private System.Windows.Forms.ContextMenuStrip TableViewContextMenu;
        private System.Windows.Forms.ContextMenuStrip ProceduresFunctionsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewTableView;
        private System.Windows.Forms.ToolStripMenuItem ViewProceduresFunctions;
        private System.Windows.Forms.GroupBox extraOptions;
        private System.Windows.Forms.Button fileGroupButton;
        private System.Windows.Forms.Button sessionsButton;
        private System.Windows.Forms.Panel SqlServerImage;
        private System.Windows.Forms.ToolStripMenuItem dDLToolStripMenuItem;
    }
}