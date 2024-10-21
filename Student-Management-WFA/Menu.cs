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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            registerForm = null;
            this.Show();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            loginForm = null;
            this.Show();
        }

        private void StudentLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogIn StloginForm = new StudentLogIn();
            StloginForm.ShowDialog();
            StloginForm = null;
            this.Show();
        }

        private void TeacherLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherLogIn TcloginForm = new TeacherLogIn();
            TcloginForm.ShowDialog();
            TcloginForm = null;
            this.Show();
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
