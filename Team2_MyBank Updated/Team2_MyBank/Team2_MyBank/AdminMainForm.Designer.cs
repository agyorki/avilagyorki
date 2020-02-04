namespace Team2_MyBank
{
    partial class AdminMainForm
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
            this.addRecordButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.backupButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.customersCheckbox = new System.Windows.Forms.CheckBox();
            this.loansCheckbox = new System.Windows.Forms.CheckBox();
            this.accountsCheckbox = new System.Windows.Forms.CheckBox();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.loansListBox = new System.Windows.Forms.ListBox();
            this.accountsListBox = new System.Windows.Forms.ListBox();
            this.customersTextbox = new System.Windows.Forms.TextBox();
            this.laonsTextbox = new System.Windows.Forms.TextBox();
            this.accountsTextbox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(105, 405);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(75, 23);
            this.addRecordButton.TabIndex = 0;
            this.addRecordButton.Text = "Add Record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(158, 376);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(75, 23);
            this.restoreButton.TabIndex = 1;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(220, 405);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(75, 23);
            this.backupButton.TabIndex = 2;
            this.backupButton.Text = "Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(277, 376);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(332, 405);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // customersCheckbox
            // 
            this.customersCheckbox.AutoSize = true;
            this.customersCheckbox.Location = new System.Drawing.Point(86, 70);
            this.customersCheckbox.Name = "customersCheckbox";
            this.customersCheckbox.Size = new System.Drawing.Size(75, 17);
            this.customersCheckbox.TabIndex = 5;
            this.customersCheckbox.Text = "Customers";
            this.customersCheckbox.UseVisualStyleBackColor = true;
            // 
            // loansCheckbox
            // 
            this.loansCheckbox.AutoSize = true;
            this.loansCheckbox.Location = new System.Drawing.Point(235, 70);
            this.loansCheckbox.Name = "loansCheckbox";
            this.loansCheckbox.Size = new System.Drawing.Size(55, 17);
            this.loansCheckbox.TabIndex = 6;
            this.loansCheckbox.Text = "Loans";
            this.loansCheckbox.UseVisualStyleBackColor = true;
            // 
            // accountsCheckbox
            // 
            this.accountsCheckbox.AutoSize = true;
            this.accountsCheckbox.Location = new System.Drawing.Point(383, 70);
            this.accountsCheckbox.Name = "accountsCheckbox";
            this.accountsCheckbox.Size = new System.Drawing.Size(71, 17);
            this.accountsCheckbox.TabIndex = 7;
            this.accountsCheckbox.Text = "Accounts";
            this.accountsCheckbox.UseVisualStyleBackColor = true;
            // 
            // customersListBox
            // 
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(72, 93);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(120, 173);
            this.customersListBox.TabIndex = 8;
            // 
            // loansListBox
            // 
            this.loansListBox.FormattingEnabled = true;
            this.loansListBox.Location = new System.Drawing.Point(220, 93);
            this.loansListBox.Name = "loansListBox";
            this.loansListBox.Size = new System.Drawing.Size(120, 173);
            this.loansListBox.TabIndex = 9;
            // 
            // accountsListBox
            // 
            this.accountsListBox.FormattingEnabled = true;
            this.accountsListBox.Location = new System.Drawing.Point(365, 93);
            this.accountsListBox.Name = "accountsListBox";
            this.accountsListBox.Size = new System.Drawing.Size(120, 173);
            this.accountsListBox.TabIndex = 10;
            // 
            // customersTextbox
            // 
            this.customersTextbox.Location = new System.Drawing.Point(72, 321);
            this.customersTextbox.Name = "customersTextbox";
            this.customersTextbox.Size = new System.Drawing.Size(120, 20);
            this.customersTextbox.TabIndex = 11;
            this.customersTextbox.Enter += new System.EventHandler(this.customersTextbox_Enter);
            // 
            // laonsTextbox
            // 
            this.laonsTextbox.Location = new System.Drawing.Point(220, 321);
            this.laonsTextbox.Name = "laonsTextbox";
            this.laonsTextbox.Size = new System.Drawing.Size(120, 20);
            this.laonsTextbox.TabIndex = 12;
            this.laonsTextbox.Enter += new System.EventHandler(this.laonsTextbox_Enter);
            // 
            // accountsTextbox
            // 
            this.accountsTextbox.Location = new System.Drawing.Point(365, 321);
            this.accountsTextbox.Name = "accountsTextbox";
            this.accountsTextbox.Size = new System.Drawing.Size(120, 20);
            this.accountsTextbox.TabIndex = 13;
            this.accountsTextbox.Enter += new System.EventHandler(this.accountsTextbox_Enter);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(69, 294);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(333, 13);
            this.infoLabel.TabIndex = 14;
            this.infoLabel.Text = "To add records to DB enter data into the textboxes below";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(563, 524);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.accountsTextbox);
            this.Controls.Add(this.laonsTextbox);
            this.Controls.Add(this.customersTextbox);
            this.Controls.Add(this.accountsListBox);
            this.Controls.Add(this.loansListBox);
            this.Controls.Add(this.customersListBox);
            this.Controls.Add(this.accountsCheckbox);
            this.Controls.Add(this.loansCheckbox);
            this.Controls.Add(this.customersCheckbox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.addRecordButton);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox customersCheckbox;
        private System.Windows.Forms.CheckBox loansCheckbox;
        private System.Windows.Forms.CheckBox accountsCheckbox;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.ListBox loansListBox;
        private System.Windows.Forms.ListBox accountsListBox;
        private System.Windows.Forms.TextBox customersTextbox;
        private System.Windows.Forms.TextBox laonsTextbox;
        private System.Windows.Forms.TextBox accountsTextbox;
        private System.Windows.Forms.Label infoLabel;
    }
}