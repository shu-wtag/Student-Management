namespace Student_Management_WFA
{
    partial class AddStudent
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
            CreditTextBox = new TextBox();
            CrsNameTextBox = new TextBox();
            STudent = new Label();
            Email = new Label();
            Name = new Label();
            Password = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Clear
            // 
            Clear.Anchor = AnchorStyles.None;
            Clear.BackColor = SystemColors.ActiveCaption;
            Clear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.Location = new Point(495, 338);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 32);
            Clear.TabIndex = 13;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            Back.Anchor = AnchorStyles.None;
            Back.BackColor = SystemColors.ActiveCaption;
            Back.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(272, 338);
            Back.Name = "Back";
            Back.Size = new Size(75, 32);
            Back.TabIndex = 11;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.None;
            Add.BackColor = SystemColors.ActiveCaption;
            Add.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(382, 338);
            Add.Name = "Add";
            Add.Size = new Size(75, 32);
            Add.TabIndex = 12;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            // 
            // CreditTextBox
            // 
            CreditTextBox.Anchor = AnchorStyles.None;
            CreditTextBox.Location = new Point(406, 242);
            CreditTextBox.Name = "CreditTextBox";
            CreditTextBox.Size = new Size(146, 23);
            CreditTextBox.TabIndex = 9;
            // 
            // CrsNameTextBox
            // 
            CrsNameTextBox.Anchor = AnchorStyles.None;
            CrsNameTextBox.Location = new Point(406, 200);
            CrsNameTextBox.Name = "CrsNameTextBox";
            CrsNameTextBox.Size = new Size(146, 23);
            CrsNameTextBox.TabIndex = 6;
            // 
            // STudent
            // 
            STudent.Anchor = AnchorStyles.None;
            STudent.AutoSize = true;
            STudent.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            STudent.Location = new Point(342, 121);
            STudent.Name = "STudent";
            STudent.Size = new Size(177, 32);
            STudent.TabIndex = 10;
            STudent.Text = "Add Student";
            STudent.Click += CourseDetails_Click;
            // 
            // Email
            // 
            Email.Anchor = AnchorStyles.None;
            Email.AutoSize = true;
            Email.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.Location = new Point(296, 242);
            Email.Name = "Email";
            Email.Size = new Size(51, 19);
            Email.TabIndex = 7;
            Email.Text = "Email";
            // 
            // Name
            // 
            Name.Anchor = AnchorStyles.None;
            Name.AutoSize = true;
            Name.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name.Location = new Point(296, 200);
            Name.Name = "Name";
            Name.Size = new Size(53, 19);
            Name.TabIndex = 8;
            Name.Text = "Name";
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.AutoSize = true;
            Password.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.Location = new Point(296, 289);
            Password.Name = "Password";
            Password.Size = new Size(86, 19);
            Password.TabIndex = 7;
            Password.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(406, 289);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 9;
            // 
            // AddStudent
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
            Controls.Add(STudent);
            Controls.Add(Email);
            Controls.Add(Name);
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Clear;
        private Button Back;
        private Button Add;
        private TextBox CreditTextBox;
        private TextBox CrsNameTextBox;
        private Label STudent;
        private Label Email;
        private Label Name;
        private Label Password;
        private TextBox textBox1;
    }
}