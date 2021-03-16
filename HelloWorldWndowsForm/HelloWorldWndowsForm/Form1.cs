using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWndowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            string firstName = firstTextBox.Text;
            string lastName = LastTextBox.Text;
            string fullName = firstName+ " " + lastName;
            MessageBox.Show(fullName);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
