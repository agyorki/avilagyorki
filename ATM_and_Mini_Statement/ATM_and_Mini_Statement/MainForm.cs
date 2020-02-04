using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_and_Mini_Statement
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

        private void displayMiniStatementButton_Click(object sender, EventArgs e)
        {
            //create an instance of messageform class
            MessageForm myMessageForm = new MessageForm();

            //display the form
            myMessageForm.ShowDialog();

        }

        private void checkingSubmitButton_Click(object sender, EventArgs e)
        {
            //declaring strings for the entered amount and the balance label
            string balanceText;
            double deposit = 0;
            double withdraw = 0;
            double fastcash = 0;
            double transfer = 0;
            string userAmount = "";

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
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                }

                //prints the balance to the label
                else
                {
                    deposit = Convert.ToDouble(userAmount);

                    checkingBalance = checkingBalance + deposit;

                    balanceText = Convert.ToString(checkingBalance);

                    DisplayCheckingBalance(balanceText);

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
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > checkingBalance)
                {
                    MessageBox.Show("You cannot withdraw $" + userAmount + " because it is higher than your current balance. Please try again.");
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > 400)
                {
                    MessageBox.Show("You cannot withdraw more than $400 at once. Please try again.");
                }

                //prints the balance to the label
                else
                {
                    withdraw = Convert.ToDouble(userAmount);

                    checkingBalance = checkingBalance - withdraw;

                    balanceText = Convert.ToString(checkingBalance);

                    DisplayCheckingBalance(balanceText);


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
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                }
                else if ((fastcash = Convert.ToDouble(userAmount)) > checkingBalance)
                {
                    MessageBox.Show("You cannot withdraw $" + userAmount + " because it is higher than your current balance. Please try again.");
                }
                else if ((fastcash = Convert.ToDouble(userAmount)) != 20 && (fastcash = Convert.ToDouble(userAmount)) != 40 &&
                    (fastcash = Convert.ToDouble(userAmount)) != 60 && (fastcash = Convert.ToDouble(userAmount)) != 80 &&
                    (fastcash = Convert.ToDouble(userAmount)) != 100)
                {
                    MessageBox.Show("You can only withdraw in multiples of $20 up to a total of $100 when using Fast Cash. Please try again.");
                }
                
                //prints the balance to the label
                else
                {
                    fastcash = Convert.ToDouble(userAmount);

                    checkingBalance = checkingBalance - fastcash;

                    balanceText = Convert.ToString(checkingBalance);
                    DisplayCheckingBalance(balanceText);


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
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > checkingBalance)
                {
                    MessageBox.Show("You cannot transfer $" + userAmount + " because it is higher than your current balance. Please try again.");
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

                }

            }

            //if no radio buttons are selected
            else
            {
                MessageBox.Show("Please select either Deposit, Withdraw, Fast Cash, or Transfer");
            }



        }

        private void savingSubmitButton_Click(object sender, EventArgs e)
        {
            //declaring strings for the entered amount and the balance label
            string balanceText;
            double deposit = 0;
            double fastcash = 0;
            double withdraw = 0;
            double transfer = 0;
            string userAmount = "";

            if (savingDepositButton.Checked == true)
            {
                userAmount = savingAmountTextBox.Text;

                //tryparse if statements to ensure that the entered amount is a number and not blank
                if (!Double.TryParse(userAmount, out deposit))
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                    checkingAmountTextBox.Text = "";
                    userAmount = "";
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                }

                //prints the balance to the label
                else
                {
                    deposit = Convert.ToDouble(userAmount);

                    savingBalance = savingBalance + deposit;

                    balanceText = Convert.ToString(savingBalance);

                    DisplaySavingBalance(balanceText);

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
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > savingBalance)
                {
                    MessageBox.Show("You cannot withdraw $" + userAmount + " because it is higher than your current balance. Please try again.");
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > 400)
                {
                    MessageBox.Show("You cannot withdraw more than $400 at once. Please try again.");
                }
                
                //prints the balance to the label
                else
                {
                    withdraw = Convert.ToDouble(userAmount);

                    savingBalance = savingBalance - withdraw;

                    balanceText = Convert.ToString(savingBalance);
                    DisplaySavingBalance(balanceText);


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
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                }
                else if ((fastcash = Convert.ToDouble(userAmount)) > savingBalance)
                {
                    MessageBox.Show("You cannot withdraw $" + userAmount + " because it is higher than your current balance. Please try again.");
                }
                else if ((fastcash = Convert.ToDouble(userAmount)) != 20 && (fastcash = Convert.ToDouble(userAmount)) != 40 &&
                    (fastcash = Convert.ToDouble(userAmount)) != 60 && (fastcash = Convert.ToDouble(userAmount)) != 80 &&
                    (fastcash = Convert.ToDouble(userAmount)) != 100)
                {
                    MessageBox.Show("You can only withdraw in multiples of $20 up to a total of $100 when using Fast Cash. Please try again.");
                }
                
                //prints the balance to the label
                else
                {
                    fastcash = Convert.ToDouble(userAmount);

                    savingBalance = savingBalance - fastcash;

                    balanceText = Convert.ToString(savingBalance);
                    DisplaySavingBalance(balanceText);

        
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
                }
                else if (userAmount == "")
                {
                    MessageBox.Show("Please enter a number into the Amount textbox");
                }
                else if ((withdraw = Convert.ToDouble(userAmount)) > savingBalance)
                {
                    MessageBox.Show("You cannot transfer $" + userAmount + " because it is higher than your current balance. Please try again.");
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
                    
                }

            }

            //if no radio buttons are selected
            else
            {
                MessageBox.Show("Please select either Deposit, Withdraw, Fast Cash, or Transfer");
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

        private void savingClearButton_Click_1(object sender, EventArgs e)
        {
            //clearing the amount text box and resetting focus
            savingAmountTextBox.Text = "";
            savingAmountTextBox.Focus();
        }
    }
}
