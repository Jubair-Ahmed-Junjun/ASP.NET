
namespace FoodOrderWinFormApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.restaurantComboBoxList = new System.Windows.Forms.ComboBox();
            this.foodCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.bkashRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.handCashRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // restaurantComboBoxList
            // 
            this.restaurantComboBoxList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.restaurantComboBoxList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaurantComboBoxList.FormattingEnabled = true;
            this.restaurantComboBoxList.Items.AddRange(new object[] {
            "Ambrosia",
            "Handi Restaurant",
            "Regalo",
            "The Exchange Restaurant",
            "The Pavilion",
            "Greedy Guts",
            "Mezetto",
            "Meridian Hotel & Restaurant"});
            this.restaurantComboBoxList.Location = new System.Drawing.Point(176, 64);
            this.restaurantComboBoxList.Name = "restaurantComboBoxList";
            this.restaurantComboBoxList.Size = new System.Drawing.Size(173, 24);
            this.restaurantComboBoxList.TabIndex = 0;
            // 
            // foodCheckListBox
            // 
            this.foodCheckListBox.BackColor = System.Drawing.Color.Silver;
            this.foodCheckListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodCheckListBox.FormattingEnabled = true;
            this.foodCheckListBox.Items.AddRange(new object[] {
            "Blueberries",
            "Avocados",
            "Kale",
            "Avocados",
            "Leafy green vegetables",
            "Sweet potatoes.",
            "Broccoli",
            "Legumes",
            "Meat"});
            this.foodCheckListBox.Location = new System.Drawing.Point(176, 126);
            this.foodCheckListBox.Name = "foodCheckListBox";
            this.foodCheckListBox.Size = new System.Drawing.Size(173, 76);
            this.foodCheckListBox.TabIndex = 1;
            // 
            // bkashRadioButton
            // 
            this.bkashRadioButton.AutoSize = true;
            this.bkashRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.bkashRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkashRadioButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bkashRadioButton.Location = new System.Drawing.Point(205, 248);
            this.bkashRadioButton.Name = "bkashRadioButton";
            this.bkashRadioButton.Size = new System.Drawing.Size(65, 21);
            this.bkashRadioButton.TabIndex = 2;
            this.bkashRadioButton.TabStop = true;
            this.bkashRadioButton.Text = "Bkash";
            this.bkashRadioButton.UseVisualStyleBackColor = false;
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveButton.Location = new System.Drawing.Point(205, 301);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 35);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // handCashRadioButton
            // 
            this.handCashRadioButton.AutoSize = true;
            this.handCashRadioButton.BackColor = System.Drawing.SystemColors.Control;
            this.handCashRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handCashRadioButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.handCashRadioButton.Location = new System.Drawing.Point(275, 248);
            this.handCashRadioButton.Name = "handCashRadioButton";
            this.handCashRadioButton.Size = new System.Drawing.Size(90, 21);
            this.handCashRadioButton.TabIndex = 2;
            this.handCashRadioButton.TabStop = true;
            this.handCashRadioButton.Text = "Handcash";
            this.handCashRadioButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Restaurant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Food List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Online Food Order";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.handCashRadioButton);
            this.Controls.Add(this.bkashRadioButton);
            this.Controls.Add(this.foodCheckListBox);
            this.Controls.Add(this.restaurantComboBoxList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Online Food Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox restaurantComboBoxList;
        private System.Windows.Forms.CheckedListBox foodCheckListBox;
        private System.Windows.Forms.RadioButton bkashRadioButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton handCashRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

