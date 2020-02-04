using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_MyBank
{
    public partial class morgCalc : Form
    {
        public morgCalc()
        {
            InitializeComponent();
        }

        private double count = 0, totalOfAllLoans = 0, totalMonthlyPayments = 0, averageMonthlyPayment = 0;

        private void ClearButton_Click(object sender, EventArgs e)
        {
            amtLoanTextBox.Text = "";
            annualROITextBox.Text = "";
            monthlyPaymentLabel.Text = "";
            numberOfYearsTextBox.Text = "";
            amtLoanTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double m, p, r, n;

            if (!double.TryParse(amtLoanTextBox.Text, out p))
            {
                MessageBox.Show("Invalid value");
            }
            else if (!double.TryParse(annualROITextBox.Text, out r))
            {
                MessageBox.Show("Invalid value");
            }
            else if (!double.TryParse(numberOfYearsTextBox.Text, out n))
            {
                MessageBox.Show("Invalid Value");
            }
            else
            {
                //monthly payment calculation
                r *= .01 / 12;
                n *= 12;
                m = p * (r * Math.Pow(1 + r, n)) / (Math.Pow(1 + r, n) - 1);

                //update montly payment text box
                monthlyPaymentLabel.Text = m.ToString("0.##");

                //update summary
                count++;
                totalOfAllLoans += p;
                totalMonthlyPayments += m;
                averageMonthlyPayment = totalMonthlyPayments / count;

                totalOfAllLoansLabel.Text = totalOfAllLoans.ToString("0.##");
                totalMonthlyPaymentsLabel.Text = totalMonthlyPayments.ToString("0.##");
                AvgMonthlyPaymentsLabel.Text = averageMonthlyPayment.ToString("0.##");
            }
        }
    }
}
