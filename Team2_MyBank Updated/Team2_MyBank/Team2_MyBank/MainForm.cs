using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Team2_MyBank
{
    public partial class MainForm : Form
    {
        //declared doubles outside of the event handlers so as to hold a running total
        double checkingBalance = 0;
        double savingBalance = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        // The number of times checking saving submitted
        int c_counter = 0,
            s_counter = 0;

        // Lists to contain the transactions
        List<string> c_transList = new List<string>();
        List<string> s_transList = new List<string>();

        //method to display the balances for both checking and savings accounts
        public void DisplayCheckingBalance(string checkingUserBalance)
        {
            checkingBalanceLabel.Text = checkingUserBalance;
        }

        public void DisplaySavingBalance(string savingUserBalance)
        {
            savingBalanceLabel.Text = savingUserBalance;
        }

        private void checkingClearButton_Click(object sender, EventArgs e)
        {
            //clearing the amount text box and resetting focus
            checkingAmountTextBox.Text = "";
            checkingAmountTextBox.Focus();
        }

        private void savingClearButton_Click(object sender, EventArgs e)
        {
            //clearing the amount text box and resetting focus
            savingAmountTextBox.Text = "";
            savingAmountTextBox.Focus();
        }

        // Display the statement of last 10 transactions
        // Does NOT work with tabs. Ran out of time
        private void displayMiniStatementButton_Click(object sender, EventArgs e)
        {
            string last_10_trans = "";
            if (tabControl1.SelectedIndex == 0)     // If the checking tab is selected
            {
                for (int i = 1; i <= 10; ++i)
                {
                    if (c_transList.Count - i < 0)
                        break;
                    last_10_trans += c_transList[c_transList.Count - i] + '\n';
                }
                MessageBox.Show(last_10_trans);
            }
            else if (tabControl1.SelectedIndex == 1)    // If the savings tab is selected
            {
                for (int i = 1; i <= 10; ++i)
                {
                    if (s_transList.Count - i < 0)
                        break;
                    last_10_trans += s_transList[s_transList.Count - i] + '\n';
                }
                MessageBox.Show(last_10_trans);
            }
        }

        private void checkingSubmitButton_Click(object sender, EventArgs e)
        {
            //declaring strings for the entered amount and the balance label
            string balanceText = "";
            double deposit = 0;
            double withdraw = 0;
            double fastcash = 0;
            double transfer = 0;
            string userAmount = "";
            bool   success = false; // determines if trans action was successful
            string transType = "";  // The transaction type

            //if the deposit radio button is selected
            if (checkingDepositButton.Checked == true)
            {
                userAmount = checkingAmountTextBox.Text;

                //tryparse if statements to ensure that the entered amount is a number and not blank
                if (!Double.TryParse(userAmount, out deposit))
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    checkingAmountTextBox.Text = "";
                    userAmount = "";
                    success = false;
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    success = false;
                }

                //prints the balance to the label
                else
                {
                    deposit = Convert.ToDouble(userAmount);

                    checkingBalance = checkingBalance + deposit;

                    balanceText = Convert.ToString(checkingBalance);

                    DisplayCheckingBalance(balanceText);

                    success = true;

                    transType = "Deposit: ";

                    ++c_counter;
                }
            }

            //if the withdraw button is selected
            else if (checkingWithdrawButton.Checked == true)
            {

                userAmount = checkingAmountTextBox.Text;

                //tryparse if statements to ensure that the entered amount is a number, 
                //not blank, not higher than the balance, and not over $400
                if (!Double.TryParse(userAmount, out withdraw))
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    checkingAmountTextBox.Text = "";
                    userAmount = "";
                    success = false;
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    success = false;
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > checkingBalance)
                {
                    MessageBox.Show("You cannot withdraw $" + userAmount + " because it is higher than your current balance. Please try again.");
                    success = false;
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > 400)
                {
                    MessageBox.Show("You cannot withdraw more than $400 at once. Please try again.");
                    success = false;
                }

                //prints the balance to the label
                else
                {
                    withdraw = Convert.ToDouble(userAmount);

                    checkingBalance = checkingBalance - withdraw;

                    balanceText = Convert.ToString(checkingBalance);

                    DisplayCheckingBalance(balanceText);

                    success = true;

                    transType = "Withdraw: ";

                    ++c_counter;
                }

            }

            //if the fast cash button is selected
            else if (checkingFastCashButton.Checked == true)
            {

                userAmount = checkingAmountTextBox.Text;

                //tryparse if statements to ensure that the entered amount is a number, not blank
                //is not higher than the balance, and is only in multiples of 20 through 100
                if (!Double.TryParse(userAmount, out fastcash))
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    checkingAmountTextBox.Text = "";
                    userAmount = "";
                    success = false;
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    success = false;
                }
                else if ((fastcash = Convert.ToDouble(userAmount)) > checkingBalance)
                {
                    MessageBox.Show("You cannot withdraw $" + userAmount + " because it is higher than your current balance. Please try again.");
                    success = false;
                }
                else if ((fastcash = Convert.ToDouble(userAmount)) != 20 && (fastcash = Convert.ToDouble(userAmount)) != 40 &&
                    (fastcash = Convert.ToDouble(userAmount)) != 60 && (fastcash = Convert.ToDouble(userAmount)) != 80 &&
                    (fastcash = Convert.ToDouble(userAmount)) != 100)
                {
                    MessageBox.Show("You can only withdraw in multiples of $20 up to a total of $100 when using Fast Cash. Please try again.");
                    success = false;
                }
                
                //prints the balance to the label
                else
                {
                    fastcash = Convert.ToDouble(userAmount);

                    checkingBalance = checkingBalance - fastcash;

                    balanceText = Convert.ToString(checkingBalance);
                    DisplayCheckingBalance(balanceText);

                    success = true;

                    transType = "Fast Cash: ";

                    ++c_counter;
                }
            }

            //if the transfer button is selected
            else if (checkingTransferButton.Checked == true)
            {

                userAmount = checkingAmountTextBox.Text;

                //tryparse if statements to ensure that the entered amount is a number, not blank
                //and not higher than the balance
                if (!Double.TryParse(userAmount, out transfer))
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    checkingAmountTextBox.Text = "";
                    userAmount = "";
                    success = false;
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    success = false;
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > checkingBalance)
                {
                    MessageBox.Show("You cannot transfer $" + userAmount + " because it is higher than your current balance. Please try again.");
                    success = false;
                }

                //prints the balance to the checking label as well as updating balance of the saving tab
                else
                {
                    transfer = Convert.ToDouble(userAmount);

                    checkingBalance = checkingBalance - transfer;

                    balanceText = Convert.ToString(checkingBalance);

                    DisplayCheckingBalance(balanceText);

                    savingBalance = savingBalance + transfer;

                    string savingBalanceText = Convert.ToString(savingBalance);

                    DisplaySavingBalance(savingBalanceText);

                    success = true;

                    transType = "Transfer: ";

                    ++c_counter;
                }

            }

            //if no radio buttons are selected
            else
            {
                MessageBox.Show("Please select either Deposit, Withdraw, Fast Cash, or Transfer");
                success = false;
            }

            // Create text if first time submitting
            if (c_counter == 1)
            {
                FileStream newfile = File.Create("cLog.txt");       // Create file (Wipes old)
                newfile.Close();

                // Setup header of text file
                StreamWriter writeFile = File.AppendText("cLog.txt");
                writeFile.WriteLine("----- Checking Account -----");
                writeFile.Close();
            }



            // If the operation completed successfuly
            // Write transaction to cLog
            if (success == true)
            {
                StreamWriter writeFile = File.AppendText("cLog.txt");                // Open file
                string trans = String.Format("{0,-10} {1,-7} {2,-9} {3,-9}",
                                    transType, userAmount, "Balance:", balanceText); // Format string spacing

                writeFile.WriteLine(trans);     // Write transaction to file
                writeFile.Close();

                // Add to list
                c_transList.Add(trans);
            }
            
        }

        private void savingSubmitButton_Click(object sender, EventArgs e)
        {
            //declaring strings for the entered amount and the balance label
            string balanceText = "";
            double deposit = 0;
            double fastcash = 0;
            double withdraw = 0;
            double transfer = 0;
            string userAmount = "";
            bool success = false;   // determines if trans action was successful
            string transType = "";  // The transaction type

            if (savingDepositButton.Checked == true)
            {
                userAmount = savingAmountTextBox.Text;

                //tryparse if statements to ensure that the entered amount is a number and not blank
                if (!Double.TryParse(userAmount, out deposit))
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    checkingAmountTextBox.Text = "";
                    userAmount = "";
                    success = false;
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    success = false;
                }

                //prints the balance to the label
                else
                {
                    deposit = Convert.ToDouble(userAmount);

                    savingBalance = savingBalance + deposit;

                    balanceText = Convert.ToString(savingBalance);

                    DisplaySavingBalance(balanceText);

                    success = true;

                    transType = "Deposit: ";

                    ++s_counter;

                }
            }

            //if the withdraw button is selected
            else if (savingWithdrawButton.Checked == true)
            {

                userAmount = savingAmountTextBox.Text;

                //tryparse if statements to ensure that the entered amount is a number, 
                //not blank, not higher than the balance, and not over $400
                if (!Double.TryParse(userAmount, out withdraw))
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    savingAmountTextBox.Text = "";
                    userAmount = "";
                    success = false;
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    success = false;
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > savingBalance)
                {
                    MessageBox.Show("You cannot withdraw $" + userAmount + " because it is higher than your current balance. Please try again.");
                    success = false;
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > 400)
                {
                    MessageBox.Show("You cannot withdraw more than $400 at once. Please try again.");
                    success = false;
                }
                
                //prints the balance to the label
                else
                {
                    withdraw = Convert.ToDouble(userAmount);

                    savingBalance = savingBalance - withdraw;

                    balanceText = Convert.ToString(savingBalance);
                    DisplaySavingBalance(balanceText);

                    success = true;

                    transType = "Withdraw: ";

                    ++s_counter;
                }
            }

            //if the fast cash button is selected
            else if (savingFastCashButton.Checked == true)
            {

                userAmount = savingAmountTextBox.Text;

                //tryparse if statements to ensure that the entered amount is a number, not blank
                //is not higher than the balance, and is only in multiples of 20 through 100
                if (!Double.TryParse(userAmount, out fastcash))
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    savingAmountTextBox.Text = "";
                    userAmount = "";
                    success = false;
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    success = false;
                }
                else if ((fastcash = Convert.ToDouble(userAmount)) > savingBalance)
                {
                    MessageBox.Show("You cannot withdraw $" + userAmount + " because it is higher than your current balance. Please try again.");
                    success = false;
                }
                else if ((fastcash = Convert.ToDouble(userAmount)) != 20 && (fastcash = Convert.ToDouble(userAmount)) != 40 &&
                    (fastcash = Convert.ToDouble(userAmount)) != 60 && (fastcash = Convert.ToDouble(userAmount)) != 80 &&
                    (fastcash = Convert.ToDouble(userAmount)) != 100)
                {
                    MessageBox.Show("You can only withdraw in multiples of $20 up to a total of $100 when using Fast Cash. Please try again.");
                    success = false;
                }
                
                //prints the balance to the label
                else
                {
                    fastcash = Convert.ToDouble(userAmount);

                    savingBalance = savingBalance - fastcash;

                    balanceText = Convert.ToString(savingBalance);
                    DisplaySavingBalance(balanceText);

                    success = true;

                    transType = "Fast Cash: ";

                    ++s_counter;
                }
            }

            //if the transfer button is selected
            else if (savingTransferButton.Checked == true)
            {

                userAmount = savingAmountTextBox.Text;

                //tryparse if statements to ensure that the entered amount is a number, not blank
                //and not higher than the balance
                if (!Double.TryParse(userAmount, out transfer))
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    savingAmountTextBox.Text = "";
                    userAmount = "";
                    success = false;
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    success = false;
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > savingBalance)
                {
                    MessageBox.Show("You cannot transfer $" + userAmount + " because it is higher than your current balance. Please try again.");
                    success = false;
                }
                
                //prints the balance to the saving textbox as well as updating the balance of the checking tab
                else
                {
                    transfer = Convert.ToDouble(userAmount);

                    savingBalance = savingBalance - transfer;

                    balanceText = Convert.ToString(savingBalance);

                    DisplaySavingBalance(balanceText);

                    checkingBalance = checkingBalance + transfer;

                    string checkingBalanceText = Convert.ToString(checkingBalance);

                    DisplayCheckingBalance(checkingBalanceText);

                    success = true;

                    transType = "Transfer: ";

                    ++s_counter;

                }

            }

            //if no radio buttons are selected
            else
            {
                MessageBox.Show("Please select either Deposit, Withdraw, Fast Cash, or Transfer");
                success = false;
            }

            // Create text if first time submitting
            if (s_counter == 1)
            {
                FileStream newfile = File.Create("sLog.txt");       // Create file (Wipes old)
                newfile.Close();

                // Setup header of text file
                StreamWriter writeFile = File.AppendText("sLog.txt");
                writeFile.WriteLine("----- Savings Account -----");
                writeFile.Close();
            }



            // If the operation completed successfuly
            // Write transaction to cLog
            if (success == true)
            {
                StreamWriter writeFile = File.AppendText("sLog.txt");                // Open file
                string trans = String.Format("{0,-10} {1,-7} {2,-9} {3,-9}",        
                                    transType, userAmount, "Balance:", balanceText); // Format string spacing

                writeFile.WriteLine(trans);     // Write transaction to file
                writeFile.Close();              // Close file

                // Add transaction to list
                s_transList.Add(trans);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkingClearButton_Click_1(object sender, EventArgs e)
        {
            //clearing the amount text box and resetting focus
            checkingAmountTextBox.Text = "";
            checkingAmountTextBox.Focus();
        }

        // Set the accept button (when user hits enter)
        private void checkingAmountTextBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = checkingSubmitButton; // Set the accept button
        }

        // Set the accept button (when user hits enter)
        private void savingAmountTextBox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = savingSubmitButton; // Set accept button
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void savingClearButton_Click_1(object sender, EventArgs e)
        {
            //clearing the amount text box and resetting focus
            savingAmountTextBox.Text = "";
            savingAmountTextBox.Focus();
        }
    }
}
