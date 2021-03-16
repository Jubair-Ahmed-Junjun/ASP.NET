
namespace StackManagementWinFormApp
{
    partial class Sale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saleItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.saleDataGridView = new System.Windows.Forms.DataGridView();
            this.saleTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.saleUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.saleQuantityTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.purchaseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.customerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.itemLinkLabel = new System.Windows.Forms.LinkLabel();
            this.Customer = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleItemNameComboBox
            // 
            this.saleItemNameComboBox.FormattingEnabled = true;
            this.saleItemNameComboBox.Location = new System.Drawing.Point(371, 61);
            this.saleItemNameComboBox.Name = "saleItemNameComboBox";
            this.saleItemNameComboBox.Size = new System.Drawing.Size(159, 21);
            this.saleItemNameComboBox.TabIndex = 27;
            // 
            // saleDataGridView
            // 
            this.saleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleDataGridView.Location = new System.Drawing.Point(99, 233);
            this.saleDataGridView.Name = "saleDataGridView";
            this.saleDataGridView.Size = new System.Drawing.Size(666, 150);
            this.saleDataGridView.TabIndex = 26;
            // 
            // saleTotalPriceTextBox
            // 
            this.saleTotalPriceTextBox.Location = new System.Drawing.Point(371, 178);
            this.saleTotalPriceTextBox.Name = "saleTotalPriceTextBox";
            this.saleTotalPriceTextBox.Size = new System.Drawing.Size(159, 20);
            this.saleTotalPriceTextBox.TabIndex = 23;
            // 
            // saleUnitPriceTextBox
            // 
            this.saleUnitPriceTextBox.Location = new System.Drawing.Point(371, 152);
            this.saleUnitPriceTextBox.Name = "saleUnitPriceTextBox";
            this.saleUnitPriceTextBox.Size = new System.Drawing.Size(159, 20);
            this.saleUnitPriceTextBox.TabIndex = 24;
            this.saleUnitPriceTextBox.TextChanged += new System.EventHandler(this.saleUnitPriceTextBox_TextChanged);
            // 
            // saleQuantityTextBox
            // 
            this.saleQuantityTextBox.Location = new System.Drawing.Point(371, 121);
            this.saleQuantityTextBox.Name = "saleQuantityTextBox";
            this.saleQuantityTextBox.Size = new System.Drawing.Size(159, 20);
            this.saleQuantityTextBox.TabIndex = 25;
            this.saleQuantityTextBox.TextChanged += new System.EventHandler(this.saleQuantityTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Quantity";
            // 
            // saleLinkLabel
            // 
            this.saleLinkLabel.AutoSize = true;
            this.saleLinkLabel.Location = new System.Drawing.Point(498, 34);
            this.saleLinkLabel.Name = "saleLinkLabel";
            this.saleLinkLabel.Size = new System.Drawing.Size(28, 13);
            this.saleLinkLabel.TabIndex = 14;
            this.saleLinkLabel.TabStop = true;
            this.saleLinkLabel.Text = "Sale";
            this.saleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saleLinkLabel_LinkClicked);
            // 
            // purchaseLinkLabel
            // 
            this.purchaseLinkLabel.AutoSize = true;
            this.purchaseLinkLabel.Location = new System.Drawing.Point(415, 34);
            this.purchaseLinkLabel.Name = "purchaseLinkLabel";
            this.purchaseLinkLabel.Size = new System.Drawing.Size(52, 13);
            this.purchaseLinkLabel.TabIndex = 15;
            this.purchaseLinkLabel.TabStop = true;
            this.purchaseLinkLabel.Text = "Purchase";
            this.purchaseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.purchaseLinkLabel_LinkClicked);
            // 
            // customerLinkLabel
            // 
            this.customerLinkLabel.AutoSize = true;
            this.customerLinkLabel.Location = new System.Drawing.Point(328, 34);
            this.customerLinkLabel.Name = "customerLinkLabel";
            this.customerLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLinkLabel.TabIndex = 16;
            this.customerLinkLabel.TabStop = true;
            this.customerLinkLabel.Text = "Customer";
            this.customerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerLinkLabel_LinkClicked);
            // 
            // itemLinkLabel
            // 
            this.itemLinkLabel.AutoSize = true;
            this.itemLinkLabel.Location = new System.Drawing.Point(267, 34);
            this.itemLinkLabel.Name = "itemLinkLabel";
            this.itemLinkLabel.Size = new System.Drawing.Size(27, 13);
            this.itemLinkLabel.TabIndex = 17;
            this.itemLinkLabel.TabStop = true;
            this.itemLinkLabel.Text = "Item";
            this.itemLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.itemLinkLabel_LinkClicked);
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(309, 97);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(51, 13);
            this.Customer.TabIndex = 20;
            this.Customer.Text = "Customer";
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(371, 94);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(159, 21);
            this.customerComboBox.TabIndex = 27;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.saleItemNameComboBox);
            this.Controls.Add(this.saleDataGridView);
            this.Controls.Add(this.saleTotalPriceTextBox);
            this.Controls.Add(this.saleUnitPriceTextBox);
            this.Controls.Add(this.saleQuantityTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saleLinkLabel);
            this.Controls.Add(this.purchaseLinkLabel);
            this.Controls.Add(this.customerLinkLabel);
            this.Controls.Add(this.itemLinkLabel);
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox saleItemNameComboBox;
        private System.Windows.Forms.DataGridView saleDataGridView;
        private System.Windows.Forms.TextBox saleTotalPriceTextBox;
        private System.Windows.Forms.TextBox saleUnitPriceTextBox;
        private System.Windows.Forms.TextBox saleQuantityTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel saleLinkLabel;
        private System.Windows.Forms.LinkLabel purchaseLinkLabel;
        private System.Windows.Forms.LinkLabel customerLinkLabel;
        private System.Windows.Forms.LinkLabel itemLinkLabel;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.ComboBox customerComboBox;
    }
}