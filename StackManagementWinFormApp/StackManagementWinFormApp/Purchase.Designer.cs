
namespace StackManagementWinFormApp
{
    partial class Purchase
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
            this.saleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.purchaseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.customerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.itemLinkLabel = new System.Windows.Forms.LinkLabel();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.savePurchaseButton = new System.Windows.Forms.Button();
            this.itemNameComboBox = new System.Windows.Forms.ComboBox();
            this.purchaseTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.purchaseUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.purchaseQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleLinkLabel
            // 
            this.saleLinkLabel.AutoSize = true;
            this.saleLinkLabel.Location = new System.Drawing.Point(488, 26);
            this.saleLinkLabel.Name = "saleLinkLabel";
            this.saleLinkLabel.Size = new System.Drawing.Size(28, 13);
            this.saleLinkLabel.TabIndex = 7;
            this.saleLinkLabel.TabStop = true;
            this.saleLinkLabel.Text = "Sale";
            this.saleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saleLinkLabel_LinkClicked);
            // 
            // purchaseLinkLabel
            // 
            this.purchaseLinkLabel.AutoSize = true;
            this.purchaseLinkLabel.Location = new System.Drawing.Point(405, 26);
            this.purchaseLinkLabel.Name = "purchaseLinkLabel";
            this.purchaseLinkLabel.Size = new System.Drawing.Size(52, 13);
            this.purchaseLinkLabel.TabIndex = 8;
            this.purchaseLinkLabel.TabStop = true;
            this.purchaseLinkLabel.Text = "Purchase";
            this.purchaseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.purchaseLinkLabel_LinkClicked);
            // 
            // customerLinkLabel
            // 
            this.customerLinkLabel.AutoSize = true;
            this.customerLinkLabel.Location = new System.Drawing.Point(318, 26);
            this.customerLinkLabel.Name = "customerLinkLabel";
            this.customerLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLinkLabel.TabIndex = 9;
            this.customerLinkLabel.TabStop = true;
            this.customerLinkLabel.Text = "Customer";
            this.customerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerLinkLabel_LinkClicked);
            // 
            // itemLinkLabel
            // 
            this.itemLinkLabel.AutoSize = true;
            this.itemLinkLabel.Location = new System.Drawing.Point(257, 26);
            this.itemLinkLabel.Name = "itemLinkLabel";
            this.itemLinkLabel.Size = new System.Drawing.Size(27, 13);
            this.itemLinkLabel.TabIndex = 10;
            this.itemLinkLabel.TabStop = true;
            this.itemLinkLabel.Text = "Item";
            this.itemLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.itemLinkLabel_LinkClicked);
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.Location = new System.Drawing.Point(97, 244);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.Size = new System.Drawing.Size(576, 119);
            this.purchaseDataGridView.TabIndex = 14;
            // 
            // savePurchaseButton
            // 
            this.savePurchaseButton.Location = new System.Drawing.Point(441, 200);
            this.savePurchaseButton.Name = "savePurchaseButton";
            this.savePurchaseButton.Size = new System.Drawing.Size(75, 23);
            this.savePurchaseButton.TabIndex = 13;
            this.savePurchaseButton.Text = "Save";
            this.savePurchaseButton.UseVisualStyleBackColor = true;
            this.savePurchaseButton.Click += new System.EventHandler(this.savePurchaseButton_Click);
            // 
            // itemNameComboBox
            // 
            this.itemNameComboBox.FormattingEnabled = true;
            this.itemNameComboBox.Location = new System.Drawing.Point(357, 60);
            this.itemNameComboBox.Name = "itemNameComboBox";
            this.itemNameComboBox.Size = new System.Drawing.Size(159, 21);
            this.itemNameComboBox.TabIndex = 35;
            // 
            // purchaseTotalPriceTextBox
            // 
            this.purchaseTotalPriceTextBox.Location = new System.Drawing.Point(357, 155);
            this.purchaseTotalPriceTextBox.Name = "purchaseTotalPriceTextBox";
            this.purchaseTotalPriceTextBox.Size = new System.Drawing.Size(159, 20);
            this.purchaseTotalPriceTextBox.TabIndex = 32;
            // 
            // purchaseUnitPriceTextBox
            // 
            this.purchaseUnitPriceTextBox.Location = new System.Drawing.Point(357, 122);
            this.purchaseUnitPriceTextBox.Name = "purchaseUnitPriceTextBox";
            this.purchaseUnitPriceTextBox.Size = new System.Drawing.Size(159, 20);
            this.purchaseUnitPriceTextBox.TabIndex = 33;
            this.purchaseUnitPriceTextBox.TextChanged += new System.EventHandler(this.purchaseUnitPriceTextBox_TextChanged);
            // 
            // purchaseQuantityTextBox
            // 
            this.purchaseQuantityTextBox.Location = new System.Drawing.Point(357, 96);
            this.purchaseQuantityTextBox.Name = "purchaseQuantityTextBox";
            this.purchaseQuantityTextBox.Size = new System.Drawing.Size(159, 20);
            this.purchaseQuantityTextBox.TabIndex = 34;
            this.purchaseQuantityTextBox.TextChanged += new System.EventHandler(this.purchaseQuantityTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total Price";
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(290, 63);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(58, 13);
            this.Customer.TabIndex = 30;
            this.Customer.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Quantity";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemNameComboBox);
            this.Controls.Add(this.purchaseTotalPriceTextBox);
            this.Controls.Add(this.purchaseUnitPriceTextBox);
            this.Controls.Add(this.purchaseQuantityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(this.savePurchaseButton);
            this.Controls.Add(this.saleLinkLabel);
            this.Controls.Add(this.purchaseLinkLabel);
            this.Controls.Add(this.customerLinkLabel);
            this.Controls.Add(this.itemLinkLabel);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel saleLinkLabel;
        private System.Windows.Forms.LinkLabel purchaseLinkLabel;
        private System.Windows.Forms.LinkLabel customerLinkLabel;
        private System.Windows.Forms.LinkLabel itemLinkLabel;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private System.Windows.Forms.Button savePurchaseButton;
        private System.Windows.Forms.ComboBox itemNameComboBox;
        private System.Windows.Forms.TextBox purchaseTotalPriceTextBox;
        private System.Windows.Forms.TextBox purchaseUnitPriceTextBox;
        private System.Windows.Forms.TextBox purchaseQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}