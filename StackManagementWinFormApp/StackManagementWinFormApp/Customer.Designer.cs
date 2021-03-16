
namespace StackManagementWinFormApp
{
    partial class Customer
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
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerSaveButton = new System.Windows.Forms.Button();
            this.cutomerNameLabel = new System.Windows.Forms.Label();
            this.customerNametextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saleLinkLabel
            // 
            this.saleLinkLabel.AutoSize = true;
            this.saleLinkLabel.Location = new System.Drawing.Point(488, 32);
            this.saleLinkLabel.Name = "saleLinkLabel";
            this.saleLinkLabel.Size = new System.Drawing.Size(28, 13);
            this.saleLinkLabel.TabIndex = 3;
            this.saleLinkLabel.TabStop = true;
            this.saleLinkLabel.Text = "Sale";
            this.saleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saleLinkLabel_LinkClicked);
            // 
            // purchaseLinkLabel
            // 
            this.purchaseLinkLabel.AutoSize = true;
            this.purchaseLinkLabel.Location = new System.Drawing.Point(405, 32);
            this.purchaseLinkLabel.Name = "purchaseLinkLabel";
            this.purchaseLinkLabel.Size = new System.Drawing.Size(52, 13);
            this.purchaseLinkLabel.TabIndex = 4;
            this.purchaseLinkLabel.TabStop = true;
            this.purchaseLinkLabel.Text = "Purchase";
            this.purchaseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.purchaseLinkLabel_LinkClicked);
            // 
            // customerLinkLabel
            // 
            this.customerLinkLabel.AutoSize = true;
            this.customerLinkLabel.Location = new System.Drawing.Point(318, 32);
            this.customerLinkLabel.Name = "customerLinkLabel";
            this.customerLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLinkLabel.TabIndex = 5;
            this.customerLinkLabel.TabStop = true;
            this.customerLinkLabel.Text = "Customer";
            this.customerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerLinkLabel_LinkClicked);
            // 
            // itemLinkLabel
            // 
            this.itemLinkLabel.AutoSize = true;
            this.itemLinkLabel.Location = new System.Drawing.Point(257, 32);
            this.itemLinkLabel.Name = "itemLinkLabel";
            this.itemLinkLabel.Size = new System.Drawing.Size(27, 13);
            this.itemLinkLabel.TabIndex = 6;
            this.itemLinkLabel.TabStop = true;
            this.itemLinkLabel.Text = "Item";
            this.itemLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.itemLinkLabel_LinkClicked);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(146, 189);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(391, 150);
            this.customerDataGridView.TabIndex = 12;
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Location = new System.Drawing.Point(361, 86);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(159, 20);
            this.customerPhoneTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phone";
            // 
            // customerSaveButton
            // 
            this.customerSaveButton.Location = new System.Drawing.Point(445, 136);
            this.customerSaveButton.Name = "customerSaveButton";
            this.customerSaveButton.Size = new System.Drawing.Size(75, 23);
            this.customerSaveButton.TabIndex = 9;
            this.customerSaveButton.Text = "Save";
            this.customerSaveButton.UseVisualStyleBackColor = true;
            this.customerSaveButton.Click += new System.EventHandler(this.customerSaveButton_Click);
            // 
            // cutomerNameLabel
            // 
            this.cutomerNameLabel.AutoSize = true;
            this.cutomerNameLabel.Location = new System.Drawing.Point(277, 62);
            this.cutomerNameLabel.Name = "cutomerNameLabel";
            this.cutomerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.cutomerNameLabel.TabIndex = 8;
            this.cutomerNameLabel.Text = "Customer Name";
            // 
            // customerNametextBox
            // 
            this.customerNametextBox.Location = new System.Drawing.Point(361, 60);
            this.customerNametextBox.Name = "customerNametextBox";
            this.customerNametextBox.Size = new System.Drawing.Size(159, 20);
            this.customerNametextBox.TabIndex = 11;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customerNametextBox);
            this.Controls.Add(this.customerPhoneTextBox);
            this.Controls.Add(this.customerSaveButton);
            this.Controls.Add(this.cutomerNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saleLinkLabel);
            this.Controls.Add(this.purchaseLinkLabel);
            this.Controls.Add(this.customerLinkLabel);
            this.Controls.Add(this.itemLinkLabel);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel saleLinkLabel;
        private System.Windows.Forms.LinkLabel purchaseLinkLabel;
        private System.Windows.Forms.LinkLabel customerLinkLabel;
        private System.Windows.Forms.LinkLabel itemLinkLabel;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TextBox customerPhoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customerSaveButton;
        private System.Windows.Forms.Label cutomerNameLabel;
        private System.Windows.Forms.TextBox customerNametextBox;
    }
}