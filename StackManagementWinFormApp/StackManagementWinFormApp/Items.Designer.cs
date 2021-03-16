
namespace StackManagementWinFormApp
{
    partial class Items
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
            this.label1 = new System.Windows.Forms.Label();
            this.saveItemButton = new System.Windows.Forms.Button();
            this.itemLinkLabel = new System.Windows.Forms.LinkLabel();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.customerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.purchaseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.saleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // saveItemButton
            // 
            this.saveItemButton.Location = new System.Drawing.Point(397, 165);
            this.saveItemButton.Name = "saveItemButton";
            this.saveItemButton.Size = new System.Drawing.Size(75, 23);
            this.saveItemButton.TabIndex = 1;
            this.saveItemButton.Text = "Save";
            this.saveItemButton.UseVisualStyleBackColor = true;
            this.saveItemButton.Click += new System.EventHandler(this.saveItemButton_Click);
            // 
            // itemLinkLabel
            // 
            this.itemLinkLabel.AutoSize = true;
            this.itemLinkLabel.Location = new System.Drawing.Point(213, 47);
            this.itemLinkLabel.Name = "itemLinkLabel";
            this.itemLinkLabel.Size = new System.Drawing.Size(27, 13);
            this.itemLinkLabel.TabIndex = 2;
            this.itemLinkLabel.TabStop = true;
            this.itemLinkLabel.Text = "Item";
            this.itemLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.itemLinkLabel_LinkClicked);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(313, 96);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.itemNameTextBox.TabIndex = 3;
            // 
            // customerLinkLabel
            // 
            this.customerLinkLabel.AutoSize = true;
            this.customerLinkLabel.Location = new System.Drawing.Point(274, 47);
            this.customerLinkLabel.Name = "customerLinkLabel";
            this.customerLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.customerLinkLabel.TabIndex = 2;
            this.customerLinkLabel.TabStop = true;
            this.customerLinkLabel.Text = "Customer";
            this.customerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerLinkLabel_LinkClicked);
            // 
            // purchaseLinkLabel
            // 
            this.purchaseLinkLabel.AutoSize = true;
            this.purchaseLinkLabel.Location = new System.Drawing.Point(361, 47);
            this.purchaseLinkLabel.Name = "purchaseLinkLabel";
            this.purchaseLinkLabel.Size = new System.Drawing.Size(52, 13);
            this.purchaseLinkLabel.TabIndex = 2;
            this.purchaseLinkLabel.TabStop = true;
            this.purchaseLinkLabel.Text = "Purchase";
            this.purchaseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.purchaseLinkLabel_LinkClicked);
            // 
            // saleLinkLabel
            // 
            this.saleLinkLabel.AutoSize = true;
            this.saleLinkLabel.Location = new System.Drawing.Point(444, 47);
            this.saleLinkLabel.Name = "saleLinkLabel";
            this.saleLinkLabel.Size = new System.Drawing.Size(28, 13);
            this.saleLinkLabel.TabIndex = 2;
            this.saleLinkLabel.TabStop = true;
            this.saleLinkLabel.Text = "Sale";
            this.saleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saleLinkLabel_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code";
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Location = new System.Drawing.Point(313, 127);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(159, 20);
            this.itemCodeTextBox.TabIndex = 3;
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Location = new System.Drawing.Point(135, 217);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.Size = new System.Drawing.Size(337, 150);
            this.itemDataGridView.TabIndex = 4;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.itemCodeTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.saleLinkLabel);
            this.Controls.Add(this.purchaseLinkLabel);
            this.Controls.Add(this.customerLinkLabel);
            this.Controls.Add(this.itemLinkLabel);
            this.Controls.Add(this.saveItemButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveItemButton;
        private System.Windows.Forms.LinkLabel itemLinkLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.LinkLabel customerLinkLabel;
        private System.Windows.Forms.LinkLabel purchaseLinkLabel;
        private System.Windows.Forms.LinkLabel saleLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.DataGridView itemDataGridView;
    }
}