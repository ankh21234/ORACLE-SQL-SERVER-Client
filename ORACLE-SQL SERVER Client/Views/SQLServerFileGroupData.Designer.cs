namespace ORACLE_SQL_SERVER_Client.Views
{
    partial class SQLServerFileGroupData
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
            this.fileGroupData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fileGroupData)).BeginInit();
            this.SuspendLayout();
            // 
            // fileGroupData
            // 
            this.fileGroupData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileGroupData.Location = new System.Drawing.Point(13, 13);
            this.fileGroupData.Name = "fileGroupData";
            this.fileGroupData.Size = new System.Drawing.Size(430, 218);
            this.fileGroupData.TabIndex = 0;
            // 
            // SQLServerFileGroupData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 243);
            this.Controls.Add(this.fileGroupData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SQLServerFileGroupData";
            this.Text = "SQLServerFileGroupData";
            ((System.ComponentModel.ISupportInitialize)(this.fileGroupData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fileGroupData;
        private ORACLE_SQL_SERVER_Client.Controllers.SQLServerConnection dbConnection;

    }
}