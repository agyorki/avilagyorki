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
using System.Net;
using System.Net.Mail;

namespace Team2_MyBank
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';     // Sets every char to * for hidden
        }

        // Contains an admin user's username and password
        struct AdminUser
        {
            public  string userName;
            public  string password;
        }

        // List that will contain all admin users
        List<AdminUser> adminUserList = new List<AdminUser>();

        private void closeButton_Click(object sender, EventArgs e)
        {
            //  close the form
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Get text from the textboxes and format
            string username = usernameTextBox.Text.ToUpper();
            string password = passwordTextBox.Text;

            // Create double array of group member names
            // Each group member is a VALID login
            string[,] VALID_LOGIN_LIST = new string[,]
            {
                // 0 { 0 , 1 }, 1 { 0 , 1 }, 2 { 0 , 1 }
                { "DOMINIC" , "Ditirro" }, { "GRANT", "Greene" },
                { "COLIN" , "Kuchenmeister" }, { "AVILA", "Gyorki" },
                { "JAYNA" , "Le" }, { "NATALIA" , "Dragan" }
            };

            const int USERNAME_SPOT = 0, PASSWORD_SPOT = 1;
            bool in_list = false; // determines if the entered credentials are in the list

            // Add adminUser(s) to adminUserList from the VALID_LOGIN_LIST
            for (int i=0; i < VALID_LOGIN_LIST.GetLength(0); ++i)
            {
                AdminUser tempAdmin = new AdminUser();

                tempAdmin.userName = VALID_LOGIN_LIST[i, USERNAME_SPOT];    // Set userName
                tempAdmin.password = VALID_LOGIN_LIST[i, PASSWORD_SPOT];    // Set password

                adminUserList.Add(tempAdmin);       // Holds all adminUsers
            }

            // Validate the username and password are contained in adminUserList
            for (int i=0; i < adminUserList.Count; ++i) //getlength(0) = length, getlength(1) = width
            {
                // Check if adminUser at index matches username and password
                if (adminUserList[i].userName == username &&
                    adminUserList[i].password == password)
                {
                    MessageBox.Show("The login was successful");
                    in_list = true;
                    break;
                }
            } 
            
            // If the entered credentials were in list
            if (in_list)
            {
                // Perform security check
                if (SecurityCheck() == 1)
                {
                    // The admin is AUTHORIZED
                    // Display the admin features
                    this.Hide(); 
                    AdminMainForm mainForm = new AdminMainForm();
                    mainForm.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                // Entered credentials not in the list
                MessageBox.Show("The username or password was incorrect.");
            }
        }

        // Runs a security check
        // Puts a random num 6-digits into a file 
        private int SecurityCheck()
        {
            // Create the random code
            Random rnd = new Random();
            int securityCode = rnd.Next(100000, 1000000); // random from 100,000 - 999,999

            // Create the text file to store the code
            string fileName = "authorization.txt";
            StreamWriter writer = File.CreateText(fileName);

            // Write the code to the file
            writer.WriteLine(securityCode);
            writer.Close();

            // Open the form for user to enter code to valdate
            securityCodeForm securityForm = new securityCodeForm(fileName);

            // Show testDialog as a model dialog and determine if DialogResult = OK.
            if (securityForm.ShowDialog() == DialogResult.OK)   // showialog(this)?
            {
                // The user entered the correct code
                MessageBox.Show("Code entered successful");
                securityForm.Dispose();
                return 1;
            }
            else
            {
                // The user CANCELLED the code input
                MessageBox.Show("The operation was cancelled");
                securityForm.Dispose();
                return 0;
            }
        }

        private void forgotPWLinklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("A message has been sent to your registered device. "
            //                + "Please follow the instructions to reset your password.");

            SendEmail emailForm = new SendEmail();
            emailForm.ShowDialog();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            AdminRegisterForm regForm = new AdminRegisterForm();
            this.Hide();

            // Open register form and create new admin user and add user to list
            var result = regForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                AdminUser temp = new AdminUser();
                temp.userName  = regForm._username.ToUpper();
                temp.password  = regForm._password;
                adminUserList.Add(temp);            // Add user to the list
            }

            this.Show();
            usernameTextBox.Focus();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
