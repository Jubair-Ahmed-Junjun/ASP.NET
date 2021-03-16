using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinFormApp
{
    public partial class Form1 : Form
    {
        //int result = 0;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
            resultTextBox.Clear();
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            if(firstNumberTextBox.Text!= "" && secondNumberTextBox.Text!= "")
            {
               double result = firstNumber + secondNumber;
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please fill up field..!");
            }
            
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                double result = firstNumber - secondNumber;
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please fill up field..!");
            }

        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                double result = firstNumber * secondNumber;
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please fill up field..!");
            }

        }

        private void divButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                double result = firstNumber / secondNumber;
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please fill up field..!");
            }

        }

        private void remButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                double result = firstNumber % secondNumber;
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please fill up field..!");
            }
            
        }

    }
}
