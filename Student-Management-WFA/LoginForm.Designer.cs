namespace Student_Management_WFA
{
    partial class LoginForm
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
            SignIn = new Button();
            UserNameTextBox = new TextBox();
            Username = new Label();
            Login = new Label();
            label1 = new Label();
            PasswordTextbox = new TextBox();
            LogOut = new Button();
            SuspendLayout();
            // 
            // SignIn
            // 
            SignIn.Anchor = AnchorStyles.None;
            SignIn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignIn.Location = new Point(405, 270);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(94, 32);
            SignIn.TabIndex = 9;
            SignIn.Text = "Sign In";
            SignIn.UseVisualStyleBackColor = true;
            SignIn.Click += SignIn_Click;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Anchor = AnchorStyles.None;
            UserNameTextBox.Location = new Point(432, 178);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(100, 23);
            UserNameTextBox.TabIndex = 3;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.None;
            Username.AutoSize = true;
            Username.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.Location = new Point(268, 177);
            Username.Name = "Username";
            Username.Size = new Size(87, 19);
            Username.TabIndex = 6;
            Username.Text = "Username";
            // 
            // Login
            // 
            Login.Anchor = AnchorStyles.None;
            Login.AutoSize = true;
            Login.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.Location = new Point(344, 111);
            Login.Name = "Login";
            Login.Size = new Size(98, 32);
            Login.TabIndex = 7;
            Login.Text = "Login ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 221);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Anchor = AnchorStyles.None;
            PasswordTextbox.Location = new Point(432, 217);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(100, 23);
            PasswordTextbox.TabIndex = 10;
            // 
            // LogOut
            // 
            LogOut.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOut.Location = new Point(295, 270);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(75, 32);
            LogOut.TabIndex = 12;
            LogOut.Text = "LogOut";
            LogOut.UseVisualStyleBackColor = true;
            LogOut.Click += LogOut_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogOut);
            Controls.Add(SignIn);
            Controls.Add(PasswordTextbox);
            Controls.Add(label1);
            Controls.Add(UserNameTextBox);
            Controls.Add(Username);
            Controls.Add(Login);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignIn;
        private TextBox UserNameTextBox;
        private Label Username;
        private Label Login;
        private Label label1;
        private TextBox PasswordTextbox;
        private Button LogOut;
    }
}