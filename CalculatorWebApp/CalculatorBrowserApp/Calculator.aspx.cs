using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorBrowserApp
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int firstNum = Convert.ToInt32(firstNumTextBox.Text.ToString());
            int secondNum = Convert.ToInt32(secondNumTextBox.Text.ToString());
            int add = firstNum + secondNum;
            resultTextBox.Text = add.ToString();
        }

        protected void subButton_Click(object sender, EventArgs e)
        {
            int firstNum = Convert.ToInt32(firstNumTextBox.Text.ToString());
            int secondNum = Convert.ToInt32(secondNumTextBox.Text.ToString());
            int sub = firstNum - secondNum;
            resultTextBox.Text = sub.ToString();
        }

        protected void mulButton_Click(object sender, EventArgs e)
        {
            int firstNum = Convert.ToInt32(firstNumTextBox.Text.ToString());
            int secondNum = Convert.ToInt32(secondNumTextBox.Text.ToString());
            int mul = firstNum * secondNum;
            resultTextBox.Text = mul.ToString();
        }

        protected void divButton_Click(object sender, EventArgs e)
        {
            double firstNum = Convert.ToDouble(firstNumTextBox.Text.ToString());
            double secondNum = Convert.ToDouble(secondNumTextBox.Text.ToString());
            double div = firstNum / secondNum;
            resultTextBox.Text = div.ToString();
        }

        protected void reminderButton_Click(object sender, EventArgs e)
        {
            int firstNum = Convert.ToInt32(firstNumTextBox.Text.ToString());
            int secondNum = Convert.ToInt32(secondNumTextBox.Text.ToString());
            int rem = firstNum % secondNum;
            resultTextBox.Text = rem.ToString();
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
            firstNumTextBox.Text = string.Empty;
            secondNumTextBox.Text = string.Empty;
        }
    }
}