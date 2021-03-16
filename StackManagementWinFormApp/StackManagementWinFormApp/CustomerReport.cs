using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace StackManagementWinFormApp
{
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        //declaring variables
        string query;
        private void displayDTG(string query)
        {
            try
            {

                con.Open();

                cmd = new SqlCommand();

                cmd.Connection = con;

                cmd.CommandText = query;

                da = new SqlDataAdapter();

                da.SelectCommand = cmd;

                dt = new DataTable();

                da.Fill(dt);

                customerReportDataGridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            da.Dispose();
            con.Close();
        }

        /* public void populateDataGriView()
         {

             //studentListBox.Items.Clear();
             //List<StockManagement> tempCustomerReport = GetAllCustomer();

             //foreach (var customerReport in tempCustomerReport)
             {
                 //string tempVar =customerReport.itemName + ", " + customerReport.customerName + ", " + customerReport.quantity + "," + customerReport.unitPrice+"," +customerReport.totalPrice;
                 //customerReportDataGridView.Add(tempVar);
                // studentListBox.Items.Add("");
             }

             //customerReportDataGridView.DataSource = tempVar;

         }

         */

        private void customerSearchButton_Click(object sender, EventArgs e)
        {
            StockManagement cReport = new StockManagement();
            cReport.customerName = customerNameComboBox.Text;
            string customerName = customerNameComboBox.SelectedItem.ToString();

            StockManagement customer = GetCustomerByCustomerName(customerName);
        }

        public StockManagement GetCustomerByCustomerName(string customer)
        {


            string queryString = @"Server=DESKTOP-NO0F3GD\SQLEXPRESS ; Database = Stock Management; Integrated Security = true";

            SqlConnection connection = new SqlConnection(queryString);
            string query = "SELECT * FROM Sale WHERE Customer='" + customer + "';";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            StockManagement creport = new StockManagement();


            if (reader.Read())
            {
                // student.Id = Convert.ToInt32(reader["Id"]);
                creport.itemName = reader["ItemName"].ToString();
                creport.customerName = reader["Customer"].ToString();
                creport.quantity = reader["Quantity"].ToString();
                creport.unitPrice = reader["UnitPrice"].ToString();
                creport.totalPrice = reader["TotalPrice"].ToString();
            }
            else
            {
                creport = null;
            }

            return creport;
        }
        public void populateCustomerComboBox()
        {

            List<StockManagement> tempCustomer = GetAllICustomer();
            foreach (var customers in tempCustomer)
            {

                customerNameComboBox.Items.Add(customers.customerName);
            }
        }

        public List<StockManagement> GetAllICustomer()
        {
            string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";
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

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            //set a connection between SQL server and Visual C#
            con.ConnectionString = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";

            query = "Select Item,Quantity,UnitPrice,TotalPrice FROM Customer_Report";

            //displayDTG(query);

            populateCustomerComboBox();
        }
        private void customerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
             //query = "Select Item,Quantity,UnitPrice,TotalPrice FROM Sale  WHERE CustomerName='" + customerNameComboBox.SelectedItem + "'";
            //displayDTG(query);

            List<StockManagement> sales = GetAllISalesByCustomer(customerNameComboBox.SelectedItem.ToString());

            foreach (var sale in sales)
            {
                customerReportDataGridView.Rows.Add(sale.itemName, sale.quantity, sale.unitPrice, sale.totalPrice);
            }

        }

        public List<StockManagement> GetAllISalesByCustomer(string customerName)
        {
            string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = Stock Management; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connect);
            string sqlQuery = "SELECT * FROM Sale WHERE Customer='" + customerName + "'";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<StockManagement> sales = new List<StockManagement>();
            while (reader.Read())
            {
                StockManagement sale = new StockManagement();
                sale.customerName = reader["Customer"].ToString();
                sale.itemName = reader["ItemName"].ToString();
                sale.quantity = reader["Quantity"].ToString();
                sale.unitPrice = reader["UnitPrice"].ToString();
                sale.totalPrice = reader["TotalPrice"].ToString();
                sales.Add(sale);

            }
            return sales;
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            List<StockManagement> sales = GetAllISalesByCustomer(customerNameComboBox.SelectedItem.ToString());
            dataTable.Columns.Add("Item Name");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Unit Price");
            dataTable.Columns.Add("Total Price");
            foreach (var sale in sales)
            {
                dataTable.Rows.Add(sale.itemName, sale.quantity, sale.unitPrice, sale.totalPrice);
            }

            ExportDataTableToPdf(dataTable, Application.StartupPath + "\\Test.Pdf", "Sale List");

            Process.Start(Application.StartupPath + "\\Test.Pdf");
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

        }

        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor,45);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Author : Dotnet Mob", fntAuthor));
            prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph();
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                //cell.BackgroundColor = Color.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }
            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }

    }
}
