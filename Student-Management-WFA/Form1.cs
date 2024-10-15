namespace Student_Management_WFA;

public partial class Form1 : Form
{
    public static string text1;
    public Form1()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private async void Add_Click(object sender, EventArgs e)
    {
        // Assuming you have text boxes named nameTextBox and emailTextBox
        string name = NameTextBox.Text;
        string email = EmailTextBox.Text;

        // Create a new Student object
        var newStudent = new Student
        {
            Name = name,
            Email = email
        };

        using (HttpClient _httpClient = new HttpClient())
        {
            _httpClient.BaseAddress = new Uri("https://localhost:7271/api/Student");

            try
            {
                // Send a POST request with the new student data
                var response = await _httpClient.PostAsJsonAsync("", newStudent);
                response.EnsureSuccessStatusCode(); // Throws if the status code is not success

                MessageBox.Show("Student added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        ViewStudents f2 = new();
        f2.Show();
    }

    private void SignUp_Click(object sender, EventArgs e)
    {
        RegisterForm registerForm = new();
        registerForm.Show();
    }

    private void Courses_Click(object sender, EventArgs e)
    {
        CourseForm courseform = new();
        courseform.Show();
    }

    private void SignIn_Click(object sender, EventArgs e)
    {
        LoginForm loginForm = new LoginForm();
        loginForm.Show();
    }
}
