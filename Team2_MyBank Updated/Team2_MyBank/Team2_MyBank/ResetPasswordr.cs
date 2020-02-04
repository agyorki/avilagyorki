using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team2_Grant_Greene_9A
{
    public partial class ResetPasswordr : Form
    {
        public ResetPasswordr()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (ResetPassBox1.ToString() == ResetPassBoxVerify.ToString())
            {
                MessageBox.Show("Your password was successfully changed.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Your passwords must match.");
            }
        }
    }
}
