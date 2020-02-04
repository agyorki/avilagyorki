using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Team2_Grant_Greene_9A;

namespace Team2_MyBank
{
    public partial class SendEmail : Form
    {
        
        public static string to;
        public SendEmail()
        {
            InitializeComponent();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            int randomCode = 123456;
            MailMessage message =new MailMessage();
            to = (EmailTextBox.Text).ToString();
            from = "ggreene7@kent.edu";
            pass = "password1234";
            messageBody = "Your reset code is: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password Reset";
            SmtpClient smtp = new SmtpClient("smpt.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code sent successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            int randomCode = 123456;
            if (randomCode.ToString() == (EmailVerifyCodeButton.Text).ToString())
            {
                ResetPasswordr RP = new ResetPasswordr();
                this.Hide();
                RP.Show(); 
            }
            else
            {
                MessageBox.Show("Incorrect Code");
            }
        }
    }
}
