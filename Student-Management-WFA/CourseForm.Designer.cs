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
            Clear = new Button();
            Back = new Button();
            SuspendLayout();
            // 
            // CourseName
            // 
            CourseName.Anchor = AnchorStyles.None;
            CourseName.AutoSize = true;
            CourseName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseName.Location = new Point(204, 171);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(113, 19);
            CourseName.TabIndex = 0;
            CourseName.Text = "Course Name";
            // 
            // Credit
            // 
            Credit.Anchor = AnchorStyles.None;
            Credit.AutoSize = true;
            Credit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Credit.Location = new Point(262, 213);
            Credit.Name = "Credit";
            Credit.Size = new Size(55, 19);
            Credit.TabIndex = 0;
            Credit.Text = "Credit";
            // 
            // CourseDetails
            // 
            CourseDetails.Anchor = AnchorStyles.None;
            CourseDetails.AutoSize = true;
            CourseDetails.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseDetails.Location = new Point(285, 98);
            CourseDetails.Name = "CourseDetails";
            CourseDetails.Size = new Size(170, 32);
            CourseDetails.TabIndex = 1;
            CourseDetails.Text = "Add Course";
            CourseDetails.Click += CourseDetails_Click;
            // 
            // CrsNameTextBox
            // 
            CrsNameTextBox.Anchor = AnchorStyles.None;
            CrsNameTextBox.Location = new Point(361, 171);
            CrsNameTextBox.Name = "CrsNameTextBox";
            CrsNameTextBox.Size = new Size(146, 23);
            CrsNameTextBox.TabIndex = 0;
            // 
            // CreditTextBox
            // 
            CreditTextBox.Anchor = AnchorStyles.None;
            CreditTextBox.Location = new Point(361, 213);
            CreditTextBox.Name = "CreditTextBox";
            CreditTextBox.Size = new Size(146, 23);
            CreditTextBox.TabIndex = 1;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.None;
            Add.BackColor = SystemColors.ActiveCaption;
            Add.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.Location = new Point(342, 270);
            Add.Name = "Add";
            Add.Size = new Size(75, 27);
            Add.TabIndex = 2;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Clear
            // 
            Clear.Anchor = AnchorStyles.None;
            Clear.BackColor = SystemColors.ActiveCaption;
            Clear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.Location = new Point(432, 270);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 27);
            Clear.TabIndex = 5;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Back
            // 
            Back.BackColor = SystemColors.ActiveCaption;
            Back.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Back.Location = new Point(242, 267);
            Back.Name = "Back";
            Back.Size = new Size(75, 30);
            Back.TabIndex = 6;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Back);
            Controls.Add(Clear);
            Controls.Add(Add);
            Controls.Add(CreditTextBox);
            Controls.Add(CrsNameTextBox);
            Controls.Add(CourseDetails);
            Controls.Add(Credit);
            Controls.Add(CourseName);
            Name = "CourseForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button Clear;
        private Button Back;
    }
}