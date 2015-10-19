namespace ORACLE_SQL_SERVER_Client.Views
{
    partial class procedureViewerSQLServer
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
            this.richTextBox_DDL = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox_DDL
            // 
            this.richTextBox_DDL.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_DDL.Name = "richTextBox_DDL";
            this.richTextBox_DDL.Size = new System.Drawing.Size(417, 279);
            this.richTextBox_DDL.TabIndex = 1;
            this.richTextBox_DDL.Text = "";
            this.richTextBox_DDL.TextChanged += new System.EventHandler(this.richTextBox_DDL_TextChanged);
            // 
            // procedureViewerSQLServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 344);
            this.Controls.Add(this.richTextBox_DDL);
            this.Name = "procedureViewerSQLServer";
            this.Text = "procedureViewerSQLServer";
            this.Load += new System.EventHandler(this.procedureViewerSQLServer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_DDL;
    }
}