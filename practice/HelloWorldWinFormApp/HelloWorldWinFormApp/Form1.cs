using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void alertButton_Click(object sender, EventArgs e)
        {
            string userInput = userInputTextBox.Text;
            MessageBox.Show("Hey,I'am "+userInput);
        }

    }
}
