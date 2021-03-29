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
    public partial class AddStudentForm : MetroFramework.Forms.MetroForm
    {

        public int userID { get; set; }

        public AddStudentForm(int ID)
        {
            InitializeComponent();
            this.userID = ID;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            //DashboardForm dbf = new DashboardForm();

            // TODO: This line of code loads data into the 'dataSet1.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.FillCourse(this.dataSet1.Courses);

            //userID = dbf.userID;

            coursesBindingSource.Filter = "ProfessorID = '" + userID + "'";




        }

        private void studentSubmitButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.StudentsTableAdapter studentsTA = new DataSet1TableAdapters.StudentsTableAdapter();
            int selectedCourseID = (int)courseComboBox.SelectedValue;
            Console.WriteLine(selectedCourseID);
            studentsTA.InsertStudents(firstNameTextBox.Text, lastNameTextBox.Text, selectedCourseID);
            Close();
        }
    }
}
