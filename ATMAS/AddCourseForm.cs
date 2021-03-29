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
    public partial class AddCourseForm : MetroFramework.Forms.MetroForm
    {
        public int ProfessorID { get; set; }

        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void courseAddButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.CoursesTableAdapter courseAdapter = new DataSet1TableAdapters.CoursesTableAdapter();
            courseAdapter.AddCourse(courseTextBox.Text, ProfessorID);
            Close();
        }
    }
}
