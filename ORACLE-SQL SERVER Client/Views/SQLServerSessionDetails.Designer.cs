namespace ORACLE_SQL_SERVER_Client.Views
{
    partial class SQLServerSessionDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectionValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionListing = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionListing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sessionListing);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 209);
            this.panel1.TabIndex = 0;
            // 
            // ConnectionValues
            // 
            this.ConnectionValues.HeaderText = "Values";
            this.ConnectionValues.Name = "ConnectionValues";
            this.ConnectionValues.ReadOnly = true;
            // 
            // ConnectionDetails
            // 
            this.ConnectionDetails.HeaderText = "Connection Details";
            this.ConnectionDetails.Name = "ConnectionDetails";
            this.ConnectionDetails.ReadOnly = true;
            // 
            // sessionListing
            // 
            this.sessionListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionListing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConnectionDetails,
            this.ConnectionValues});
            this.sessionListing.Location = new System.Drawing.Point(0, 5);
            this.sessionListing.Name = "sessionListing";
            this.sessionListing.Size = new System.Drawing.Size(252, 199);
            this.sessionListing.TabIndex = 0;
            // 
            // SQLServerSessionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 228);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SQLServerSessionDetails";
            this.Text = "SQLServerSessionDetails";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionListing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ORACLE_SQL_SERVER_Client.Controllers.SQLServerConnection dbConnection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView sessionListing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionValues;
    }
}