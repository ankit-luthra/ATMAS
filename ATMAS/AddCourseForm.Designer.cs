
namespace ATMAS
{
    partial class AddCourseForm
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
            this.courseNameLabel = new MetroFramework.Controls.MetroLabel();
            this.courseAddButton = new MetroFramework.Controls.MetroButton();
            this.courseTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(96, 81);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(93, 19);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = "Course Name:";
            // 
            // courseAddButton
            // 
            this.courseAddButton.Location = new System.Drawing.Point(241, 133);
            this.courseAddButton.Name = "courseAddButton";
            this.courseAddButton.Size = new System.Drawing.Size(75, 23);
            this.courseAddButton.TabIndex = 1;
            this.courseAddButton.Text = "Submit";
            this.courseAddButton.Click += new System.EventHandler(this.courseAddButton_Click);
            // 
            // courseTextBox
            // 
            this.courseTextBox.Location = new System.Drawing.Point(99, 104);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(217, 23);
            this.courseTextBox.TabIndex = 2;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(406, 257);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(this.courseAddButton);
            this.Controls.Add(this.courseNameLabel);
            this.Name = "AddCourseForm";
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel courseNameLabel;
        private MetroFramework.Controls.MetroButton courseAddButton;
        private MetroFramework.Controls.MetroTextBox courseTextBox;
    }
}