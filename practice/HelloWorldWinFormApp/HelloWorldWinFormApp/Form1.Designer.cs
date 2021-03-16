
namespace HelloWorldWinFormApp
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
            this.showMeButton = new System.Windows.Forms.Button();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showMeButton
            // 
            this.showMeButton.Location = new System.Drawing.Point(324, 53);
            this.showMeButton.Name = "showMeButton";
            this.showMeButton.Size = new System.Drawing.Size(75, 23);
            this.showMeButton.TabIndex = 0;
            this.showMeButton.Text = "Show me";
            this.showMeButton.UseVisualStyleBackColor = true;
            this.showMeButton.Click += new System.EventHandler(this.alertButton_Click);
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(169, 53);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(100, 20);
            this.userInputTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.showMeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showMeButton;
        private System.Windows.Forms.TextBox userInputTextBox;
    }
}

