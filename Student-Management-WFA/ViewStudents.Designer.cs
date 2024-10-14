namespace Student_Management_WFA
{
    partial class ViewStudents
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
            StudentsDataGridView = new DataGridView();
            button1 = new Button();
            Edit = new Button();
            Delete = new Button();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // StudentsDataGridView
            // 
            StudentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentsDataGridView.Location = new Point(0, 96);
            StudentsDataGridView.Name = "StudentsDataGridView";
            StudentsDataGridView.Size = new Size(801, 355);
            StudentsDataGridView.TabIndex = 0;
            StudentsDataGridView.CellMouseClick += StudentsDataGridView_CellMouseClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(147, 31);
            button1.TabIndex = 1;
            button1.Text = "GetAlldata";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Edit
            // 
            Edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit.Location = new Point(483, 12);
            Edit.Name = "Edit";
            Edit.Size = new Size(98, 31);
            Edit.TabIndex = 2;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete.Location = new Point(483, 49);
            Delete.Name = "Delete";
            Delete.Size = new Size(98, 31);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(258, 16);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(193, 23);
            nameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(258, 57);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(193, 23);
            emailTextBox.TabIndex = 4;
            // 
            // Refresh
            // 
            Refresh.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Refresh.Location = new Point(12, 49);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(147, 32);
            Refresh.TabIndex = 5;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // ViewStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Refresh);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(button1);
            Controls.Add(StudentsDataGridView);
            Name = "ViewStudents";
            Text = "ViewStudents";
            ((System.ComponentModel.ISupportInitialize)StudentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentsDataGridView;
        private Button button1;
        private Button Edit;
        private Button Delete;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private Button Refresh;
    }
}