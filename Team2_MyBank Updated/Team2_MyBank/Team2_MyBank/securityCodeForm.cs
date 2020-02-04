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
    public partial class securityCodeForm : Form
    {
        public string line;     // The holder for the code passed by login
        public string file;     // Holds the file name

        public securityCodeForm(string fileName)
        {
            InitializeComponent();

            // Get the code from the file and (display)
            file = fileName;
            StreamReader readFile = File.OpenText(file);
            line = readFile.ReadLine();
            codeOutputLabel.Text = line;     // Display code
            readFile.Close();
        }

        // Validates the code entered by the user was the code generated
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Compares the security code
            if (securityCodeInputTextbox.Text == line)
            {
                // The code is valid
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("The security code entered was invalid.");
            }
        }
    }
}
