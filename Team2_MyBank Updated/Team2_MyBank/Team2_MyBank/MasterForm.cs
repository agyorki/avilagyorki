using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Modified: 11/30/2019
 * Members:
 *          Dominic DiTirro
 *          
 *          
 *          
 *          
 * Project: myBank
 * Class: Programming Theory and Apps 34070
*/

namespace Team2_MyBank
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void openATMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm ATM = new MainForm();
            this.Hide();
            ATM.ShowDialog();
            this.Show();
        }

        private void mortgageCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            morgCalc morgCalc = new morgCalc();
            this.Hide();
            morgCalc.ShowDialog();
            this.Show();
        }

        private void loansApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoansApplication loanApp = new LoansApplication();
            this.Hide();
            loanApp.ShowDialog();
            this.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminLoginForm loginForm = new AdminLoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Show();
        }
    }
}
