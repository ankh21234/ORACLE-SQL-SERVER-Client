namespace ORACLE_SQL_SERVER_Client.Views
{
    partial class OracleSessionDetails
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
            this.sessionListing = new System.Windows.Forms.DataGridView();
            this.ConnectionDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sessionListing)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionListing
            // 
            this.sessionListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionListing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConnectionDetails,
            this.ConnectionValues});
            this.sessionListing.Location = new System.Drawing.Point(12, 13);
            this.sessionListing.Name = "sessionListing";
            this.sessionListing.Size = new System.Drawing.Size(303, 244);
            this.sessionListing.TabIndex = 1;
            // 
            // ConnectionDetails
            // 
            this.ConnectionDetails.HeaderText = "Connection Details";
            this.ConnectionDetails.Name = "ConnectionDetails";
            this.ConnectionDetails.ReadOnly = true;
            // 
            // ConnectionValues
            // 
            this.ConnectionValues.HeaderText = "Values";
            this.ConnectionValues.Name = "ConnectionValues";
            this.ConnectionValues.ReadOnly = true;
            // 
            // OracleSessionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 269);
            this.Controls.Add(this.sessionListing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OracleSessionDetails";
            this.Text = "OracleSessionDetails";
            ((System.ComponentModel.ISupportInitialize)(this.sessionListing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sessionListing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionValues;
        private ORACLE_SQL_SERVER_Client.Controllers.OracleDBConnection dbConnection;
    }
}