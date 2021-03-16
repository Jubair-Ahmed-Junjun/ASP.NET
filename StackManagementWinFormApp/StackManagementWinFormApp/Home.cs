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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void itemLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Items items = new Items();
            this.Hide();
            items.Show();
        }

        private void customerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer customers = new Customer();
            this.Hide();
            customers.Show();
        }

        private void purchaseLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Purchase purchase = new Purchase();
            this.Hide();
            purchase.Show();
        }

        private void saleLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sale sale = new Sale();
            this.Hide();
            sale.Show();
        }

        private void customerReportLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerReport cReport = new CustomerReport();
            this.Hide();
            cReport.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            List<StockManagement> items = GetAllItems();
            foreach (var item in items)
            {

                List<StockManagement> purchases = GetAllPurchaseByItemName(item.itemName);
                List<StockManagement> sales = GetAllSaleByItemName(item.itemName);

                int totalPurchase = 0;
                int totalSale = 0;

                foreach (var purchase in purchases)
                {
                    totalPurchase += Convert.ToInt32(purchase.quantity);
                }

                foreach (var sale in sales)
                {
                    totalSale += Convert.ToInt32(sale.quantity);
                }


                int currentStock = totalPurchase - totalSale;


                homeDataGridView.Rows.Add(item.itemName, item.itemCode, currentStock);

            }

        }


        public List<StockManagement> GetAllItems()
        {


            string queryString = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";

            SqlConnection connection = new SqlConnection(queryString);
            string query = "SELECT * FROM Items;";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<StockManagement> items = new List<StockManagement>();


            while (reader.Read())
            {
                StockManagement item = new StockManagement();
                item.itemName = reader["itemName"].ToString();
                item.itemCode = reader["itemCode"].ToString();
                items.Add(item);
            }


            return items;


        }

        public List<StockManagement> GetAllPurchaseByItemName(string itemName)
        {


            string queryString = @"Server=DESKTOP-NRHJE6N\SQLEXPRESS ; Database = Stock Management; Integrated Security = true";

            SqlConnection connection = new SqlConnection(queryString);
            string query = "SELECT * FROM Purchase WHERE ItemName ='" + itemName + "';";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<StockManagement> items = new List<StockManagement>();


            while (reader.Read())
            {
                StockManagement item = new StockManagement();
                item.itemName = reader["ItemName"].ToString();
                item.quantity = reader["Quantity"].ToString();
                items.Add(item);
            }


            return items;

        }

        public List<StockManagement> GetAllSaleByItemName(string itemName)
        {


            string queryString = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";

            SqlConnection connection = new SqlConnection(queryString);
            string query = "SELECT * FROM Sale WHERE ItemName ='" + itemName + "';";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<StockManagement> items = new List<StockManagement>();


            while (reader.Read())
            {
                StockManagement item = new StockManagement();
                item.itemName = reader["ItemName"].ToString();
                item.quantity = reader["Quantity"].ToString();
                items.Add(item);
            }
              return items;
        }

        }
    }
