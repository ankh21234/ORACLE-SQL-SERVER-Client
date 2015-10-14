namespace ORACLE_SQL_SERVER_Client
{
    partial class MainWindow
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
            this.MainWindowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SQLServerButton = new System.Windows.Forms.Button();
            this.OracleButton = new System.Windows.Forms.Button();
            this.MainWindowContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowContainer
            // 
            this.MainWindowContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainWindowContainer.Controls.Add(this.SQLServerButton);
            this.MainWindowContainer.Controls.Add(this.OracleButton);
            this.MainWindowContainer.Location = new System.Drawing.Point(26, 67);
            this.MainWindowContainer.Name = "MainWindowContainer";
            this.MainWindowContainer.Size = new System.Drawing.Size(462, 108);
            this.MainWindowContainer.TabIndex = 0;
            this.MainWindowContainer.UseWaitCursor = true;
            this.MainWindowContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindowContainer_Paint);
            // 
            // SQLServerButton
            // 
            this.SQLServerButton.BackgroundImage = global::ORACLE_SQL_SERVER_Client.Properties.Resources.sql_server_2014_logo;
            this.SQLServerButton.Location = new System.Drawing.Point(3, 3);
            this.SQLServerButton.Name = "SQLServerButton";
            this.SQLServerButton.Size = new System.Drawing.Size(224, 98);
            this.SQLServerButton.TabIndex = 1;
            this.SQLServerButton.Text = "SQLServer";
            this.SQLServerButton.UseVisualStyleBackColor = true;
            this.SQLServerButton.UseWaitCursor = true;
            this.SQLServerButton.Click += new System.EventHandler(this.SQLServerButton_Click);
            // 
            // OracleButton
            // 
            this.OracleButton.BackgroundImage = global::ORACLE_SQL_SERVER_Client.Properties.Resources._12cLogo;
            this.OracleButton.Location = new System.Drawing.Point(233, 3);
            this.OracleButton.Name = "OracleButton";
            this.OracleButton.Size = new System.Drawing.Size(224, 98);
            this.OracleButton.TabIndex = 0;
            this.OracleButton.Text = "Oracle";
            this.OracleButton.UseVisualStyleBackColor = true;
            this.OracleButton.UseWaitCursor = true;
            this.OracleButton.Click += new System.EventHandler(this.OracleButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(519, 232);
            this.Controls.Add(this.MainWindowContainer);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.RightToLeftLayout = true;
            this.Text = "Main Window ";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainWindowContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainWindowContainer;
        private System.Windows.Forms.Button SQLServerButton;
        private System.Windows.Forms.Button OracleButton;
    }
}

