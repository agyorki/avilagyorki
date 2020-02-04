namespace LabDay2Modified
{
    partial class Form1
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
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.loanListBox = new System.Windows.Forms.ListBox();
            this.accountListBox = new System.Windows.Forms.ListBox();
            this.customerAccountID = new System.Windows.Forms.TextBox();
            this.loanCustomerID = new System.Windows.Forms.TextBox();
            this.accountAccountID = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.ItemHeight = 24;
            this.customerListBox.Location = new System.Drawing.Point(63, 65);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(299, 364);
            this.customerListBox.TabIndex = 0;
            this.customerListBox.SelectedIndexChanged += new System.EventHandler(this.customerListBox_SelectedIndexChanged);
            // 
            // loanListBox
            // 
            this.loanListBox.FormattingEnabled = true;
            this.loanListBox.ItemHeight = 24;
            this.loanListBox.Location = new System.Drawing.Point(432, 65);
            this.loanListBox.Name = "loanListBox";
            this.loanListBox.Size = new System.Drawing.Size(299, 364);
            this.loanListBox.TabIndex = 1;
            this.loanListBox.SelectedIndexChanged += new System.EventHandler(this.loanListBox_SelectedIndexChanged);
            // 
            // accountListBox
            // 
            this.accountListBox.FormattingEnabled = true;
            this.accountListBox.ItemHeight = 24;
            this.accountListBox.Location = new System.Drawing.Point(797, 65);
            this.accountListBox.Name = "accountListBox";
            this.accountListBox.Size = new System.Drawing.Size(299, 364);
            this.accountListBox.TabIndex = 2;
            this.accountListBox.SelectedIndexChanged += new System.EventHandler(this.accountListBox_SelectedIndexChanged);
            // 
            // customerAccountID
            // 
            this.customerAccountID.Location = new System.Drawing.Point(63, 471);
            this.customerAccountID.Name = "customerAccountID";
            this.customerAccountID.Size = new System.Drawing.Size(299, 29);
            this.customerAccountID.TabIndex = 3;
            // 
            // loanCustomerID
            // 
            this.loanCustomerID.Location = new System.Drawing.Point(432, 471);
            this.loanCustomerID.Name = "loanCustomerID";
            this.loanCustomerID.Size = new System.Drawing.Size(299, 29);
            this.loanCustomerID.TabIndex = 4;
            // 
            // accountAccountID
            // 
            this.accountAccountID.Location = new System.Drawing.Point(797, 471);
            this.accountAccountID.Name = "accountAccountID";
            this.accountAccountID.Size = new System.Drawing.Size(299, 29);
            this.accountAccountID.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(527, 562);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 51);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(432, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Loans";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(797, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Accounts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 651);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.accountAccountID);
            this.Controls.Add(this.loanCustomerID);
            this.Controls.Add(this.customerAccountID);
            this.Controls.Add(this.accountListBox);
            this.Controls.Add(this.loanListBox);
            this.Controls.Add(this.customerListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.ListBox loanListBox;
        private System.Windows.Forms.ListBox accountListBox;
        private System.Windows.Forms.TextBox customerAccountID;
        private System.Windows.Forms.TextBox loanCustomerID;
        private System.Windows.Forms.TextBox accountAccountID;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

