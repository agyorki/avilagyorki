﻿namespace Team2_MyBank
{
    partial class MainForm
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
            this.displayMiniStatementButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkingBalanceLabel = new System.Windows.Forms.Label();
            this.checkingClearButton = new System.Windows.Forms.Button();
            this.checkingSubmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkingTransferButton = new System.Windows.Forms.RadioButton();
            this.checkingFastCashButton = new System.Windows.Forms.RadioButton();
            this.checkingWithdrawButton = new System.Windows.Forms.RadioButton();
            this.checkingDepositButton = new System.Windows.Forms.RadioButton();
            this.checkingAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.savingBalanceLabel = new System.Windows.Forms.Label();
            this.savingClearButton = new System.Windows.Forms.Button();
            this.savingSubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.savingTransferButton = new System.Windows.Forms.RadioButton();
            this.savingFastCashButton = new System.Windows.Forms.RadioButton();
            this.savingWithdrawButton = new System.Windows.Forms.RadioButton();
            this.savingDepositButton = new System.Windows.Forms.RadioButton();
            this.savingAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayMiniStatementButton
            // 
            this.displayMiniStatementButton.Location = new System.Drawing.Point(164, 322);
            this.displayMiniStatementButton.Margin = new System.Windows.Forms.Padding(2);
            this.displayMiniStatementButton.Name = "displayMiniStatementButton";
            this.displayMiniStatementButton.Size = new System.Drawing.Size(108, 44);
            this.displayMiniStatementButton.TabIndex = 1;
            this.displayMiniStatementButton.Text = "Display Mini Statement";
            this.displayMiniStatementButton.UseVisualStyleBackColor = true;
            this.displayMiniStatementButton.Click += new System.EventHandler(this.displayMiniStatementButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(7, 7);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(267, 301);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkingBalanceLabel);
            this.tabPage1.Controls.Add(this.checkingClearButton);
            this.tabPage1.Controls.Add(this.checkingSubmitButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.checkingAmountTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(259, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Checking";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkingBalanceLabel
            // 
            this.checkingBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkingBalanceLabel.Location = new System.Drawing.Point(149, 130);
            this.checkingBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkingBalanceLabel.Name = "checkingBalanceLabel";
            this.checkingBalanceLabel.Size = new System.Drawing.Size(85, 19);
            this.checkingBalanceLabel.TabIndex = 7;
            // 
            // checkingClearButton
            // 
            this.checkingClearButton.Location = new System.Drawing.Point(182, 244);
            this.checkingClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkingClearButton.Name = "checkingClearButton";
            this.checkingClearButton.Size = new System.Drawing.Size(51, 19);
            this.checkingClearButton.TabIndex = 3;
            this.checkingClearButton.Text = "Clear";
            this.checkingClearButton.UseVisualStyleBackColor = true;
            this.checkingClearButton.Click += new System.EventHandler(this.checkingClearButton_Click_1);
            // 
            // checkingSubmitButton
            // 
            this.checkingSubmitButton.Location = new System.Drawing.Point(33, 244);
            this.checkingSubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkingSubmitButton.Name = "checkingSubmitButton";
            this.checkingSubmitButton.Size = new System.Drawing.Size(51, 19);
            this.checkingSubmitButton.TabIndex = 2;
            this.checkingSubmitButton.Text = "Submit";
            this.checkingSubmitButton.UseVisualStyleBackColor = true;
            this.checkingSubmitButton.Click += new System.EventHandler(this.checkingSubmitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Balance:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkingTransferButton);
            this.groupBox1.Controls.Add(this.checkingFastCashButton);
            this.groupBox1.Controls.Add(this.checkingWithdrawButton);
            this.groupBox1.Controls.Add(this.checkingDepositButton);
            this.groupBox1.Location = new System.Drawing.Point(33, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(102, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Action";
            // 
            // checkingTransferButton
            // 
            this.checkingTransferButton.AutoSize = true;
            this.checkingTransferButton.Location = new System.Drawing.Point(22, 99);
            this.checkingTransferButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkingTransferButton.Name = "checkingTransferButton";
            this.checkingTransferButton.Size = new System.Drawing.Size(64, 17);
            this.checkingTransferButton.TabIndex = 5;
            this.checkingTransferButton.TabStop = true;
            this.checkingTransferButton.Text = "Transfer";
            this.checkingTransferButton.UseVisualStyleBackColor = true;
            // 
            // checkingFastCashButton
            // 
            this.checkingFastCashButton.AutoSize = true;
            this.checkingFastCashButton.Location = new System.Drawing.Point(22, 74);
            this.checkingFastCashButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkingFastCashButton.Name = "checkingFastCashButton";
            this.checkingFastCashButton.Size = new System.Drawing.Size(72, 17);
            this.checkingFastCashButton.TabIndex = 2;
            this.checkingFastCashButton.TabStop = true;
            this.checkingFastCashButton.Text = "Fast Cash";
            this.checkingFastCashButton.UseVisualStyleBackColor = true;
            // 
            // checkingWithdrawButton
            // 
            this.checkingWithdrawButton.AutoSize = true;
            this.checkingWithdrawButton.Location = new System.Drawing.Point(22, 49);
            this.checkingWithdrawButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkingWithdrawButton.Name = "checkingWithdrawButton";
            this.checkingWithdrawButton.Size = new System.Drawing.Size(70, 17);
            this.checkingWithdrawButton.TabIndex = 1;
            this.checkingWithdrawButton.TabStop = true;
            this.checkingWithdrawButton.Text = "Withdraw";
            this.checkingWithdrawButton.UseVisualStyleBackColor = true;
            // 
            // checkingDepositButton
            // 
            this.checkingDepositButton.AutoSize = true;
            this.checkingDepositButton.Location = new System.Drawing.Point(22, 23);
            this.checkingDepositButton.Margin = new System.Windows.Forms.Padding(2);
            this.checkingDepositButton.Name = "checkingDepositButton";
            this.checkingDepositButton.Size = new System.Drawing.Size(61, 17);
            this.checkingDepositButton.TabIndex = 0;
            this.checkingDepositButton.TabStop = true;
            this.checkingDepositButton.Text = "Deposit";
            this.checkingDepositButton.UseVisualStyleBackColor = true;
            // 
            // checkingAmountTextBox
            // 
            this.checkingAmountTextBox.Location = new System.Drawing.Point(149, 49);
            this.checkingAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.checkingAmountTextBox.Name = "checkingAmountTextBox";
            this.checkingAmountTextBox.Size = new System.Drawing.Size(86, 20);
            this.checkingAmountTextBox.TabIndex = 0;
            this.checkingAmountTextBox.Enter += new System.EventHandler(this.checkingAmountTextBox_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.savingBalanceLabel);
            this.tabPage2.Controls.Add(this.savingClearButton);
            this.tabPage2.Controls.Add(this.savingSubmitButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.savingAmountTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(259, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saving";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // savingBalanceLabel
            // 
            this.savingBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.savingBalanceLabel.Location = new System.Drawing.Point(149, 130);
            this.savingBalanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.savingBalanceLabel.Name = "savingBalanceLabel";
            this.savingBalanceLabel.Size = new System.Drawing.Size(85, 19);
            this.savingBalanceLabel.TabIndex = 14;
            // 
            // savingClearButton
            // 
            this.savingClearButton.Location = new System.Drawing.Point(182, 244);
            this.savingClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.savingClearButton.Name = "savingClearButton";
            this.savingClearButton.Size = new System.Drawing.Size(51, 19);
            this.savingClearButton.TabIndex = 3;
            this.savingClearButton.Text = "Clear";
            this.savingClearButton.UseVisualStyleBackColor = true;
            this.savingClearButton.Click += new System.EventHandler(this.savingClearButton_Click_1);
            // 
            // savingSubmitButton
            // 
            this.savingSubmitButton.Location = new System.Drawing.Point(33, 244);
            this.savingSubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.savingSubmitButton.Name = "savingSubmitButton";
            this.savingSubmitButton.Size = new System.Drawing.Size(51, 19);
            this.savingSubmitButton.TabIndex = 2;
            this.savingSubmitButton.Text = "Submit";
            this.savingSubmitButton.UseVisualStyleBackColor = true;
            this.savingSubmitButton.Click += new System.EventHandler(this.savingSubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Balance:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.savingTransferButton);
            this.groupBox2.Controls.Add(this.savingFastCashButton);
            this.groupBox2.Controls.Add(this.savingWithdrawButton);
            this.groupBox2.Controls.Add(this.savingDepositButton);
            this.groupBox2.Location = new System.Drawing.Point(33, 94);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(102, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Action";
            // 
            // savingTransferButton
            // 
            this.savingTransferButton.AutoSize = true;
            this.savingTransferButton.Location = new System.Drawing.Point(22, 99);
            this.savingTransferButton.Margin = new System.Windows.Forms.Padding(2);
            this.savingTransferButton.Name = "savingTransferButton";
            this.savingTransferButton.Size = new System.Drawing.Size(64, 17);
            this.savingTransferButton.TabIndex = 4;
            this.savingTransferButton.TabStop = true;
            this.savingTransferButton.Text = "Transfer";
            this.savingTransferButton.UseVisualStyleBackColor = true;
            // 
            // savingFastCashButton
            // 
            this.savingFastCashButton.AutoSize = true;
            this.savingFastCashButton.Location = new System.Drawing.Point(22, 74);
            this.savingFastCashButton.Margin = new System.Windows.Forms.Padding(2);
            this.savingFastCashButton.Name = "savingFastCashButton";
            this.savingFastCashButton.Size = new System.Drawing.Size(72, 17);
            this.savingFastCashButton.TabIndex = 3;
            this.savingFastCashButton.TabStop = true;
            this.savingFastCashButton.Text = "Fast Cash";
            this.savingFastCashButton.UseVisualStyleBackColor = true;
            // 
            // savingWithdrawButton
            // 
            this.savingWithdrawButton.AutoSize = true;
            this.savingWithdrawButton.Location = new System.Drawing.Point(22, 49);
            this.savingWithdrawButton.Margin = new System.Windows.Forms.Padding(2);
            this.savingWithdrawButton.Name = "savingWithdrawButton";
            this.savingWithdrawButton.Size = new System.Drawing.Size(70, 17);
            this.savingWithdrawButton.TabIndex = 1;
            this.savingWithdrawButton.TabStop = true;
            this.savingWithdrawButton.Text = "Withdraw";
            this.savingWithdrawButton.UseVisualStyleBackColor = true;
            // 
            // savingDepositButton
            // 
            this.savingDepositButton.AutoSize = true;
            this.savingDepositButton.Location = new System.Drawing.Point(22, 23);
            this.savingDepositButton.Margin = new System.Windows.Forms.Padding(2);
            this.savingDepositButton.Name = "savingDepositButton";
            this.savingDepositButton.Size = new System.Drawing.Size(61, 17);
            this.savingDepositButton.TabIndex = 0;
            this.savingDepositButton.TabStop = true;
            this.savingDepositButton.Text = "Deposit";
            this.savingDepositButton.UseVisualStyleBackColor = true;
            // 
            // savingAmountTextBox
            // 
            this.savingAmountTextBox.Location = new System.Drawing.Point(149, 49);
            this.savingAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.savingAmountTextBox.Name = "savingAmountTextBox";
            this.savingAmountTextBox.Size = new System.Drawing.Size(86, 20);
            this.savingAmountTextBox.TabIndex = 0;
            this.savingAmountTextBox.Enter += new System.EventHandler(this.savingAmountTextBox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(9, 322);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(58, 44);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 372);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.displayMiniStatementButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button displayMiniStatementButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button checkingClearButton;
        private System.Windows.Forms.Button checkingSubmitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkingWithdrawButton;
        private System.Windows.Forms.RadioButton checkingDepositButton;
        private System.Windows.Forms.TextBox checkingAmountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button savingClearButton;
        private System.Windows.Forms.Button savingSubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton savingWithdrawButton;
        private System.Windows.Forms.RadioButton savingDepositButton;
        private System.Windows.Forms.TextBox savingAmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton checkingFastCashButton;
        private System.Windows.Forms.RadioButton savingFastCashButton;
        private System.Windows.Forms.RadioButton checkingTransferButton;
        private System.Windows.Forms.RadioButton savingTransferButton;
        private System.Windows.Forms.Label checkingBalanceLabel;
        private System.Windows.Forms.Label savingBalanceLabel;
    }
}

