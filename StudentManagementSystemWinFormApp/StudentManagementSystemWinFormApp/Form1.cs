using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystemWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.studentId = studentIdTextBox.Text;
            student.studentName = studentNameTextBox.Text;
            student.studentEmail = studentEmailTextBox.Text;
            student.studentDepartment = studentDepartmentTextBox.Text;
            saveStudent(student);
        }
        public void saveStudent(Student studentInfo)
        {
            string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = StudentManagementSystem; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connect);
            string sqlQuery = "INSERT INTO StudentInfo(studentId,studentName,studentEmail,studentDepartment)VALUES('" + studentInfo.studentId+"','" +studentInfo.studentName+ "','"+studentInfo.studentEmail+"','"+studentInfo.studentDepartment+"')";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(rowAffected>=0)
            {
                MessageBox.Show("Data Save Successfully..!");
            }
            else
            {
                MessageBox.Show("Data not Saved");
            }
            Console.ReadLine();
        }

        private void viewStudentInfo_Click(object sender, EventArgs e)
        {
            infoStudent();
        }
        public void infoStudent()
        {
            studentInfoListBox.Items.Clear();
            string connect = @"Server = DESKTOP-NRHJE6N\SQLEXPRESS; Database = StudentManagementSystem; Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connect);
            string sqlQuery = "SELECT * FROM StudentInfo";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Student> studentInfo = new List<Student>();
            while (reader.Read())
            {
                Student student = new Student();
                student.studentId = reader["studentId"].ToString();
                student.studentName = reader["studentName"].ToString();
                student.studentEmail = reader["studentEmail"].ToString();
                student.studentDepartment = reader["studentDepartment"].ToString();
                studentInfo.Add(student);
            }
            foreach (var students in studentInfo)
            {
                string tempVar = "Student Id : " + students.studentId + " Student Name : " + students.studentName + " Student Email : " + students.studentEmail + " Student Department : " + students.studentDepartment;
                studentInfoListBox.Items.Add(tempVar);
                studentInfoListBox.Items.Add("");
            }
        }
    }
}
