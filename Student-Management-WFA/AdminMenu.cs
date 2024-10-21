using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_WFA
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddCourse_Click(object sender, EventArgs e)
        {
            CourseForm addCourse = new CourseForm();
            addCourse.Show();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void AddTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTeacher addTeacher = new AddTeacher();
            addTeacher.ShowDialog();
            addTeacher = null;
            this.Show();
        }

        private void StudentDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStudents viewStudents = new ViewStudents();
            viewStudents.ShowDialog();
            viewStudents = null;
            this.Show();
        }

        private void TeacherDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherDetails teacherdetails = new TeacherDetails();
            teacherdetails.ShowDialog();
            teacherdetails = null;
            this.Show();
        }

        private void CourseDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseDetails coursedetails = new CourseDetails();
            coursedetails.ShowDialog();
            coursedetails = null;
            this.Show();
        }
    }
}
