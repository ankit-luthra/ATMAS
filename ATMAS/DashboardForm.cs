using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMAS
{
    public partial class DashboardForm : MetroFramework.Forms.MetroForm
    {
        public bool loggedIn { get; set; }
        public int userID { get; set; }
        public string userName { get; set; }

        public DashboardForm()
        {
            InitializeComponent();
            loggedIn = false;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            
            if (loggedIn == false)
            {
                LoginForm new_login = new LoginForm();
                new_login.ShowDialog();

                if (new_login.LoginFlag == false)
                {
                    //new_login.Close();
                    Close();
                }
                else
                {
                    loggedIn = true;
                    userID = new_login.UserID;
                    userName = new_login.UserName;
                    userNameValueLabel.Text = userName;

                    FillCourses();
                }
            }
        }

        private void DashboardForm_Act(object sender, EventArgs e)
        {
            
        }

        private void addCourseButton_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourse = new AddCourseForm();
            addCourse.ProfessorID = this.userID;
            addCourse.ShowDialog();
            FillCourses();
        }

        private void FillCourses()
        {
            // TODO: This line of code loads data into the 'dataSet1.Courses' table.
            this.coursesTableAdapter.FillCourse(this.dataSet1.Courses);
            coursesBindingSource.Filter = "ProfessorID = '" + userID.ToString() + "'";
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm(this.userID);
            addStudent.ShowDialog();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AttendanceTableAdapter attTA = new DataSet1TableAdapters.AttendanceTableAdapter();
            DataTable attendanceData = attTA.GetDataByCourseDate((int)courseComboBox.SelectedValue, datePicker.Text);
            //DataTable attendanceData1 = attTA.

            DataSet1TableAdapters.StudentsTableAdapter studentsTACheck = new DataSet1TableAdapters.StudentsTableAdapter();
            DataTable studentsDataCheck = studentsTACheck.GetDataByCourseID((int)courseComboBox.SelectedValue);

            //Checking to see if we have records in the table
            //If yes, we can edit them
            if (attendanceData.Rows.Count > 0)
            {
                DataTable new_attendanceData = attTA.GetDataByCourseDate((int)courseComboBox.SelectedValue, datePicker.Text);
                attendanceGridView.DataSource = new_attendanceData;
            }
            
            //if no data in table then get students list from the students table and insert to the table
            else
            {
                DataSet1TableAdapters.StudentsTableAdapter studentsTA = new DataSet1TableAdapters.StudentsTableAdapter();
                DataTable studentsData = studentsTA.GetDataByCourseID((int)courseComboBox.SelectedValue);

                foreach (DataRow data in studentsData.Rows)
                {
                    //inserting data for each student from students table
                    attTA.InsertAttendance((int)data[0], (int)courseComboBox.SelectedValue, datePicker.Text, "", "", data[1].ToString(), data[2].ToString());

                }
                DataTable new_attendanceData = attTA.GetDataByCourseDate((int)courseComboBox.SelectedValue, datePicker.Text);
                attendanceGridView.DataSource = new_attendanceData;
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AttendanceTableAdapter attTA = new DataSet1TableAdapters.AttendanceTableAdapter();

            foreach (DataGridViewRow gridRow in attendanceGridView.Rows)
            {
                if(gridRow.Cells[3].Value != null || gridRow.Cells[4].Value != null)
                {
                    attTA.UpdateAttendance(gridRow.Cells[3].Value.ToString(), gridRow.Cells[4].Value.ToString(), (int)courseComboBox.SelectedValue, datePicker.Text, (int)gridRow.Cells[0].Value);
                   
                }
            }
            MessageBox.Show("Successfully Updated!");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.FillStudents(this.dataSet1.Students);
            studentsBindingSource.Filter = "CourseID = '" + (int)courseComboBox2.SelectedValue + "'";
        }
    }
}