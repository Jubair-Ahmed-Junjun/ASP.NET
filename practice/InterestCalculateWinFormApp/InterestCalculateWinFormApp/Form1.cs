using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculateWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bankComboBox.SelectedItem.ToString() == "BRAC")
            {
                double anualRate = 6;
                double balance = Convert.ToDouble(balanceTextBox.Text);
                double year = Convert.ToDouble(timeYearTextBox.Text);

                double totalInterest = (balance * anualRate * year) / 100;

                totalInterestAmountLabel.Text = totalInterest.ToString();
            }

            if (bankComboBox.SelectedItem.ToString() == "DBBL")
            {
                double anualRate = 7;
                double balance = Convert.ToDouble(balanceTextBox.Text);
                double year = Convert.ToDouble(timeYearTextBox.Text);

                double totalInterest = (balance* anualRate * year)/100;

                totalInterestAmountLabel.Text = totalInterest.ToString();
            }

            if (bankComboBox.SelectedItem.ToString() == "HSBC")
            {
                double anualRate = 8;
                double balance = Convert.ToDouble(balanceTextBox.Text);
                double year = Convert.ToDouble(timeYearTextBox.Text);

                double totalInterest = (balance * anualRate * year) / 100;

                totalInterestAmountLabel.Text = totalInterest.ToString();
            }
        }
    }
}
