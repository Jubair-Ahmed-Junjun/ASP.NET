using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInfoWinFormApp
{
    public partial class Form1 : Form
    {
        Person aPerson = new Person();
        public Form1()
        {
            InitializeComponent();
        }

        
        private void saveButton_Click(object sender, EventArgs e)
        {
            aPerson.firstName = firstNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;
            aPerson.fathersName = fathersNameTextBox.Text;
            aPerson.mothersName = mothersNameTextBox.Text;
            aPerson.address = addressTextBox.Text;
            MessageBox.Show(@"Your Information has been saved Successfully" + MessageBoxIcon.Information);
            Clear();
        }

        private void showAllInfoButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = aPerson.firstName;
            lastNameTextBox.Text = aPerson.lastName;
            fathersNameTextBox.Text = aPerson.fathersName;
            mothersNameTextBox.Text = aPerson.mothersName;
            addressTextBox.Text = aPerson.address;
            Clear();
        }

        private void fathersNameButton_Click(object sender, EventArgs e)
        {
            aPerson.fathersName = fathersNameTextBox.Text;
            Clear();
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            aPerson.address = addressTextBox.Text;
            Clear();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            aPerson.firstName = firstNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;
            Clear();
        }

        private void Clear()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fathersNameTextBox.Clear();
            mothersNameTextBox.Clear();
            addressTextBox.Clear();
        }
    }
}
