namespace Team2_MyBank
{
    partial class morgCalc
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loanLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.monthlyPaymentLabel = new System.Windows.Forms.Label();
            this.numberOfYearsTextBox = new System.Windows.Forms.TextBox();
            this.annualROITextBox = new System.Windows.Forms.TextBox();
            this.amtLoanTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AvgMonthlyPaymentsLabel = new System.Windows.Forms.Label();
            this.totalMonthlyPaymentsLabel = new System.Windows.Forms.Label();
            this.totalOfAllLoansLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monthly Payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Years";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Annual Rate of Interest";
            // 
            // loanLabel
            // 
            this.loanLabel.AutoSize = true;
            this.loanLabel.Location = new System.Drawing.Point(136, 42);
            this.loanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loanLabel.Name = "loanLabel";
            this.loanLabel.Size = new System.Drawing.Size(105, 20);
            this.loanLabel.TabIndex = 4;
            this.loanLabel.Text = "Loan Amount";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(391, 597);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 63);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(217, 597);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(133, 63);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(43, 597);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(133, 63);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate Button";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // monthlyPaymentLabel
            // 
            this.monthlyPaymentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthlyPaymentLabel.Location = new System.Drawing.Point(263, 153);
            this.monthlyPaymentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthlyPaymentLabel.Name = "monthlyPaymentLabel";
            this.monthlyPaymentLabel.Size = new System.Drawing.Size(239, 78);
            this.monthlyPaymentLabel.TabIndex = 19;
            // 
            // numberOfYearsTextBox
            // 
            this.numberOfYearsTextBox.Location = new System.Drawing.Point(263, 119);
            this.numberOfYearsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberOfYearsTextBox.Multiline = true;
            this.numberOfYearsTextBox.Name = "numberOfYearsTextBox";
            this.numberOfYearsTextBox.Size = new System.Drawing.Size(240, 26);
            this.numberOfYearsTextBox.TabIndex = 18;
            // 
            // annualROITextBox
            // 
            this.annualROITextBox.Location = new System.Drawing.Point(263, 82);
            this.annualROITextBox.Margin = new System.Windows.Forms.Padding(2);
            this.annualROITextBox.Multiline = true;
            this.annualROITextBox.Name = "annualROITextBox";
            this.annualROITextBox.Size = new System.Drawing.Size(240, 26);
            this.annualROITextBox.TabIndex = 17;
            // 
            // amtLoanTextBox
            // 
            this.amtLoanTextBox.Location = new System.Drawing.Point(263, 42);
            this.amtLoanTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.amtLoanTextBox.Multiline = true;
            this.amtLoanTextBox.Name = "amtLoanTextBox";
            this.amtLoanTextBox.Size = new System.Drawing.Size(240, 26);
            this.amtLoanTextBox.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AvgMonthlyPaymentsLabel);
            this.groupBox1.Controls.Add(this.totalMonthlyPaymentsLabel);
            this.groupBox1.Controls.Add(this.totalOfAllLoansLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(45, 245);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(479, 294);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // AvgMonthlyPaymentsLabel
            // 
            this.AvgMonthlyPaymentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvgMonthlyPaymentsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AvgMonthlyPaymentsLabel.Location = new System.Drawing.Point(214, 216);
            this.AvgMonthlyPaymentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AvgMonthlyPaymentsLabel.Name = "AvgMonthlyPaymentsLabel";
            this.AvgMonthlyPaymentsLabel.Size = new System.Drawing.Size(243, 44);
            this.AvgMonthlyPaymentsLabel.TabIndex = 12;
            // 
            // totalMonthlyPaymentsLabel
            // 
            this.totalMonthlyPaymentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalMonthlyPaymentsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalMonthlyPaymentsLabel.Location = new System.Drawing.Point(214, 129);
            this.totalMonthlyPaymentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalMonthlyPaymentsLabel.Name = "totalMonthlyPaymentsLabel";
            this.totalMonthlyPaymentsLabel.Size = new System.Drawing.Size(243, 44);
            this.totalMonthlyPaymentsLabel.TabIndex = 11;
            // 
            // totalOfAllLoansLabel
            // 
            this.totalOfAllLoansLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOfAllLoansLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalOfAllLoansLabel.Location = new System.Drawing.Point(214, 43);
            this.totalOfAllLoansLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalOfAllLoansLabel.Name = "totalOfAllLoansLabel";
            this.totalOfAllLoansLabel.Size = new System.Drawing.Size(243, 44);
            this.totalOfAllLoansLabel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Average Monthly Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Monthly Payments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total of All Loans";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 717);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthlyPaymentLabel);
            this.Controls.Add(this.numberOfYearsTextBox);
            this.Controls.Add(this.annualROITextBox);
            this.Controls.Add(this.amtLoanTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loanLabel);
            this.Name = "Form1";
            this.Text = "Mortgage Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loanLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label monthlyPaymentLabel;
        private System.Windows.Forms.TextBox numberOfYearsTextBox;
        private System.Windows.Forms.TextBox annualROITextBox;
        private System.Windows.Forms.TextBox amtLoanTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AvgMonthlyPaymentsLabel;
        private System.Windows.Forms.Label totalMonthlyPaymentsLabel;
        private System.Windows.Forms.Label totalOfAllLoansLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

