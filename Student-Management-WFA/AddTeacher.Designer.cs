namespace Student_Management_WFA
{
    partial class AddTeacher
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
            Clear = new Button();
            Back = new Button();
            Add = new Button();
            textBox1 = new TextBox();
            CreditTextBox = new TextBox();
            CrsNameTextBox = new TextBox();
            Password = new Label();
            Teacher = new Label();
            Email = new Label();
            Name = new Label();
            SuspendLayout();
            // 
            // Clear
            // 
            Clear.Anchor = AnchorStyles.None;
            Clear.BackColor = SystemColors.ActiveCaption;
            Clear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.Location = new Point(474, 318);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 32);
            Clear.TabIndex = 23;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            Back.Anchor = AnchorStyles.None;
            Back.BackColor = SystemColors.ActiveCaption;
            Back.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(251, 318);
            Back.Name = "Back";
            Back.Size = new Size(75, 32);
            Back.TabIndex = 21;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.None;
            Add.BackColor = SystemColors.ActiveCaption;
            Add.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(361, 318);
            Add.Name = "Add";
            Add.Size = new Size(75, 32);
            Add.TabIndex = 22;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(385, 269);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 18;
            // 
            // CreditTextBox
            // 
            CreditTextBox.Anchor = AnchorStyles.None;
            CreditTextBox.Location = new Point(385, 222);
            CreditTextBox.Name = "CreditTextBox";
            CreditTextBox.Size = new Size(146, 23);
            CreditTextBox.TabIndex = 19;
            // 
            // CrsNameTextBox
            // 
            CrsNameTextBox.Anchor = AnchorStyles.None;
            CrsNameTextBox.Location = new Point(385, 180);
            CrsNameTextBox.Name = "CrsNameTextBox";
            CrsNameTextBox.Size = new Size(146, 23);
            CrsNameTextBox.TabIndex = 14;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.AutoSize = true;
            Password.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(275, 269);
            Password.Name = "Password";
            Password.Size = new Size(86, 19);
            Password.TabIndex = 15;
            Password.Text = "Password";
            // 
            // Teacher
            // 
            Teacher.Anchor = AnchorStyles.None;
            Teacher.AutoSize = true;
            Teacher.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Teacher.Location = new Point(321, 101);
            Teacher.Name = "Teacher";
            Teacher.Size = new Size(179, 32);
            Teacher.TabIndex = 20;
            Teacher.Text = "Add Teacher";
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.None;
            Email.AutoSize = true;
            Email.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.Location = new Point(275, 222);
            Email.Name = "Email";
            Email.Size = new Size(51, 19);
            Email.TabIndex = 16;
            Email.Text = "Email";
            // 
            // Name
            // 
            Name.Anchor = AnchorStyles.None;
            Name.AutoSize = true;
            Name.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.Location = new Point(275, 180);
            Name.Name = "Name";
            Name.Size = new Size(53, 19);
            Name.TabIndex = 17;
            Name.Text = "Name";
            // 
            // AddTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Clear);
            Controls.Add(Back);
            Controls.Add(Add);
            Controls.Add(textBox1);
            Controls.Add(CreditTextBox);
            Controls.Add(CrsNameTextBox);
            Controls.Add(Password);
            Controls.Add(Teacher);
            Controls.Add(Email);
            Controls.Add(Name);
            Text = "AddTeacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Clear;
        private Button Back;
        private Button Add;
        private TextBox textBox1;
        private TextBox CreditTextBox;
        private TextBox CrsNameTextBox;
        private Label Password;
        private Label Teacher;
        private Label Email;
        private Label Name;
    }
}