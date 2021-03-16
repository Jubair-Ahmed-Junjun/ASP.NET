
namespace StackManagementWinFormApp
{
    partial class Home
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
            this.itemLinkLabel = new System.Windows.Forms.LinkLabel();
            this.homeDataGridView = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.purchaseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.saleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.customerReportLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemLinkLabel
            // 
            this.itemLinkLabel.AutoSize = true;
            this.itemLinkLabel.Location = new System.Drawing.Point(161, 13);
            this.itemLinkLabel.Name = "itemLinkLabel";
            this.itemLinkLabel.Size = new System.Drawing.Size(27, 13);
            this.itemLinkLabel.TabIndex = 0;
            this.itemLinkLabel.TabStop = true;
            this.itemLinkLabel.Text = "Item";
            this.itemLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.itemLabel_LinkClicked);
            // 
            // homeDataGridView
            // 
            this.homeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemCode,
            this.currentStock});
            this.homeDataGridView.Location = new System.Drawing.Point(124, 89);
            this.homeDataGridView.Name = "homeDataGridView";
            this.homeDataGridView.Size = new System.Drawing.Size(347, 150);
            this.homeDataGridView.TabIndex = 1;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Items";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemCode
            // 
            this.itemCode.HeaderText = "Item Code";
            this.itemCode.Name = "itemCode";
            this.itemCode.ReadOnly = true;
            // 
            // currentStock
            // 
            this.currentStock.HeaderText = "Current Stock";
            this.currentStock.Name = "currentStock";
            this.currentStock.ReadOnly = true;
            // 
            // customerLinkLabel
            // 
            this.customerLinkLabel.AutoSize = true;
            this.customerLinkLabel.Location = new System.Drawing.Point(232, 13);
            this.customerLinkLabel.Name = "customerLinkLabel";
            this.customerLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLinkLabel.TabIndex = 0;
            this.customerLinkLabel.TabStop = true;
            this.customerLinkLabel.Text = "Customer";
            this.customerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerLabel_LinkClicked);
            // 
            // purchaseLinkLabel
            // 
            this.purchaseLinkLabel.AutoSize = true;
            this.purchaseLinkLabel.Location = new System.Drawing.Point(310, 13);
            this.purchaseLinkLabel.Name = "purchaseLinkLabel";
            this.purchaseLinkLabel.Size = new System.Drawing.Size(52, 13);
            this.purchaseLinkLabel.TabIndex = 0;
            this.purchaseLinkLabel.TabStop = true;
            this.purchaseLinkLabel.Text = "Purchase";
            this.purchaseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.purchaseLabel_LinkClicked);
            // 
            // saleLinkLabel
            // 
            this.saleLinkLabel.AutoSize = true;
            this.saleLinkLabel.Location = new System.Drawing.Point(385, 13);
            this.saleLinkLabel.Name = "saleLinkLabel";
            this.saleLinkLabel.Size = new System.Drawing.Size(28, 13);
            this.saleLinkLabel.TabIndex = 0;
            this.saleLinkLabel.TabStop = true;
            this.saleLinkLabel.Text = "Sale";
            this.saleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saleLabel_LinkClicked);
            // 
            // customerReportLinkLabel
            // 
            this.customerReportLinkLabel.AutoSize = true;
            this.customerReportLinkLabel.Location = new System.Drawing.Point(432, 13);
            this.customerReportLinkLabel.Name = "customerReportLinkLabel";
            this.customerReportLinkLabel.Size = new System.Drawing.Size(86, 13);
            this.customerReportLinkLabel.TabIndex = 12;
            this.customerReportLinkLabel.TabStop = true;
            this.customerReportLinkLabel.Text = "Customer Report";
            this.customerReportLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerReportLinkLabel_LinkClicked);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 299);
            this.Controls.Add(this.customerReportLinkLabel);
            this.Controls.Add(this.homeDataGridView);
            this.Controls.Add(this.saleLinkLabel);
            this.Controls.Add(this.purchaseLinkLabel);
            this.Controls.Add(this.customerLinkLabel);
            this.Controls.Add(this.itemLinkLabel);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel itemLinkLabel;
        private System.Windows.Forms.DataGridView homeDataGridView;
        private System.Windows.Forms.LinkLabel customerLinkLabel;
        private System.Windows.Forms.LinkLabel purchaseLinkLabel;
        private System.Windows.Forms.LinkLabel saleLinkLabel;
        private System.Windows.Forms.LinkLabel customerReportLinkLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentStock;
    }
}

