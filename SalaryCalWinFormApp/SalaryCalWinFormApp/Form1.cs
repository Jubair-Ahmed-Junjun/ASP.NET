using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.basicSlaray = Convert.ToDouble(basicSalaryTextBox.Text);
            aSalary.houseRentPercentage = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medicalAllowancePer = Convert.ToDouble(medicalAllowanceTextBox.Text);
            double totalSalary = aSalary.basicSlaray + ((aSalary.basicSlaray * aSalary.houseRentPercentage) / 100) + ((aSalary.basicSlaray * aSalary.medicalAllowancePer) / 100);
            totalSalaryTextBox.Text = totalSalary.ToString();
        }
    }
}
