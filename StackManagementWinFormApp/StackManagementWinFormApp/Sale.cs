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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }
        string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";
        private object sqlConnection;

        private void button1_Click(object sender, EventArgs e)
        {
            StockManagement sale = new StockManagement();
            sale.quantity = saleQuantityTextBox.Text;
            sale.itemName = saleItemNameComboBox.Text;
            sale.customerName = customerComboBox.Text;
            sale.unitPrice = saleUnitPriceTextBox.Text;
            int total = Convert.ToInt32(saleQuantityTextBox.Text) * Convert.ToInt32(saleUnitPriceTextBox.Text);
            sale.totalPrice = saleTotalPriceTextBox.Text = total.ToString();
            saveSaleInfo(sale);
        }


        public void saveSaleInfo(StockManagement tempSale)
        {
            string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "INSERT INTO Sale (ItemName,Customer,Quantity, UnitPrice, TotalPrice) " +
            "VALUES('" + tempSale.itemName + "', '" + tempSale.customerName + "','" + tempSale.quantity + "', '" + tempSale.unitPrice + "','" + tempSale.totalPrice + "');";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Successfully Saved");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }

            //Data Grid View

            sqlConnection.Open();
            SqlDataAdapter purchaseView = new SqlDataAdapter("SELECT * from Sale", sqlConnection);
            DataTable purchaseTable = new DataTable();
            purchaseView.Fill(purchaseTable);
            saleDataGridView.DataSource = purchaseTable;

            populateComboBox();
            populateCustomerComboBox();
        }

        public void populateComboBox()
        {

            List<StockManagement> tempSale = GetAllIItem();
            foreach (var sales in tempSale)
            {
                saleItemNameComboBox.Items.Add(sales.itemName);             
            }
        }


        public void populateCustomerComboBox()
        {

            List<StockManagement> tempCustomer = GetAllICustomer();
            foreach (var customers in tempCustomer)
            {
                
                customerComboBox.Items.Add(customers.customerName);
            }
        }

        public List<StockManagement> GetAllIItem()
        {
            string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connect);
            string sqlQuery = "SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<StockManagement> sales = new List<StockManagement>();
            while (reader.Read())
            {
                StockManagement saleItemName = new StockManagement();
                saleItemName.itemName = reader["itemName"].ToString();
                sales.Add(saleItemName);

            }
            return sales;
        }



        public List<StockManagement> GetAllICustomer()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string sqlQuery = "SELECT * FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<StockManagement> customers = new List<StockManagement>();
            while (reader.Read())
            {
                StockManagement customerName = new StockManagement();
                customerName.customerName = reader["CustomerName"].ToString();
                customers.Add(customerName);

            }
            return customers;
        }



        private void Sale_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();
            SqlDataAdapter saleView = new SqlDataAdapter("SELECT * from sale", sqlConnection);
            DataTable saleTable = new DataTable();
            saleView.Fill(saleTable);
            saleDataGridView.DataSource = saleTable;
            populateComboBox();
            populateCustomerComboBox();
        }

        private void itemLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Items items = new Items();
            this.Hide();
            items.Show();
        }

        private void customerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.Show();
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

        private void saleQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            updateTotalPrice();
        }

        private void saleUnitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            updateTotalPrice();
        }
         private void updateTotalPrice()
        {
            if (saleQuantityTextBox.Text != "" && saleUnitPriceTextBox.Text != "")
            {
                int quantity = Convert.ToInt32(saleQuantityTextBox.Text);
                int unitPrice = Convert.ToInt32(saleUnitPriceTextBox.Text);
                int totalPrice = quantity * unitPrice;
                saleTotalPriceTextBox.Text = totalPrice.ToString();
            }
        }
    }
}
