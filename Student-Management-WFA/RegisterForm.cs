using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_WFA
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox txt = ctr as TextBox;
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
            var registerDto = new
            {
                username = username,
                emailAddress = email,
                password = password
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7271/");
                var json = JsonConvert.SerializeObject(registerDto); // Use Newtonsoft.Json
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

    }
}
