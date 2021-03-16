using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {

            //string foodList = foodCheckListBox.Text;
            //List<string> foodList = new List<string>();
            //foodList.Add("Burger");
            //foodList.Add("Banana");
            /*foreach (string items in foodList)
            {
                foodCheckListBox.Items = items;
            }
            */
            /* string foodList = "";
             foodList = foodCheckListBox.Text;

             if(foodList!= "")
             {
                 foodList += foodList;
             }
             else
             {
                 foodList = "";
             }
             */
            string foodList = "";
            foreach (var item in foodCheckListBox.CheckedItems)
            {
                foodList += item.ToString();
                foodList += ",";
            }
           // foodList += foodCheckListBox.CheckedItems;
            string restaurant = restaurantComboBoxList.Text;          
            string paymentMethod = "";
            if(handCashRadioButton.Checked)
            {
                paymentMethod = "HandChash";
            }
            else
            {
                paymentMethod = "Bkash";
            }

            MessageBox.Show("Restaurant Name : "+restaurant+"\r\n"+"Food Select : "+foodList+"\r\n"+"Payment Method Select : "+paymentMethod);
        }


    }
}
