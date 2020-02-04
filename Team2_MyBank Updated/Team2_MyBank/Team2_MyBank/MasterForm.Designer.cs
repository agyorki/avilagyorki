namespace Team2_MyBank
{
    partial class MasterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loansApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mortgageCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openATMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aTMToolStripMenuItem,
            this.loansToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aTMToolStripMenuItem
            // 
            this.aTMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openATMToolStripMenuItem});
            this.aTMToolStripMenuItem.Name = "aTMToolStripMenuItem";
            this.aTMToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aTMToolStripMenuItem.Text = "ATM";
            // 
            // loansToolStripMenuItem
            // 
            this.loansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loansApplicationToolStripMenuItem,
            this.mortgageCalculatorToolStripMenuItem});
            this.loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            this.loansToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.loansToolStripMenuItem.Text = "Loans";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // loansApplicationToolStripMenuItem
            // 
            this.loansApplicationToolStripMenuItem.Name = "loansApplicationToolStripMenuItem";
            this.loansApplicationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loansApplicationToolStripMenuItem.Text = "Loans Application";
            this.loansApplicationToolStripMenuItem.Click += new System.EventHandler(this.loansApplicationToolStripMenuItem_Click);
            // 
            // mortgageCalculatorToolStripMenuItem
            // 
            this.mortgageCalculatorToolStripMenuItem.Name = "mortgageCalculatorToolStripMenuItem";
            this.mortgageCalculatorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.mortgageCalculatorToolStripMenuItem.Text = "Mortgage Calculator";
            this.mortgageCalculatorToolStripMenuItem.Click += new System.EventHandler(this.mortgageCalculatorToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // openATMToolStripMenuItem
            // 
            this.openATMToolStripMenuItem.Name = "openATMToolStripMenuItem";
            this.openATMToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openATMToolStripMenuItem.Text = "Open ATM";
            this.openATMToolStripMenuItem.Click += new System.EventHandler(this.openATMToolStripMenuItem_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 152);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team 2 MyBank Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aTMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loansApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mortgageCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openATMToolStripMenuItem;
    }
}

