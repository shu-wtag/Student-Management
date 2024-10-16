namespace Student_Management_WFA
{
    partial class RegisterForm
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
            Register = new Label();
            Username = new Label();
            Email = new Label();
            Password = new Label();
            UserNameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SignUp = new Button();
            SuspendLayout();
            // 
            // Register
            // 
            Register.Anchor = AnchorStyles.None;
            Register.AutoSize = true;
            Register.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Register.Location = new Point(312, 61);
            Register.Name = "Register";
            Register.Size = new Size(203, 32);
            Register.TabIndex = 0;
            Register.Text = "Register Form";
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.None;
            Username.AutoSize = true;
            Username.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(285, 155);
            Username.Name = "Username";
            Username.Size = new Size(87, 19);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.None;
            Email.AutoSize = true;
            Email.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.Location = new Point(285, 200);
            Email.Name = "Email";
            Email.Size = new Size(51, 19);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.AutoSize = true;
            Password.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(285, 242);
            Password.Name = "Password";
            Password.Size = new Size(86, 19);
            Password.TabIndex = 0;
            Password.Text = "Password";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Anchor = AnchorStyles.None;
            UserNameTextBox.Location = new Point(449, 156);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(100, 23);
            UserNameTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.None;
            EmailTextBox.Location = new Point(449, 196);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(100, 23);
            EmailTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.None;
            PasswordTextBox.Location = new Point(449, 238);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 2;
            // 
            // SignUp
            // 
            SignUp.Anchor = AnchorStyles.None;
            SignUp.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp.Location = new Point(380, 288);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(94, 32);
            SignUp.TabIndex = 2;
            SignUp.Text = "SignUp";
            SignUp.UseVisualStyleBackColor = true;
            SignUp.Click += SignUp_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SignUp);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(Username);
            Controls.Add(Register);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Register;
        private Label Username;
        private Label Email;
        private Label Password;
        private TextBox UserNameTextBox;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private Button SignUp;
    }
}