namespace ORACLE_SQL_SERVER_Client.Views
{
    partial class OracleIndexes
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
            this.indexList = new System.Windows.Forms.DataGridView();
            this.Characteristics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.indexList)).BeginInit();
            this.SuspendLayout();
            // 
            // indexList
            // 
            this.indexList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indexList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Characteristics,
            this.Value});
            this.indexList.Location = new System.Drawing.Point(13, 13);
            this.indexList.Name = "indexList";
            this.indexList.Size = new System.Drawing.Size(259, 301);
            this.indexList.TabIndex = 0;
            // 
            // Characteristics
            // 
            this.Characteristics.HeaderText = "Characteristitics";
            this.Characteristics.Name = "Characteristics";
            this.Characteristics.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Values";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // OracleIndexes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.indexList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OracleIndexes";
            this.Text = "OracleIndexes";
            ((System.ComponentModel.ISupportInitialize)(this.indexList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView indexList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Characteristics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private ORACLE_SQL_SERVER_Client.Controllers.OracleDBConnection dbConnection;
    }
}