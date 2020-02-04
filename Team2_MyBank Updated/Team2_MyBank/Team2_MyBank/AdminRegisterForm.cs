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
    public partial class AdminRegisterForm : Form
    {
        public string _username = "", _password = "";

        public AdminRegisterForm()
        {
            InitializeComponent();
            passwordTextbox.PasswordChar  = '*';
            confirmPWTextbox.PasswordChar = '*';
        }

        // Set the accept button
        private void confirmPWTextbox_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = submitButton;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Check password and confirm password are the same
            if (passwordTextbox.Text == confirmPWTextbox.Text)
            {
                this._username = usernameTextbox.Text;
                this._password = passwordTextbox.Text;
            }
            else
            {
                MessageBox.Show("The passwords do not match. Please try again.");
                return;
            }

            // Close the form and return values
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
