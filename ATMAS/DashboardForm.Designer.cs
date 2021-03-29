
namespace ATMAS
{
    partial class DashboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabAttendancePage = new MetroFramework.Controls.MetroTabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.userNameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.userNameValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.addStudentButton = new MetroFramework.Controls.MetroButton();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.getDataButton = new MetroFramework.Controls.MetroButton();
            this.addCourseButton = new MetroFramework.Controls.MetroButton();
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.attendanceGridView = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ATMAS.DataSet1();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.courseComboBox = new MetroFramework.Controls.MetroComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateLabel = new MetroFramework.Controls.MetroLabel();
            this.CourseLabel = new MetroFramework.Controls.MetroLabel();
            this.tabReportPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.courseComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.secretButton = new MetroFramework.Controls.MetroButton();
            this.randomizeButton = new MetroFramework.Controls.MetroButton();
            this.loadButton = new MetroFramework.Controls.MetroButton();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new ATMAS.DataSet1TableAdapters.CoursesTableAdapter();
            this.studentsTableAdapter = new ATMAS.DataSet1TableAdapters.StudentsTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabAttendancePage.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.tabReportPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAttendancePage);
            this.tabControl.Controls.Add(this.tabReportPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(780, 478);
            this.tabControl.TabIndex = 0;
            // 
            // tabAttendancePage
            // 
            this.tabAttendancePage.Controls.Add(this.statusStrip);
            this.tabAttendancePage.Controls.Add(this.addStudentButton);
            this.tabAttendancePage.Controls.Add(this.clearButton);
            this.tabAttendancePage.Controls.Add(this.getDataButton);
            this.tabAttendancePage.Controls.Add(this.addCourseButton);
            this.tabAttendancePage.Controls.Add(this.saveButton);
            this.tabAttendancePage.Controls.Add(this.attendanceGridView);
            this.tabAttendancePage.Controls.Add(this.datePicker);
            this.tabAttendancePage.Controls.Add(this.courseComboBox);
            this.tabAttendancePage.Controls.Add(this.dateLabel);
            this.tabAttendancePage.Controls.Add(this.CourseLabel);
            this.tabAttendancePage.HorizontalScrollbarBarColor = true;
            this.tabAttendancePage.Location = new System.Drawing.Point(4, 35);
            this.tabAttendancePage.Name = "tabAttendancePage";
            this.tabAttendancePage.Size = new System.Drawing.Size(772, 439);
            this.tabAttendancePage.TabIndex = 0;
            this.tabAttendancePage.Text = "Attendance";
            this.tabAttendancePage.VerticalScrollbarBarColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameStatusLabel,
            this.userNameValueLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 417);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(772, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip";
            // 
            // userNameStatusLabel
            // 
            this.userNameStatusLabel.Name = "userNameStatusLabel";
            this.userNameStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.userNameStatusLabel.Text = "User Name:";
            // 
            // userNameValueLabel
            // 
            this.userNameValueLabel.Name = "userNameValueLabel";
            this.userNameValueLabel.Size = new System.Drawing.Size(12, 17);
            this.userNameValueLabel.Text = "-";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(658, 75);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(91, 39);
            this.addStudentButton.TabIndex = 6;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(558, 260);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(91, 43);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            // 
            // getDataButton
            // 
            this.getDataButton.Location = new System.Drawing.Point(380, 26);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(90, 29);
            this.getDataButton.TabIndex = 6;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(659, 30);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(90, 39);
            this.addCourseButton.TabIndex = 6;
            this.addCourseButton.Text = "Add Course";
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(559, 189);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 43);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // attendanceGridView
            // 
            this.attendanceGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.attendanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.attendanceGridView.DataSource = this.attendanceDataTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.attendanceGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.attendanceGridView.Location = new System.Drawing.Point(13, 81);
            this.attendanceGridView.Name = "attendanceGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.attendanceGridView.Size = new System.Drawing.Size(539, 319);
            this.attendanceGridView.TabIndex = 5;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // attendanceDataTableBindingSource
            // 
            this.attendanceDataTableBindingSource.DataMember = "AttendanceDataTable";
            this.attendanceDataTableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(164, 30);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(199, 20);
            this.datePicker.TabIndex = 4;
            // 
            // courseComboBox
            // 
            this.courseComboBox.DataSource = this.coursesBindingSource;
            this.courseComboBox.DisplayMember = "CourseName";
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.ItemHeight = 23;
            this.courseComboBox.Location = new System.Drawing.Point(13, 26);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(145, 29);
            this.courseComboBox.TabIndex = 3;
            this.courseComboBox.ValueMember = "CourseID";
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.dataSet1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(164, 4);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 19);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Date:";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(13, 4);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(53, 19);
            this.CourseLabel.TabIndex = 2;
            this.CourseLabel.Text = "Course:";
            // 
            // tabReportPage
            // 
            this.tabReportPage.Controls.Add(this.metroLabel1);
            this.tabReportPage.Controls.Add(this.courseComboBox2);
            this.tabReportPage.Controls.Add(this.secretButton);
            this.tabReportPage.Controls.Add(this.randomizeButton);
            this.tabReportPage.Controls.Add(this.loadButton);
            this.tabReportPage.Controls.Add(this.studentsListBox);
            this.tabReportPage.HorizontalScrollbarBarColor = true;
            this.tabReportPage.Location = new System.Drawing.Point(4, 35);
            this.tabReportPage.Name = "tabReportPage";
            this.tabReportPage.Size = new System.Drawing.Size(772, 439);
            this.tabReportPage.TabIndex = 1;
            this.tabReportPage.Text = "Report";
            this.tabReportPage.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Course:";
            // 
            // courseComboBox2
            // 
            this.courseComboBox2.DataSource = this.coursesBindingSource;
            this.courseComboBox2.DisplayMember = "CourseName";
            this.courseComboBox2.FormattingEnabled = true;
            this.courseComboBox2.ItemHeight = 23;
            this.courseComboBox2.Location = new System.Drawing.Point(59, 43);
            this.courseComboBox2.Name = "courseComboBox2";
            this.courseComboBox2.Size = new System.Drawing.Size(181, 29);
            this.courseComboBox2.TabIndex = 4;
            this.courseComboBox2.ValueMember = "CourseID";
            // 
            // secretButton
            // 
            this.secretButton.Location = new System.Drawing.Point(721, 379);
            this.secretButton.Name = "secretButton";
            this.secretButton.Size = new System.Drawing.Size(23, 21);
            this.secretButton.TabIndex = 3;
            // 
            // randomizeButton
            // 
            this.randomizeButton.Location = new System.Drawing.Point(258, 80);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(107, 32);
            this.randomizeButton.TabIndex = 3;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(258, 43);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(107, 31);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Load";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // studentsListBox
            // 
            this.studentsListBox.BackColor = System.Drawing.SystemColors.Control;
            this.studentsListBox.DataSource = this.studentsBindingSource;
            this.studentsListBox.DisplayMember = "FirstName";
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.Location = new System.Drawing.Point(401, 31);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(343, 342);
            this.studentsListBox.TabIndex = 2;
            this.studentsListBox.ValueMember = "StudentID";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.dataSet1;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 558);
            this.Controls.Add(this.tabControl);
            this.MinimizeBox = false;
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.DashboardForm_Act);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabAttendancePage.ResumeLayout(false);
            this.tabAttendancePage.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.tabReportPage.ResumeLayout(false);
            this.tabReportPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage tabAttendancePage;
        private MetroFramework.Controls.MetroTabPage tabReportPage;
        private MetroFramework.Controls.MetroButton clearButton;
        private MetroFramework.Controls.MetroButton saveButton;
        private System.Windows.Forms.DataGridView attendanceGridView;
        private System.Windows.Forms.DateTimePicker datePicker;
        private MetroFramework.Controls.MetroComboBox courseComboBox;
        private MetroFramework.Controls.MetroLabel dateLabel;
        private MetroFramework.Controls.MetroLabel CourseLabel;
        private MetroFramework.Controls.MetroButton addStudentButton;
        private MetroFramework.Controls.MetroButton getDataButton;
        private MetroFramework.Controls.MetroButton addCourseButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel userNameStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel userNameValueLabel;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private DataSet1TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource attendanceDataTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton secretButton;
        private MetroFramework.Controls.MetroButton loadButton;
        private System.Windows.Forms.ListBox studentsListBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox courseComboBox2;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private DataSet1TableAdapters.StudentsTableAdapter studentsTableAdapter;
        private MetroFramework.Controls.MetroButton randomizeButton;
    }
}

