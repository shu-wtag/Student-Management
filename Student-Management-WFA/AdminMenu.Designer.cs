namespace Student_Management_WFA
{
    partial class AdminMenu
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
            menuStrip1 = new MenuStrip();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            AddCourse = new ToolStripMenuItem();
            CourseDetails = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            AddStudent = new ToolStripMenuItem();
            StudentDetails = new ToolStripMenuItem();
            teacherToolStripMenuItem = new ToolStripMenuItem();
            AddTeacher = new ToolStripMenuItem();
            TeacherDetails = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { coursesToolStripMenuItem, studentToolStripMenuItem, teacherToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddCourse, CourseDetails });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(61, 20);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // AddCourse
            // 
            AddCourse.Name = "AddCourse";
            AddCourse.Size = new Size(180, 22);
            AddCourse.Text = "Add Course";
            AddCourse.Click += AddCourse_Click;
            // 
            // CourseDetails
            // 
            CourseDetails.Name = "CourseDetails";
            CourseDetails.Size = new Size(180, 22);
            CourseDetails.Text = "Course Details";
            CourseDetails.Click += CourseDetails_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddStudent, StudentDetails });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(60, 20);
            studentToolStripMenuItem.Text = "Student";
            // 
            // AddStudent
            // 
            AddStudent.Name = "AddStudent";
            AddStudent.Size = new Size(153, 22);
            AddStudent.Text = "Add Student";
            AddStudent.Click += AddStudent_Click;
            // 
            // StudentDetails
            // 
            StudentDetails.Name = "StudentDetails";
            StudentDetails.Size = new Size(153, 22);
            StudentDetails.Text = "Student Details";
            StudentDetails.Click += StudentDetails_Click;
            // 
            // teacherToolStripMenuItem
            // 
            teacherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddTeacher, TeacherDetails });
            teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            teacherToolStripMenuItem.Size = new Size(59, 20);
            teacherToolStripMenuItem.Text = "Teacher";
            // 
            // AddTeacher
            // 
            AddTeacher.Name = "AddTeacher";
            AddTeacher.Size = new Size(180, 22);
            AddTeacher.Text = "Add Teacher";
            AddTeacher.Click += AddTeacher_Click;
            // 
            // TeacherDetails
            // 
            TeacherDetails.Name = "TeacherDetails";
            TeacherDetails.Size = new Size(180, 22);
            TeacherDetails.Text = "Teacher Details";
            TeacherDetails.Click += TeacherDetails_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(59, 20);
            logOutToolStripMenuItem.Text = "LogOut";
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminMenu";
            Text = "AdminMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem AddCourse;
        private ToolStripMenuItem CourseDetails;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem AddStudent;
        private ToolStripMenuItem StudentDetails;
        private ToolStripMenuItem teacherToolStripMenuItem;
        private ToolStripMenuItem AddTeacher;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem TeacherDetails;
    }
}