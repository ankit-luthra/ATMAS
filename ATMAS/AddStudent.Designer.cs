
namespace ATMAS
{
    partial class AddStudentForm
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
            this.components = new System.ComponentModel.Container();
            this.firstNameLabel = new MetroFramework.Controls.MetroLabel();
            this.lastNameLabel = new MetroFramework.Controls.MetroLabel();
            this.firstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.courseNameLabel = new MetroFramework.Controls.MetroLabel();
            this.courseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ATMAS.DataSet1();
            this.coursesTableAdapter = new ATMAS.DataSet1TableAdapters.CoursesTableAdapter();
            this.studentSubmitButton = new MetroFramework.Controls.MetroButton();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new ATMAS.DataSet1TableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(23, 78);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 19);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(23, 121);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(74, 19);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(126, 78);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(227, 23);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(126, 122);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(227, 23);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(23, 168);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(93, 19);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Course Name:";
            // 
            // courseComboBox
            // 
            this.courseComboBox.DataSource = this.coursesBindingSource;
            this.courseComboBox.DisplayMember = "CourseName";
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.ItemHeight = 23;
            this.courseComboBox.Location = new System.Drawing.Point(126, 166);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(227, 29);
            this.courseComboBox.TabIndex = 2;
            this.courseComboBox.ValueMember = "CourseID";
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // studentSubmitButton
            // 
            this.studentSubmitButton.Location = new System.Drawing.Point(179, 217);
            this.studentSubmitButton.Name = "studentSubmitButton";
            this.studentSubmitButton.Size = new System.Drawing.Size(97, 41);
            this.studentSubmitButton.TabIndex = 3;
            this.studentSubmitButton.Text = "Submit";
            this.studentSubmitButton.Click += new System.EventHandler(this.studentSubmitButton_Click);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(437, 281);
            this.Controls.Add(this.studentSubmitButton);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "AddStudentForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel firstNameLabel;
        private MetroFramework.Controls.MetroLabel lastNameLabel;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroLabel courseNameLabel;
        private MetroFramework.Controls.MetroComboBox courseComboBox;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private DataSet1TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private MetroFramework.Controls.MetroButton studentSubmitButton;
    }
}