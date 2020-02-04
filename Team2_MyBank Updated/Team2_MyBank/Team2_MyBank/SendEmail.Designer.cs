namespace Team2_MyBank
{
    partial class SendEmail
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
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.EmailVerifyCodeButton = new System.Windows.Forms.TextBox();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(157, 45);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBox.TabIndex = 0;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(173, 71);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // EmailVerifyCodeButton
            // 
            this.EmailVerifyCodeButton.Location = new System.Drawing.Point(157, 130);
            this.EmailVerifyCodeButton.Name = "EmailVerifyCodeButton";
            this.EmailVerifyCodeButton.Size = new System.Drawing.Size(100, 20);
            this.EmailVerifyCodeButton.TabIndex = 2;
            // 
            // VerifyButton
            // 
            this.VerifyButton.Location = new System.Drawing.Point(173, 156);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(75, 23);
            this.VerifyButton.TabIndex = 3;
            this.VerifyButton.Text = "Verify";
            this.VerifyButton.UseVisualStyleBackColor = true;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Email for Verification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter 6 Digit Code";
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.EmailVerifyCodeButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.EmailTextBox);
            this.Name = "SendEmail";
            this.Text = "SendEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox EmailVerifyCodeButton;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}