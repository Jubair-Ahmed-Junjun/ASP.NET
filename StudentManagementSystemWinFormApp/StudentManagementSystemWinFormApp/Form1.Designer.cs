
namespace StudentManagementSystemWinFormApp
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
            this.buttonSaveButton = new System.Windows.Forms.Button();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentEmailTextBox = new System.Windows.Forms.TextBox();
            this.studentDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentInfoListBox = new System.Windows.Forms.ListBox();
            this.viewStudentInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaveButton
            // 
            this.buttonSaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaveButton.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveButton.Location = new System.Drawing.Point(270, 258);
            this.buttonSaveButton.Name = "buttonSaveButton";
            this.buttonSaveButton.Size = new System.Drawing.Size(75, 27);
            this.buttonSaveButton.TabIndex = 0;
            this.buttonSaveButton.Text = "Save";
            this.buttonSaveButton.UseVisualStyleBackColor = false;
            this.buttonSaveButton.Click += new System.EventHandler(this.buttonSaveButton_Click);
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdTextBox.Location = new System.Drawing.Point(165, 114);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(180, 21);
            this.studentIdTextBox.TabIndex = 1;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameTextBox.Location = new System.Drawing.Point(165, 141);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(180, 21);
            this.studentNameTextBox.TabIndex = 1;
            // 
            // studentEmailTextBox
            // 
            this.studentEmailTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentEmailTextBox.Location = new System.Drawing.Point(165, 167);
            this.studentEmailTextBox.Name = "studentEmailTextBox";
            this.studentEmailTextBox.Size = new System.Drawing.Size(180, 21);
            this.studentEmailTextBox.TabIndex = 1;
            // 
            // studentDepartmentTextBox
            // 
            this.studentDepartmentTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentDepartmentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDepartmentTextBox.Location = new System.Drawing.Point(165, 193);
            this.studentDepartmentTextBox.Name = "studentDepartmentTextBox";
            this.studentDepartmentTextBox.Size = new System.Drawing.Size(180, 21);
            this.studentDepartmentTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "StudentId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Student Information";
            // 
            // studentInfoListBox
            // 
            this.studentInfoListBox.FormattingEnabled = true;
            this.studentInfoListBox.Location = new System.Drawing.Point(392, 114);
            this.studentInfoListBox.Name = "studentInfoListBox";
            this.studentInfoListBox.Size = new System.Drawing.Size(444, 121);
            this.studentInfoListBox.TabIndex = 4;
            // 
            // viewStudentInfo
            // 
            this.viewStudentInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewStudentInfo.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewStudentInfo.Location = new System.Drawing.Point(761, 258);
            this.viewStudentInfo.Name = "viewStudentInfo";
            this.viewStudentInfo.Size = new System.Drawing.Size(75, 27);
            this.viewStudentInfo.TabIndex = 0;
            this.viewStudentInfo.Text = "Refresh";
            this.viewStudentInfo.UseVisualStyleBackColor = false;
            this.viewStudentInfo.Click += new System.EventHandler(this.viewStudentInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(848, 361);
            this.Controls.Add(this.studentInfoListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentDepartmentTextBox);
            this.Controls.Add(this.studentEmailTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.viewStudentInfo);
            this.Controls.Add(this.buttonSaveButton);
            this.Name = "Form1";
            this.Text = "University Management System";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveButton;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentEmailTextBox;
        private System.Windows.Forms.TextBox studentDepartmentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox studentInfoListBox;
        private System.Windows.Forms.Button viewStudentInfo;
    }
}

