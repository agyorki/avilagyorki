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
    public partial class LoansApplication : Form
    {
        private int number;
        public LoansApplication()
        {
            InitializeComponent();
        }

        // Determines if ssn is int after removing '-'
        // negates: 123-ab-1234
        private bool isNum(string _ssn)
        {
            // Remove the '-'s in xxx-xx-xxxx
            _ssn = _ssn.Remove(3, 1);
            _ssn = _ssn.Remove(5, 1);

            int num;
            if (int.TryParse(_ssn, out num))
                return true;


            return false;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text,
               MI = MiddleInitialTextBox.Text, Street = streettextbox.Text, City = citytextbox.Text
               , Employer = employertextbox.Text , SSN = SSNtextbox.Text;

            //property values are set to the correct max length in the textboxes

            if (LastName.Length < 30 && LastName.Length > 0)
            {
                if (FirstName.Length < 20 && FirstName.Length > 0)
                {
                    if (MI.Length == 2)
                    {

                        if (MarriedRadioButton.Checked || DivorcedRadioButton.Checked || UnmarriedRadioButton.Checked)
                        {
                            if (MaleRadioButton.Checked || FemaleRadioButton.Checked)
                            {
                                //This is actually the check for SSN, I just haven't implemented it yet
                                if (SSN.Length == 11 && SSN[3] == '-' && SSN[6] == '-' && isNum(SSN) == true)
                                {
                                    if (int.TryParse(numberTextBox.Text, out number))
                                    {
                                        if (Street.Length < 20)
                                        {
                                            if (City.Length < 20)
                                            {
                                                if (Stateslistbox.SelectedIndex >= 0)
                                                {
                                                    if (Employer.Length < 40)
                                                    {
                                                        if (JobpositioncheckedListBox.SelectedIndex >= 0)
                                                        {
                                                            try
                                                            {
                                                                //names constants
                                                                const double MINIMUM_SALARY = 40000;
                                                                const int MINIMUM_YEARS_ON_JOB = 5;

                                                                //local variable
                                                                double salary;
                                                                int yearsworked;

                                                                //Get the salary and years on the job.
                                                                salary = double.Parse(SalaryTextBox.Text);
                                                                yearsworked = int.Parse(yearsworkedtextbox.Text);

                                                                //Determine whether the user qualifies

                                                                if (yearsworked >= MINIMUM_YEARS_ON_JOB || yearsworked >= 2 && salary >= MINIMUM_SALARY)
                                                                {
                                                                    if (CarRadiobutton.Checked || HouseRadioButton.Checked || SchoolRadioButton.Checked || BusinessotherradioButton.Checked)

                                                                    {
                                                                        MessageBox.Show("Congratulations! You're qualified for the loan");

                                                                        //Avila's addition to Colin's code for writing to a text file
                                                                        StreamWriter loanFile = File.AppendText("loans_applications.txt");
                                                                        loanFile.WriteLine(FirstName + "," + LastName + "," + MI + "," + Street + ","
                                                                            + City + "," + Employer + "," + SSN);

                                                                        loanFile.Close();
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Please select the type of loan");
                                                                    }

                                                                }
                                                                else
                                                                {

                                                                    //the user does not qualify
                                                                    MessageBox.Show("You do not qualify for any loans.");

                                                                }


                                                            }
                                                            catch (Exception)
                                                            {
                                                                //display an error message
                                                                MessageBox.Show("Please enter a number in both fields");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Please select one or more job positions");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Employer should be less than 40 characters");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please select a state");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("City should be less than 20 characters");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Street should be less than 20 characters");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Address Number needs to be an integer");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Your Social Security # is invalid");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please select a Gender");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select marital status");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Middle Initial is one letter, then a period");

                    }
                }
                else
                {
                    MessageBox.Show("First Name is characters only");

                }
            }
            else
            {
                MessageBox.Show("Last Name is characters only");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Text        = "";
            FirstNameTextBox.Text       = "";
            MiddleInitialLabel.Text     = "";
            AgeComboBox.Text            = "";
            SSNtextbox.Text             = "";
            numberTextBox.Text          = "";
            streettextbox.Text          = "";
            citytextbox.Text            = "";
            employertextbox.Text        = "";
            yearsworkedtextbox.Text     = "";
            SalaryTextBox.Text          = "";
        }
    }
}
