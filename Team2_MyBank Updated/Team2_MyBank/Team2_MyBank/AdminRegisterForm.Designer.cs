namespace Team2_MyBank
{
    partial class AdminRegisterForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.confirmPWTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPWLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(148, 181);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(135, 61);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(135, 92);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox.TabIndex = 1;
            // 
            // confirmPWTextbox
            // 
            this.confirmPWTextbox.Location = new System.Drawing.Point(135, 133);
            this.confirmPWTextbox.Name = "confirmPWTextbox";
            this.confirmPWTextbox.Size = new System.Drawing.Size(100, 20);
            this.confirmPWTextbox.TabIndex = 2;
            this.confirmPWTextbox.Enter += new System.EventHandler(this.confirmPWTextbox_Enter);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(74, 64);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(76, 95);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // confirmPWLabel
            // 
            this.confirmPWLabel.AutoSize = true;
            this.confirmPWLabel.Location = new System.Drawing.Point(38, 136);
            this.confirmPWLabel.Name = "confirmPWLabel";
            this.confirmPWLabel.Size = new System.Drawing.Size(91, 13);
            this.confirmPWLabel.TabIndex = 6;
            this.confirmPWLabel.Text = "Confirm Password";
            // 
            // AdminRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 297);
            this.Controls.Add(this.confirmPWLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.confirmPWTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.submitButton);
            this.Name = "AdminRegisterForm";
            this.Text = "AdminRegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox confirmPWTextbox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPWLabel;
    }
}