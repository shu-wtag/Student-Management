using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Student_Management_WFA
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Simplified email pattern
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        private void ClearTextBoxes()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox txt)
                {
                    txt.Clear();
                }
            }
            UserNameTextBox.Clear();
        }

        private async void SignUp_Click(object sender, EventArgs e)
        {
            // Retrieve input values
            string username = UserNameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            // Create the registration data object
            var registerDto = new { username, emailAddress = email, password };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7271/");
                var json = JsonConvert.SerializeObject(registerDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    // Make the POST request
                    var response = await client.PostAsync("api/account/register", content);
                    if (response.IsSuccessStatusCode)
                    {
                        // Registration successful
                        MessageBox.Show("You have successfully registered");
                        ClearTextBoxes();
                    }
                    else
                    {
                        // Handle errors
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Registration failed: {errorMessage}");
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void EmailTextBox_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(EmailTextBox.Text, pattern))
            {
                EmailTextBox.Focus();
                errorProvider1.SetError(EmailTextBox, "Invalid Email");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
