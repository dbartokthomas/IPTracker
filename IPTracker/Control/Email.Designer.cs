namespace IPTracker.Control
{
    partial class Email
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testMail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mailSmtpServer = new System.Windows.Forms.TextBox();
            this.mailUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mailPassword = new System.Windows.Forms.MaskedTextBox();
            this.mailTo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mailBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testMail
            // 
            this.testMail.Location = new System.Drawing.Point(226, 167);
            this.testMail.Name = "testMail";
            this.testMail.Size = new System.Drawing.Size(75, 23);
            this.testMail.TabIndex = 0;
            this.testMail.Text = "Test Mail";
            this.testMail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMTP Server";
            // 
            // mailSmtpServer
            // 
            this.mailSmtpServer.Location = new System.Drawing.Point(80, 3);
            this.mailSmtpServer.Name = "mailSmtpServer";
            this.mailSmtpServer.Size = new System.Drawing.Size(221, 20);
            this.mailSmtpServer.TabIndex = 2;
            // 
            // mailUsername
            // 
            this.mailUsername.Location = new System.Drawing.Point(80, 29);
            this.mailUsername.Name = "mailUsername";
            this.mailUsername.Size = new System.Drawing.Size(221, 20);
            this.mailUsername.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // mailPassword
            // 
            this.mailPassword.Location = new System.Drawing.Point(80, 55);
            this.mailPassword.Name = "mailPassword";
            this.mailPassword.Size = new System.Drawing.Size(221, 20);
            this.mailPassword.TabIndex = 7;
            // 
            // mailTo
            // 
            this.mailTo.Location = new System.Drawing.Point(80, 81);
            this.mailTo.Name = "mailTo";
            this.mailTo.Size = new System.Drawing.Size(221, 20);
            this.mailTo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mail To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mail Body";
            // 
            // mailBody
            // 
            this.mailBody.Location = new System.Drawing.Point(80, 107);
            this.mailBody.Multiline = true;
            this.mailBody.Name = "mailBody";
            this.mailBody.Size = new System.Drawing.Size(221, 54);
            this.mailBody.TabIndex = 11;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mailBody);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mailTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mailPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mailUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailSmtpServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testMail);
            this.Name = "Email";
            this.Size = new System.Drawing.Size(304, 199);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mailSmtpServer;
        private System.Windows.Forms.TextBox mailUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mailPassword;
        private System.Windows.Forms.MaskedTextBox mailTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mailBody;
    }
}
