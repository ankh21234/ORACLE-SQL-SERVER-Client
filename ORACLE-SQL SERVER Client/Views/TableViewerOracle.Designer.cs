namespace ORACLE_SQL_SERVER_Client.Views
{
    partial class TableViewerOracle
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
            this.TableOptions = new System.Windows.Forms.TabControl();
            this.ViewTableViewAttributes = new System.Windows.Forms.TabPage();
            this.tableDetails = new System.Windows.Forms.DataGridView();
            this.TableAddColumn = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataType = new System.Windows.Forms.ComboBox();
            this.okText = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.notNullCheckbox = new System.Windows.Forms.CheckBox();
            this.columnNameText = new System.Windows.Forms.TextBox();
            this.columnDataType = new System.Windows.Forms.Label();
            this.columnNameLabel = new System.Windows.Forms.Label();
            this.precision = new System.Windows.Forms.TextBox();
            this.precisionLabel = new System.Windows.Forms.Label();
            this.TableOptions.SuspendLayout();
            this.ViewTableViewAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDetails)).BeginInit();
            this.TableAddColumn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableOptions
            // 
            this.TableOptions.Controls.Add(this.ViewTableViewAttributes);
            this.TableOptions.Controls.Add(this.TableAddColumn);
            this.TableOptions.Location = new System.Drawing.Point(4, 1);
            this.TableOptions.Name = "TableOptions";
            this.TableOptions.SelectedIndex = 0;
            this.TableOptions.Size = new System.Drawing.Size(560, 321);
            this.TableOptions.TabIndex = 1;
            // 
            // ViewTableViewAttributes
            // 
            this.ViewTableViewAttributes.Controls.Add(this.tableDetails);
            this.ViewTableViewAttributes.Location = new System.Drawing.Point(4, 22);
            this.ViewTableViewAttributes.Name = "ViewTableViewAttributes";
            this.ViewTableViewAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.ViewTableViewAttributes.Size = new System.Drawing.Size(552, 295);
            this.ViewTableViewAttributes.TabIndex = 0;
            this.ViewTableViewAttributes.Text = "View";
            this.ViewTableViewAttributes.UseVisualStyleBackColor = true;
            // 
            // tableDetails
            // 
            this.tableDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDetails.Location = new System.Drawing.Point(0, 0);
            this.tableDetails.Name = "tableDetails";
            this.tableDetails.Size = new System.Drawing.Size(551, 300);
            this.tableDetails.TabIndex = 0;
            // 
            // TableAddColumn
            // 
            this.TableAddColumn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TableAddColumn.Controls.Add(this.panel1);
            this.TableAddColumn.Location = new System.Drawing.Point(4, 22);
            this.TableAddColumn.Name = "TableAddColumn";
            this.TableAddColumn.Padding = new System.Windows.Forms.Padding(3);
            this.TableAddColumn.Size = new System.Drawing.Size(552, 295);
            this.TableAddColumn.TabIndex = 1;
            this.TableAddColumn.Text = "Add Column";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.precisionLabel);
            this.panel1.Controls.Add(this.precision);
            this.panel1.Controls.Add(this.dataType);
            this.panel1.Controls.Add(this.okText);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.notNullCheckbox);
            this.panel1.Controls.Add(this.columnNameText);
            this.panel1.Controls.Add(this.columnDataType);
            this.panel1.Controls.Add(this.columnNameLabel);
            this.panel1.Location = new System.Drawing.Point(102, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 197);
            this.panel1.TabIndex = 3;
            // 
            // dataType
            // 
            this.dataType.FormattingEnabled = true;
            this.dataType.Items.AddRange(new object[] {
            "NUMBER",
            "INTEGER",
            "DATE",
            "VARCHAR",
            "VARCHAR2",
            "TIMESTAMP",
            "CLOB",
            "BLOB",
            "FLOAT"});
            this.dataType.Location = new System.Drawing.Point(122, 65);
            this.dataType.Name = "dataType";
            this.dataType.Size = new System.Drawing.Size(191, 21);
            this.dataType.TabIndex = 12;
            this.dataType.SelectedIndexChanged += new System.EventHandler(this.dataType_SelectedIndexChanged);
            // 
            // okText
            // 
            this.okText.AutoSize = true;
            this.okText.ForeColor = System.Drawing.Color.Green;
            this.okText.Location = new System.Drawing.Point(36, 131);
            this.okText.Name = "okText";
            this.okText.Size = new System.Drawing.Size(0, 13);
            this.okText.TabIndex = 11;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(239, 142);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // notNullCheckbox
            // 
            this.notNullCheckbox.AutoSize = true;
            this.notNullCheckbox.Location = new System.Drawing.Point(57, 142);
            this.notNullCheckbox.Name = "notNullCheckbox";
            this.notNullCheckbox.Size = new System.Drawing.Size(64, 17);
            this.notNullCheckbox.TabIndex = 7;
            this.notNullCheckbox.Text = "Not Null";
            this.notNullCheckbox.UseVisualStyleBackColor = true;
            // 
            // columnNameText
            // 
            this.columnNameText.Location = new System.Drawing.Point(122, 33);
            this.columnNameText.Name = "columnNameText";
            this.columnNameText.Size = new System.Drawing.Size(191, 20);
            this.columnNameText.TabIndex = 2;
            // 
            // columnDataType
            // 
            this.columnDataType.AutoSize = true;
            this.columnDataType.Location = new System.Drawing.Point(33, 65);
            this.columnDataType.Name = "columnDataType";
            this.columnDataType.Size = new System.Drawing.Size(57, 13);
            this.columnDataType.TabIndex = 1;
            this.columnDataType.Text = "Data Type";
            // 
            // columnNameLabel
            // 
            this.columnNameLabel.AutoSize = true;
            this.columnNameLabel.Location = new System.Drawing.Point(33, 36);
            this.columnNameLabel.Name = "columnNameLabel";
            this.columnNameLabel.Size = new System.Drawing.Size(73, 13);
            this.columnNameLabel.TabIndex = 0;
            this.columnNameLabel.Text = "Column Name";
            // 
            // precision
            // 
            this.precision.Location = new System.Drawing.Point(122, 93);
            this.precision.Name = "precision";
            this.precision.Size = new System.Drawing.Size(191, 20);
            this.precision.TabIndex = 13;
            // 
            // precisionLabel
            // 
            this.precisionLabel.AutoSize = true;
            this.precisionLabel.Location = new System.Drawing.Point(33, 96);
            this.precisionLabel.Name = "precisionLabel";
            this.precisionLabel.Size = new System.Drawing.Size(50, 13);
            this.precisionLabel.TabIndex = 14;
            this.precisionLabel.Text = "Precision";
            // 
            // TableViewerOracle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 323);
            this.Controls.Add(this.TableOptions);
            this.Name = "TableViewerOracle";
            this.Text = "TableViewerOracle";
            this.TableOptions.ResumeLayout(false);
            this.ViewTableViewAttributes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDetails)).EndInit();
            this.TableAddColumn.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TableOptions;
        private System.Windows.Forms.TabPage ViewTableViewAttributes;
        private System.Windows.Forms.DataGridView tableDetails;
        private System.Windows.Forms.TabPage TableAddColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label okText;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.CheckBox notNullCheckbox;
        private System.Windows.Forms.TextBox columnNameText;
        private System.Windows.Forms.Label columnDataType;
        private System.Windows.Forms.Label columnNameLabel;
        private ORACLE_SQL_SERVER_Client.Controllers.OracleDBConnection dbConnection;
        private string tableName;
        private System.Windows.Forms.ComboBox dataType;
        private System.Windows.Forms.TextBox precision;
        public System.Windows.Forms.Label precisionLabel;
    }
}