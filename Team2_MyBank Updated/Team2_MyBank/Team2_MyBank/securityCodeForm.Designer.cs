namespace Team2_MyBank
{
    partial class securityCodeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.securityCodeInputTextbox = new System.Windows.Forms.TextBox();
            this.securityCodeLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.codeOutputLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(183, 194);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // securityCodeInputTextbox
            // 
            this.securityCodeInputTextbox.Location = new System.Drawing.Point(170, 121);
            this.securityCodeInputTextbox.Name = "securityCodeInputTextbox";
            this.securityCodeInputTextbox.Size = new System.Drawing.Size(100, 20);
            this.securityCodeInputTextbox.TabIndex = 0;
            // 
            // securityCodeLabel
            // 
            this.securityCodeLabel.AutoSize = true;
            this.securityCodeLabel.Location = new System.Drawing.Point(88, 124);
            this.securityCodeLabel.Name = "securityCodeLabel";
            this.securityCodeLabel.Size = new System.Drawing.Size(76, 13);
            this.securityCodeLabel.TabIndex = 3;
            this.securityCodeLabel.Text = "Security Code:";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(12, 9);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(40, 13);
            this.codeLabel.TabIndex = 4;
            this.codeLabel.Text = "CODE:";
            // 
            // codeOutputLabel
            // 
            this.codeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.codeOutputLabel.Location = new System.Drawing.Point(64, 4);
            this.codeOutputLabel.Name = "codeOutputLabel";
            this.codeOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.codeOutputLabel.TabIndex = 5;
            this.codeOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(61, 82);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(326, 13);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Enter the security code sent to your registered device(s)";
            // 
            // securityCodeForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 310);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.codeOutputLabel);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.securityCodeLabel);
            this.Controls.Add(this.securityCodeInputTextbox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Name = "securityCodeForm";
            this.Text = "securityCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox securityCodeInputTextbox;
        private System.Windows.Forms.Label securityCodeLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Label codeOutputLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}