namespace Student_Management_WFA
{
    partial class CourseForm
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
            CourseName = new Label();
            Credit = new Label();
            CourseDetails = new Label();
            CrsNameTextBox = new TextBox();
            CreditTextBox = new TextBox();
            Add = new Button();
            Edit = new Button();
            Update = new Button();
            Clear = new Button();
            SuspendLayout();
            // 
            // CourseName
            // 
            CourseName.AutoSize = true;
            CourseName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseName.Location = new Point(182, 103);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(113, 19);
            CourseName.TabIndex = 0;
            CourseName.Text = "Course Name";
            // 
            // Credit
            // 
            Credit.AutoSize = true;
            Credit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Credit.Location = new Point(240, 145);
            Credit.Name = "Credit";
            Credit.Size = new Size(55, 19);
            Credit.TabIndex = 0;
            Credit.Text = "Credit";
            // 
            // CourseDetails
            // 
            CourseDetails.AutoSize = true;
            CourseDetails.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseDetails.Location = new Point(268, 28);
            CourseDetails.Name = "CourseDetails";
            CourseDetails.Size = new Size(207, 32);
            CourseDetails.TabIndex = 1;
            CourseDetails.Text = "Course Details";
            // 
            // CrsNameTextBox
            // 
            CrsNameTextBox.Location = new Point(339, 103);
            CrsNameTextBox.Name = "CrsNameTextBox";
            CrsNameTextBox.Size = new Size(146, 23);
            CrsNameTextBox.TabIndex = 0;
            // 
            // CreditTextBox
            // 
            CreditTextBox.Location = new Point(339, 145);
            CreditTextBox.Name = "CreditTextBox";
            CreditTextBox.Size = new Size(146, 23);
            CreditTextBox.TabIndex = 1;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.ActiveCaption;
            Add.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(182, 190);
            Add.Name = "Add";
            Add.Size = new Size(75, 27);
            Add.TabIndex = 2;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Edit
            // 
            Edit.BackColor = SystemColors.ActiveCaption;
            Edit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.Location = new Point(279, 190);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 27);
            Edit.TabIndex = 3;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            Update.BackColor = SystemColors.ActiveCaption;
            Update.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.Location = new Point(374, 190);
            Update.Name = "Update";
            Update.Size = new Size(75, 27);
            Update.TabIndex = 4;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            // 
            // Clear
            // 
            Clear.BackColor = SystemColors.ActiveCaption;
            Clear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.Location = new Point(471, 190);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 27);
            Clear.TabIndex = 5;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Clear);
            Controls.Add(Update);
            Controls.Add(Edit);
            Controls.Add(Add);
            Controls.Add(CreditTextBox);
            Controls.Add(CrsNameTextBox);
            Controls.Add(CourseDetails);
            Controls.Add(Credit);
            Controls.Add(CourseName);
            Name = "CourseForm";
            Text = "CourseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CourseName;
        private Label Credit;
        private Label CourseDetails;
        private TextBox CrsNameTextBox;
        private TextBox CreditTextBox;
        private Button Add;
        private Button Edit;
        private Button Update;
        private Button Clear;
    }
}