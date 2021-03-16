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
    public partial class Purchase : Form
    {
        string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";

        public Purchase()
        {
            InitializeComponent();
        }

        private void savePurchaseButton_Click(object sender, EventArgs e)
        {
            StockManagement purchase = new StockManagement();
            purchase.itemName = itemNameComboBox.Text;
            purchase.quantity = purchaseQuantityTextBox.Text;
            purchase.unitPrice = purchaseUnitPriceTextBox.Text;
            int total = Convert.ToInt32(purchaseQuantityTextBox.Text) * Convert.ToInt32(purchaseUnitPriceTextBox.Text);
            //purchase.totalPrice = total.ToString();
            purchase.totalPrice = purchaseTotalPriceTextBox.Text = total.ToString();
            savePurchase(purchase);
            //populateComboBox();

        }


        public void savePurchase(StockManagement tempPurchase)
        {
            string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connect);
            string query = "INSERT INTO Purchase (ItemName, Quantity, UnitPrice, TotalPrice) " +
            "VALUES('" + tempPurchase.itemName + "','" + tempPurchase.quantity + "', '" + tempPurchase.unitPrice + "','" + tempPurchase.totalPrice + "');";
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
            SqlDataAdapter purchaseView = new SqlDataAdapter("SELECT * from Purchase", sqlConnection);
            DataTable purchaseTable = new DataTable();
            purchaseView.Fill(purchaseTable);
            purchaseDataGridView.DataSource = purchaseTable;

            populateComboBox();
        }

        public void populateComboBox()
        {
            
            List<StockManagement> tempItem = GetAllItems();
            foreach (var items in tempItem)
            {
                itemNameComboBox.Items.Add(items.itemName);
            }
        }

        public List<StockManagement> GetAllItems()
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            string sqlQuery = "SELECT * FROM Items";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<StockManagement> purchase = new List<StockManagement>();
            while (reader.Read())
            {
                StockManagement purchaseItemName = new StockManagement();
                purchaseItemName.itemName = reader["itemName"].ToString();
                purchase.Add(purchaseItemName);

            }
            return purchase;
        }

        private void itemLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Items items = new Items();
            this.Hide();
            items.Show();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            sqlConnection.Open();
            SqlDataAdapter purchaseView = new SqlDataAdapter("SELECT * from Purchase", sqlConnection);
            DataTable purchaseTable = new DataTable();
            purchaseView.Fill(purchaseTable);
            purchaseDataGridView.DataSource = purchaseTable;
            populateComboBox();
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

        private void purchaseQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            updateTotalPrice();
        }

        private void purchaseUnitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            updateTotalPrice();
        }
        private void updateTotalPrice()
        {
            if (purchaseQuantityTextBox.Text != "" && purchaseUnitPriceTextBox.Text != "")
            {
                int quantity = Convert.ToInt32(purchaseQuantityTextBox.Text);
                int unitPrice = Convert.ToInt32(purchaseUnitPriceTextBox.Text);
                int totalPrice = quantity * unitPrice;
                purchaseTotalPriceTextBox.Text = totalPrice.ToString();
            }
        }
    }
}
