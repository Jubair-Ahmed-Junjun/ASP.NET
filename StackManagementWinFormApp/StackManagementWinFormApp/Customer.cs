using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackManagementWinFormApp
{
    public partial class Customer : Form
    {
        string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";

        public Customer()
        {
            InitializeComponent();
        }

        private void customerSaveButton_Click(object sender, EventArgs e)
        {
            StockManagement customer = new StockManagement();
            customer.customerName = customerNametextBox.Text;
            customer.customerPhone = customerPhoneTextBox.Text;
            saveCustomer(customer);
        }

        public void saveCustomer(StockManagement customerInfo)
        {

            SqlConnection sqlConnection = new SqlConnection(connect);
            string sqlQuery = "INSERT INTO Customer(CustomerName,CustomerPhone)VALUES('" + customerInfo.customerName + "','" + customerInfo.customerPhone + "')";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rowAffected >= 0)
            {
                MessageBox.Show("Data Save Successfully..!");
            }
            else
            {
                MessageBox.Show("Data not Saved");
            }

            sqlConnection.Open();
            SqlDataAdapter customerView = new SqlDataAdapter("SELECT * from Customer", sqlConnection);
            DataTable customerTable = new DataTable();
            customerView.Fill(customerTable);
            customerDataGridView.DataSource = customerTable;
        }

        private void itemLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Items items = new Items();
            this.Hide();
            items.Show();
        }

        private void customerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer customers = new Customer();
            this.Hide();
            customers.Show();
        }

        private void purchaseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Purchase purchase = new Purchase();
            this.Hide();
            purchase.Show();
        }

        private void saleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sale sale = new Sale();
            this.Hide();
            sale.Show();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();
            SqlDataAdapter customerView = new SqlDataAdapter("SELECT * from Customer", sqlConnection);
            DataTable customerTable = new DataTable();
            customerView.Fill(customerTable);
            customerDataGridView.DataSource = customerTable;
        }
    }
}
