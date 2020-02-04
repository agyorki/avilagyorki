using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void italianButton_Click(object sender, EventArgs e)
        {

            translationLabel.Text = "Buongiorno";

        }

        private void spanishButton_Click(object sender, EventArgs e)
        {

            translationLabel.Text = "Buenos Dias";


        }

        private void germanButton_Click(object sender, EventArgs e)
        {

            translationLabel.Text = "Guten Morgen";

        }

        private void frenchButton_Click(object sender, EventArgs e)
        {

            translationLabel.Text = "Bonjour";

        }

        private void portugueseButton_Click(object sender, EventArgs e)
        {

            translationLabel.Text = "Bom Dia";
          

        }
    }
}
