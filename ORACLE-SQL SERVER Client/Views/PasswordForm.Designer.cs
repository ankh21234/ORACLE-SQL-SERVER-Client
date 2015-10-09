namespace ORACLE_SQL_SERVER_Client.Views
{
    partial class PasswordForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DatabaseDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.ConnectionDetails1 = new System.Windows.Forms.Label();
            this.ConnectionDetailsText1 = new System.Windows.Forms.TextBox();
            this.ConnectionDetails2 = new System.Windows.Forms.Label();
            this.ConnectionDetailsText2 = new System.Windows.Forms.TextBox();
            this.ConnectionDetails3 = new System.Windows.Forms.Label();
            this.ConnectionDetailsText3 = new System.Windows.Forms.TextBox();
            this.ConnectionDetails4 = new System.Windows.Forms.Label();
            this.ConnectionDetailsText4 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.DatabaseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::ORACLE_SQL_SERVER_Client.Properties.Resources.database_icon;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(126, 167);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CancelButton);
            this.flowLayoutPanel2.Controls.Add(this.ConnectButton);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 185);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(400, 29);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(322, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(241, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // DatabaseDetails
            // 
            this.DatabaseDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatabaseDetails.Controls.Add(this.ConnectionDetails1);
            this.DatabaseDetails.Controls.Add(this.ConnectionDetailsText1);
            this.DatabaseDetails.Controls.Add(this.ConnectionDetails2);
            this.DatabaseDetails.Controls.Add(this.ConnectionDetailsText2);
            this.DatabaseDetails.Controls.Add(this.ConnectionDetails3);
            this.DatabaseDetails.Controls.Add(this.ConnectionDetailsText3);
            this.DatabaseDetails.Controls.Add(this.ConnectionDetails4);
            this.DatabaseDetails.Controls.Add(this.ConnectionDetailsText4);
            this.DatabaseDetails.Location = new System.Drawing.Point(145, 12);
            this.DatabaseDetails.Name = "DatabaseDetails";
            this.DatabaseDetails.Size = new System.Drawing.Size(267, 174);
            this.DatabaseDetails.TabIndex = 2;
            // 
            // ConnectionDetails1
            // 
            this.ConnectionDetails1.AutoSize = true;
            this.ConnectionDetails1.Location = new System.Drawing.Point(3, 0);
            this.ConnectionDetails1.Name = "ConnectionDetails1";
            this.ConnectionDetails1.Size = new System.Drawing.Size(29, 13);
            this.ConnectionDetails1.TabIndex = 2;
            this.ConnectionDetails1.Text = "label";
            // 
            // ConnectionDetailsText1
            // 
            this.ConnectionDetailsText1.Location = new System.Drawing.Point(3, 16);
            this.ConnectionDetailsText1.Name = "ConnectionDetailsText1";
            this.ConnectionDetailsText1.Size = new System.Drawing.Size(252, 20);
            this.ConnectionDetailsText1.TabIndex = 0;
            // 
            // ConnectionDetails2
            // 
            this.ConnectionDetails2.AutoSize = true;
            this.ConnectionDetails2.Location = new System.Drawing.Point(3, 39);
            this.ConnectionDetails2.Name = "ConnectionDetails2";
            this.ConnectionDetails2.Size = new System.Drawing.Size(29, 13);
            this.ConnectionDetails2.TabIndex = 1;
            this.ConnectionDetails2.Text = "label";
            // 
            // ConnectionDetailsText2
            // 
            this.ConnectionDetailsText2.Location = new System.Drawing.Point(3, 55);
            this.ConnectionDetailsText2.Name = "ConnectionDetailsText2";
            this.ConnectionDetailsText2.Size = new System.Drawing.Size(252, 20);
            this.ConnectionDetailsText2.TabIndex = 3;
            // 
            // ConnectionDetails3
            // 
            this.ConnectionDetails3.AutoSize = true;
            this.ConnectionDetails3.Location = new System.Drawing.Point(3, 78);
            this.ConnectionDetails3.Name = "ConnectionDetails3";
            this.ConnectionDetails3.Size = new System.Drawing.Size(29, 13);
            this.ConnectionDetails3.TabIndex = 4;
            this.ConnectionDetails3.Text = "label";
            // 
            // ConnectionDetailsText3
            // 
            this.ConnectionDetailsText3.Location = new System.Drawing.Point(3, 94);
            this.ConnectionDetailsText3.Name = "ConnectionDetailsText3";
            this.ConnectionDetailsText3.Size = new System.Drawing.Size(252, 20);
            this.ConnectionDetailsText3.TabIndex = 5;
            // 
            // ConnectionDetails4
            // 
            this.ConnectionDetails4.AutoSize = true;
            this.ConnectionDetails4.Location = new System.Drawing.Point(3, 117);
            this.ConnectionDetails4.Name = "ConnectionDetails4";
            this.ConnectionDetails4.Size = new System.Drawing.Size(29, 13);
            this.ConnectionDetails4.TabIndex = 6;
            this.ConnectionDetails4.Text = "label";
            // 
            // ConnectionDetailsText4
            // 
            this.ConnectionDetailsText4.Location = new System.Drawing.Point(3, 133);
            this.ConnectionDetailsText4.Name = "ConnectionDetailsText4";
            this.ConnectionDetailsText4.Size = new System.Drawing.Size(252, 20);
            this.ConnectionDetailsText4.TabIndex = 7;
            this.ConnectionDetailsText4.UseSystemPasswordChar = true;
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(423, 224);
            this.Controls.Add(this.DatabaseDetails);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordForm";
            this.Text = "Database Validation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordForm_FormClosing);
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.DatabaseDetails.ResumeLayout(false);
            this.DatabaseDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private bool mode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel DatabaseDetails;
        private System.Windows.Forms.Label ConnectionDetails1;
        private System.Windows.Forms.TextBox ConnectionDetailsText1;
        private System.Windows.Forms.Label ConnectionDetails2;
        private System.Windows.Forms.TextBox ConnectionDetailsText2;
        private System.Windows.Forms.Label ConnectionDetails3;
        private System.Windows.Forms.TextBox ConnectionDetailsText3;
        private System.Windows.Forms.Label ConnectionDetails4;
        private System.Windows.Forms.TextBox ConnectionDetailsText4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConnectButton;
    }
}