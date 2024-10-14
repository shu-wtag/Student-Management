namespace Student_Management_WFA;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        NameTextBox = new TextBox();
        EmailTextBox = new TextBox();
        Add = new Button();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(306, 39);
        label1.Name = "label1";
        label1.Size = new Size(116, 32);
        label1.TabIndex = 0;
        label1.Text = "Student";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.Location = new Point(254, 116);
        label2.Name = "label2";
        label2.Size = new Size(56, 21);
        label2.TabIndex = 1;
        label2.Text = "Name";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.Location = new Point(257, 171);
        label3.Name = "label3";
        label3.Size = new Size(53, 21);
        label3.TabIndex = 2;
        label3.Text = "Email";
        // 
        // NameTextBox
        // 
        NameTextBox.Location = new Point(367, 118);
        NameTextBox.Name = "NameTextBox";
        NameTextBox.Size = new Size(123, 23);
        NameTextBox.TabIndex = 3;
        // 
        // EmailTextBox
        // 
        EmailTextBox.Location = new Point(367, 169);
        EmailTextBox.Name = "EmailTextBox";
        EmailTextBox.Size = new Size(123, 23);
        EmailTextBox.TabIndex = 4;
        // 
        // Add
        // 
        Add.BackColor = SystemColors.ActiveCaption;
        Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        Add.Location = new Point(257, 236);
        Add.Name = "Add";
        Add.Size = new Size(75, 41);
        Add.TabIndex = 5;
        Add.Text = "Add";
        Add.UseVisualStyleBackColor = false;
        Add.Click += Add_Click;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(388, 236);
        button1.Name = "button1";
        button1.Size = new Size(137, 35);
        button1.TabIndex = 6;
        button1.Text = "All Students";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(Add);
        Controls.Add(EmailTextBox);
        Controls.Add(NameTextBox);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox NameTextBox;
    private TextBox EmailTextBox;
    private Button Add;
    private Button button1;
}
