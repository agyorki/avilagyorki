namespace Team2_Grant_Greene_9A
{
    partial class ResetPasswordr
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
            this.ResetPassBox1 = new System.Windows.Forms.TextBox();
            this.ResetPassBoxVerify = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResetPassBox1
            // 
            this.ResetPassBox1.Location = new System.Drawing.Point(117, 54);
            this.ResetPassBox1.Name = "ResetPassBox1";
            this.ResetPassBox1.Size = new System.Drawing.Size(100, 20);
            this.ResetPassBox1.TabIndex = 0;
            // 
            // ResetPassBoxVerify
            // 
            this.ResetPassBoxVerify.Location = new System.Drawing.Point(117, 110);
            this.ResetPassBoxVerify.Name = "ResetPassBoxVerify";
            this.ResetPassBoxVerify.Size = new System.Drawing.Size(100, 20);
            this.ResetPassBoxVerify.TabIndex = 1;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(133, 183);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password";
            // 
            // ResetPasswordr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 258);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ResetPassBoxVerify);
            this.Controls.Add(this.ResetPassBox1);
            this.Name = "ResetPasswordr";
            this.Text = "ResetPasswordr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResetPassBox1;
        private System.Windows.Forms.TextBox ResetPassBoxVerify;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}