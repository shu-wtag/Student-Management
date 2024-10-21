namespace Student_Management_WFA
{
    partial class TeacherDetails
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
            TeacherView = new DataGridView();
            AllTeachers = new Button();
            emailTextBox = new TextBox();
            nameTextBox = new TextBox();
            Delete = new Button();
            Edit = new Button();
            ((System.ComponentModel.ISupportInitialize)TeacherView).BeginInit();
            SuspendLayout();
            // 
            // TeacherView
            // 
            TeacherView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherView.Location = new Point(127, 115);
            TeacherView.Name = "TeacherView";
            TeacherView.Size = new Size(423, 255);
            TeacherView.TabIndex = 0;
            TeacherView.CellMouseClick += TeacherView_CellMouseClick;
            // 
            // AllTeachers
            // 
            AllTeachers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AllTeachers.Location = new Point(34, 24);
            AllTeachers.Name = "AllTeachers";
            AllTeachers.Size = new Size(102, 56);
            AllTeachers.TabIndex = 1;
            AllTeachers.Text = "All Teachers";
            AllTeachers.UseVisualStyleBackColor = true;
            AllTeachers.Click += AllTeachers_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Location = new Point(237, 57);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(193, 23);
            emailTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.None;
            nameTextBox.Location = new Point(237, 16);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(193, 23);
            nameTextBox.TabIndex = 8;
            // 
            // Delete
            // 
            Delete.Anchor = AnchorStyles.None;
            Delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(462, 49);
            Delete.Name = "Delete";
            Delete.Size = new Size(98, 31);
            Delete.TabIndex = 6;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            Edit.Anchor = AnchorStyles.None;
            Edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.Location = new Point(462, 12);
            Edit.Name = "Edit";
            Edit.Size = new Size(98, 31);
            Edit.TabIndex = 5;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // TeacherDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(AllTeachers);
            Controls.Add(TeacherView);
            Name = "TeacherDetails";
            Text = "TeacherDetails";
            ((System.ComponentModel.ISupportInitialize)TeacherView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView TeacherView;
        private Button AllTeachers;
        private TextBox emailTextBox;
        private TextBox nameTextBox;
        private Button Delete;
        private Button Edit;
    }
}