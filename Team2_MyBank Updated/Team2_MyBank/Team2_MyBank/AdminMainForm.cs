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
    public partial class AdminMainForm : Form
    {
        struct Customer
        {
            public int    customerID;
            public int    accountID;
            public string firstName;
            public string lastName;
        }

        struct Account
        {
            public int    accountNumber;
            public int    type;
            public int    accountID;
            public double amount;
        }

        struct Loan
        {
            public int    loanID;
            public int    years;
            public int    amount;
            public int    type;
            public int    customerID;
            public double interestRate;
        }

        private List<Customer> customerList =
            new List<Customer>();

        private List<Account> accountList =
            new List<Account>();

        private List<Loan> loanList =
            new List<Loan>();

        // bool to control reading the file only once
        public bool firstCustRead = true,
                    firstAccRead  = true,
                    firstLoanRead = true;

        public AdminMainForm()
        {
            InitializeComponent();
        }

        // Reads the customer file and stores its information in customerList
        private void ReadCustomer()
        {
            // Clear the current list
            //customerList.Clear();

            try
            {
                StreamReader inputFile = File.OpenText("customers.txt");
                string line;

                char delim = ',';

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    //split line
                    string[] tokens = line.Split(delim);

                    //store tokens in objects
                    Customer customerEntry = new Customer();
                    customerEntry.customerID = int.Parse(tokens[0]);
                    customerEntry.firstName = tokens[1];
                    customerEntry.lastName = tokens[2];
                    customerEntry.accountID = int.Parse(tokens[3]);

                    // Add entry object to list
                    customerList.Add(customerEntry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Read the account file and store its information in accountList
        private void ReadAccount()
        {
            // Clear the current list
            //accountList.Clear();

            try
            {
                StreamReader inputFile = File.OpenText("accounts.txt");
                string line;

                char delim = ',';

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    //split line
                    string[] tokens = line.Split(delim);

                    //store tokens in objects
                    Account accountEntry = new Account();
                    accountEntry.accountID = int.Parse(tokens[0]);
                    accountEntry.accountNumber = int.Parse(tokens[1]);
                    accountEntry.type = int.Parse(tokens[2]);
                    accountEntry.amount = double.Parse(tokens[3]);

                    accountList.Add(accountEntry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Read the loan file and store its information in loanList
        private void ReadLoan()
        {
            // Clear the current list
            //loanList.Clear();
            try
            {
                StreamReader inputFile = File.OpenText("loans.txt");
                string line;

                char delim = ',';


                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    //split line
                    string[] tokens = line.Split(delim);

                    //store tokens in objects
                    Loan loanEntry = new Loan();
                    loanEntry.customerID    = int.Parse(tokens[0]);
                    loanEntry.loanID        = int.Parse(tokens[1]);
                    loanEntry.type          = int.Parse(tokens[2]);
                    loanEntry.years         = int.Parse(tokens[3]);
                    loanEntry.interestRate  = double.Parse(tokens[4]);
                    loanEntry.amount        = int.Parse(tokens[5]);

                    loanList.Add(loanEntry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Close the form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clears previous listboxes and displays info from the selected list(s)
        private void restoreButton_Click(object sender, EventArgs e)
        {
            // Clear the listboxes if Checked

            if (customersCheckbox.Checked)
                customersListBox.Items.Clear();

            if (accountsCheckbox.Checked)
                accountsListBox.Items.Clear();

            if (loansCheckbox.Checked)
                loansListBox.Items.Clear();

            // display the data from accountsList to the listbox
            string line;
            if (accountsCheckbox.Checked)
            {
                if (firstAccRead)       // Read the account file only once
                {      
                    ReadAccount();
                    firstAccRead = false;
                }

                foreach (Account entry in accountList)
                {
                    line = (entry.accountNumber + ", " +
                            entry.type  + ", " +
                            entry.amount);
                    accountsListBox.Items.Add(line);
                }
            }

            // Display the data from customerslist to the listbox
            if (customersCheckbox.Checked)
            {
                if (firstCustRead)      // Read the customer file only once
                {     
                    ReadCustomer();
                    firstCustRead = false;
                }

                foreach (Customer entry in customerList)
                {
                    line = (entry.customerID + ", " +
                            entry.firstName  + ", " +
                            entry.lastName);
                    customersListBox.Items.Add(line);
                }
            }

            // Display the data from loanslist to the listbox
            if (loansCheckbox.Checked)
            {
                if (firstLoanRead)      // Read the loan file only once
                {      
                    ReadLoan();
                    firstLoanRead = false;
                }

                foreach (Loan entry in loanList)
                {
                    line = (entry.loanID + ", " +
                            entry.type   + ", " +
                            entry.interestRate + ", " +
                            entry.amount);
                    loansListBox.Items.Add(line);
                }
            }
        }

        // Clear the form fields
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the lsitboxes  
            customersListBox.Items.Clear();
            accountsListBox.Items.Clear();
            loansListBox.Items.Clear();

            // Clear the textboxes
            customersTextbox.Text = "";
            accountsTextbox.Text  = "";
            loansListBox.Text     = "";

            // Uncheck the checkboxes
            customersCheckbox.Checked = false;
            accountsCheckbox.Checked  = false;
            loansCheckbox.Checked     = false;
        }

        // Set the accept button when focused
        private void customersTextbox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = addRecordButton;
        }

        // Set the accept button when focused
        private void laonsTextbox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = addRecordButton;
        }

        // Set the accept button when focused
        private void accountsTextbox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = addRecordButton;
        }

        // Write information from the lists of structures into the files
        private void backupButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter filenames to store information");
        }

        // Add record to specific list if checked
        private void addRecordButton_Click(object sender, EventArgs e)
        {
            string[] line;      // The retrieved line from the user

            Customer cust = new Customer();
            // ######## Adding to customer list ##########
            if (customersCheckbox.Checked)
            {
                // Split the line
                line = customersTextbox.Text.Split(',');

                // Store info from the entered line
                try
                {
                    cust.customerID = int.Parse(line[0].Trim());
                    cust.firstName  = line[1].Trim();
                    cust.lastName   = line[2].Trim();
                    cust.accountID  = int.Parse(line[3].Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The customer information was formatted incorrectly");
                    return;
                }
                // Add new record to list
                customerList.Add(cust);
            }

            Account acc = new Account();
            // ######### Adding to account list ############
            if (accountsCheckbox.Checked)
            {
                // Split the line
                line = accountsTextbox.Text.Split(',');

                // Store info from the entered line
                try
                {
                    acc.accountID     = int.Parse(line[0].Trim());
                    acc.accountNumber = int.Parse(line[1].Trim());
                    acc.type          = int.Parse(line[2].Trim());
                    acc.amount        = double.Parse(line[3].Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The entered information was formatted incorrectly");
                    return;
                }

                // Add new record to list
                accountList.Add(acc);
            }

            Loan newLoan = new Loan();
            //######### Adding to loanlist ##########
            if (loansCheckbox.Checked)
            {
                line = laonsTextbox.Text.Split(',');

                // Store info from the entered line
                try
                {
                    newLoan.loanID       = int.Parse(line[0].Trim());
                    newLoan.type         = int.Parse(line[1].Trim());
                    newLoan.interestRate = double.Parse(line[2].Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The entered information was formatted incorrectly");
                    return;
                }

                // Add new record to list
                loanList.Add(newLoan);
            }
        }
    }
}
