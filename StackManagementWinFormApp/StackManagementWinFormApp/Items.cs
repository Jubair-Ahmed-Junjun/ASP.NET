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
    public partial class Items : Form
    {
        string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";
        public Items()
        {
            InitializeComponent();
        }

        private void saveItemButton_Click(object sender, EventArgs e)
        {
            StockManagement items = new StockManagement();
            items.itemName = itemNameTextBox.Text;
            items.itemCode = itemCodeTextBox.Text;
            saveItem(items);
        }
        public void saveItem(StockManagement itemInfo)
        {
            
            SqlConnection sqlConnection = new SqlConnection(connect);
            string sqlQuery = "INSERT INTO Items(itemName,itemCode)VALUES('" + itemInfo.itemName + "','" + itemInfo.itemCode + "')";
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
            SqlDataAdapter itemView = new SqlDataAdapter("SELECT * from Items", sqlConnection);
            DataTable itemTable = new DataTable();
            itemView.Fill(itemTable);
            itemDataGridView.DataSource = itemTable;
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

        private void Items_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connect);
            //SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter itemView = new SqlDataAdapter("SELECT * from Items", sqlConnection);
            DataTable itemTable = new DataTable();
            itemView.Fill(itemTable);
            itemDataGridView.DataSource = itemTable;
        }
    }
}
