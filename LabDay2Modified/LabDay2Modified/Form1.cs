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


namespace LabDay2Modified
{

    struct CustomersNames
    {
        public string custID;
        public string firstName;
        public string lastName;
        public string accountID;
    }

    struct AccountNumbers
    {
        public string acctID;
        public string accountType;
        public string accountNumber;
        public string accountAmt;
    }

    struct LoanInfo
    {
        public string loanID;
        public string loanYears;
        public string loanIntRate;
        public string loanAmt;
        public string customerID;
        public string loanType;
    }

    public partial class Form1 : Form
    {
        private List<CustomersNames> customerList = new List<CustomersNames>();
        private List<AccountNumbers> accountList = new List<AccountNumbers>();
        private List<LoanInfo> loanList = new List<LoanInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadCustFile()
        {
            try
            {
                StreamReader inputFile;
                string line;

               // CustomersNames entry = new CustomersNames();

                char[] delim = { ',' };

                inputFile = File.OpenText("customers.txt");

                while (!inputFile.EndOfStream)
                {
                    CustomersNames entry = new CustomersNames();

                    line = inputFile.ReadLine();

                    string[] tokens = line.Split(delim);

                    entry.custID = tokens[0];
                    entry.firstName = tokens[1];
                    entry.lastName = tokens[2];
                    entry.accountID = tokens[3];

                    customerList.Add(entry);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadAcctFile()
        {
            try
            {
                StreamReader inputFile;
                string line;

             //   AccountNumbers entry = new AccountNumbers();

                char[] delim = { ',' };

                inputFile = File.OpenText("accounts.txt");

                while (!inputFile.EndOfStream)
                {
                    AccountNumbers entry = new AccountNumbers();

                    line = inputFile.ReadLine();

                    string[] tokens = line.Split(delim);

                    entry.acctID = tokens[0];
                    entry.accountNumber = tokens[1];
                    entry.accountType = tokens[2];
                    entry.accountAmt = tokens[3];

                    accountList.Add(entry);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadLoanFile()
        {
            try
            {
                StreamReader inputFile;
                string line;

               // LoanInfo entry = new LoanInfo();

                char[] delim = { ',' };

                inputFile = File.OpenText("loans.txt");

                while (!inputFile.EndOfStream)
                {
                    LoanInfo entry = new LoanInfo();

                    line = inputFile.ReadLine();

                    string[] tokens = line.Split(delim);

                    entry.customerID = tokens[0];
                    entry.loanID = tokens[1];
                    entry.loanType = tokens[2];
                    entry.loanYears = tokens[3];
                    entry.loanIntRate = tokens[4];
                    entry.loanAmt = tokens[5];

                    loanList.Add(entry);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustInfo()
        {
            foreach(CustomersNames entry in customerList)
            {
                customerListBox.Items.Add(entry.custID + " " + entry.firstName + " " + entry.lastName);
            }
        }

        private void AcctInfo()
        {
            foreach (AccountNumbers entry in accountList)
            {
                accountListBox.Items.Add(entry.accountNumber + " " + entry.accountType + " " + entry.accountAmt);
            }
        }

        private void LoansInfo()
        {
            foreach (LoanInfo entry in loanList)
            {
                loanListBox.Items.Add(entry.loanID + " " + entry.loanType + " " + entry.loanYears+" "+entry.loanIntRate+" "+entry.loanAmt);
            }
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = customerListBox.SelectedIndex;
            customerAccountID.Text = "Account ID: " + customerList[index].accountID;
        }

        private void loanListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = loanListBox.SelectedIndex;
            loanCustomerID.Text = "Customer ID: " + loanList[index].customerID;
        }

        private void accountListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = accountListBox.SelectedIndex;
            accountAccountID.Text = "Account ID: " + accountList[index].acctID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadCustFile();
            CustInfo();

            ReadAcctFile();
            AcctInfo();

            ReadLoanFile();
            LoansInfo();
        }

    }
}
