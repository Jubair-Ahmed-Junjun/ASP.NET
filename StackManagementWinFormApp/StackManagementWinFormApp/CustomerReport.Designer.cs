
namespace StackManagementWinFormApp
{
    partial class CustomerReport
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
            this.customerReportLinkLabel = new System.Windows.Forms.LinkLabel();
            this.customerNameComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerReportDataGridView = new System.Windows.Forms.DataGridView();
            this.customerSearchButton = new System.Windows.Forms.Button();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdfButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleLinkLabel
            // 
            this.saleLinkLabel.AutoSize = true;
            this.saleLinkLabel.Location = new System.Drawing.Point(469, 30);
            this.saleLinkLabel.Name = "saleLinkLabel";
            this.saleLinkLabel.Size = new System.Drawing.Size(28, 13);
            this.saleLinkLabel.TabIndex = 11;
            this.saleLinkLabel.TabStop = true;
            this.saleLinkLabel.Text = "Sale";
            // 
            // purchaseLinkLabel
            // 
            this.purchaseLinkLabel.AutoSize = true;
            this.purchaseLinkLabel.Location = new System.Drawing.Point(386, 30);
            this.purchaseLinkLabel.Name = "purchaseLinkLabel";
            this.purchaseLinkLabel.Size = new System.Drawing.Size(52, 13);
            this.purchaseLinkLabel.TabIndex = 12;
            this.purchaseLinkLabel.TabStop = true;
            this.purchaseLinkLabel.Text = "Purchase";
            // 
            // customerLinkLabel
            // 
            this.customerLinkLabel.AutoSize = true;
            this.customerLinkLabel.Location = new System.Drawing.Point(299, 30);
            this.customerLinkLabel.Name = "customerLinkLabel";
            this.customerLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLinkLabel.TabIndex = 13;
            this.customerLinkLabel.TabStop = true;
            this.customerLinkLabel.Text = "Customer";
            // 
            // itemLinkLabel
            // 
            this.itemLinkLabel.AutoSize = true;
            this.itemLinkLabel.Location = new System.Drawing.Point(238, 30);
            this.itemLinkLabel.Name = "itemLinkLabel";
            this.itemLinkLabel.Size = new System.Drawing.Size(27, 13);
            this.itemLinkLabel.TabIndex = 14;
            this.itemLinkLabel.TabStop = true;
            this.itemLinkLabel.Text = "Item";
            // 
            // customerReportLinkLabel
            // 
            this.customerReportLinkLabel.AutoSize = true;
            this.customerReportLinkLabel.Location = new System.Drawing.Point(519, 30);
            this.customerReportLinkLabel.Name = "customerReportLinkLabel";
            this.customerReportLinkLabel.Size = new System.Drawing.Size(86, 13);
            this.customerReportLinkLabel.TabIndex = 11;
            this.customerReportLinkLabel.TabStop = true;
            this.customerReportLinkLabel.Text = "Customer Report";
            // 
            // customerNameComboBox
            // 
            this.customerNameComboBox.FormattingEnabled = true;
            this.customerNameComboBox.Location = new System.Drawing.Point(389, 86);
            this.customerNameComboBox.Name = "customerNameComboBox";
            this.customerNameComboBox.Size = new System.Drawing.Size(216, 21);
            this.customerNameComboBox.TabIndex = 16;
            this.customerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.customerNameComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Customer Name";
            // 
            // customerReportDataGridView
            // 
            this.customerReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quantity,
            this.UnitPrice,
            this.TotalPrice});
            this.customerReportDataGridView.Location = new System.Drawing.Point(251, 165);
            this.customerReportDataGridView.Name = "customerReportDataGridView";
            this.customerReportDataGridView.Size = new System.Drawing.Size(364, 123);
            this.customerReportDataGridView.TabIndex = 17;
            // 
            // customerSearchButton
            // 
            this.customerSearchButton.Location = new System.Drawing.Point(530, 125);
            this.customerSearchButton.Name = "customerSearchButton";
            this.customerSearchButton.Size = new System.Drawing.Size(75, 23);
            this.customerSearchButton.TabIndex = 18;
            this.customerSearchButton.Text = "Search";
            this.customerSearchButton.UseVisualStyleBackColor = true;
            this.customerSearchButton.Click += new System.EventHandler(this.customerSearchButton_Click);
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // pdfButton
            // 
            this.pdfButton.Location = new System.Drawing.Point(624, 125);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(75, 23);
            this.pdfButton.TabIndex = 18;
            this.pdfButton.Text = "PDF";
            this.pdfButton.UseVisualStyleBackColor = true;
            this.pdfButton.Click += new System.EventHandler(this.pdfButton_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 361);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.customerSearchButton);
            this.Controls.Add(this.customerReportDataGridView);
            this.Controls.Add(this.customerNameComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerReportLinkLabel);
            this.Controls.Add(this.saleLinkLabel);
            this.Controls.Add(this.purchaseLinkLabel);
            this.Controls.Add(this.customerLinkLabel);
            this.Controls.Add(this.itemLinkLabel);
            this.Name = "CustomerReport";
            this.Text = "CustomerReport";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerReportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel saleLinkLabel;
        private System.Windows.Forms.LinkLabel purchaseLinkLabel;
        private System.Windows.Forms.LinkLabel customerLinkLabel;
        private System.Windows.Forms.LinkLabel itemLinkLabel;
        private System.Windows.Forms.LinkLabel customerReportLinkLabel;
        private System.Windows.Forms.ComboBox customerNameComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView customerReportDataGridView;
        private System.Windows.Forms.Button customerSearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Button pdfButton;
    }
}