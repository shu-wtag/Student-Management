namespace Student_Management_WFA
{
    partial class Menu
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
            adminToolStripMenuItem = new ToolStripMenuItem();
            SignUp = new ToolStripMenuItem();
            SignIn = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            StudentLogin = new ToolStripMenuItem();
            teacherToolStripMenuItem = new ToolStripMenuItem();
            TeacherLogin = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, studentToolStripMenuItem, teacherToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SignUp, SignIn });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // SignUp
            // 
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(112, 22);
            SignUp.Text = "SignUp";
            SignUp.Click += SignUp_Click;
            // 
            // SignIn
            // 
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(112, 22);
            SignIn.Text = "SignIn";
            SignIn.Click += SignIn_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { StudentLogin });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(60, 20);
            studentToolStripMenuItem.Text = "Student";
            // 
            // StudentLogin
            // 
            StudentLogin.Name = "StudentLogin";
            StudentLogin.Size = new Size(180, 22);
            StudentLogin.Text = "Student Login";
            StudentLogin.Click += StudentLogin_Click;
            // 
            // teacherToolStripMenuItem
            // 
            teacherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TeacherLogin });
            teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            teacherToolStripMenuItem.Size = new Size(59, 20);
            teacherToolStripMenuItem.Text = "Teacher";
            // 
            // TeacherLogin
            // 
            TeacherLogin.CheckOnClick = true;
            TeacherLogin.Name = "TeacherLogin";
            TeacherLogin.Size = new Size(147, 22);
            TeacherLogin.Text = "Teacher Login";
            TeacherLogin.Click += TeacherLogin_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem SignUp;
        private ToolStripMenuItem SignIn;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem StudentLogin;
        private ToolStripMenuItem teacherToolStripMenuItem;
        private ToolStripMenuItem TeacherLogin;
    }
}