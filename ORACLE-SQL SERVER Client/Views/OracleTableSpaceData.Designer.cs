namespace ORACLE_SQL_SERVER_Client.Views
{
    partial class OracleTableSpaceData
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
            this.tableSpaceData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableSpaceData)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSpaceData
            // 
            this.tableSpaceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSpaceData.Location = new System.Drawing.Point(12, 10);
            this.tableSpaceData.Name = "tableSpaceData";
            this.tableSpaceData.Size = new System.Drawing.Size(430, 218);
            this.tableSpaceData.TabIndex = 1;
            // 
            // OracleTableSpaceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 239);
            this.Controls.Add(this.tableSpaceData);
            this.Name = "OracleTableSpaceData";
            this.Text = "OracleTableSpaceData";
            ((System.ComponentModel.ISupportInitialize)(this.tableSpaceData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableSpaceData;
        private ORACLE_SQL_SERVER_Client.Controllers.OracleDBConnection dbConnection;
    }
}