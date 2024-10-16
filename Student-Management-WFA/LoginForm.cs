 using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_WFA
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void ClearTextBoxes()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox? txt = ctr as TextBox;
                    txt.Clear();
                }
            }
            UserNameTextBox.Clear();
        }

        //private async void SignIn_Click(object sender, EventArgs e)
        //{
        //    string username = UserNameTextBox.Text;
        //    string password = PasswordTextbox.Text;

        //    var client = new HttpClient();
        //    var loginData = new
        //    {
        //        Username = username,
        //        Password = password
        //    };

        //    var json = JsonConvert.SerializeObject(loginData);
        //    var content = new StringContent(json, Encoding.UTF8, "application/json");

        //    try
        //    {
        //        HttpResponseMessage response = await client.PostAsync("https://localhost:7271/api/account/login", content);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var jwtToken = await response.Content.ReadAsStringAsync();
        //            MessageBox.Show("You have successfully signed in.");
        //            ClearTextBoxes();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Login failed: " + response.ReasonPhrase);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //}
        private async void SignIn_Click(object sender, EventArgs e)
        {
            string username = UserNameTextBox.Text;
            string password = PasswordTextbox.Text;

            var client = new HttpClient();
            var loginData = new
            {
                Username = username,
                Password = password
            };

            var json = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("https://localhost:7271/api/account/login", content);
                if (response.IsSuccessStatusCode)
                {
                    ///Token
                    var jwtToken = await response.Content.ReadAsStringAsync();
                    var tokenObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(jwtToken);
                    string token = tokenObject["token"];

                    StoreToken(token);
                    MessageBox.Show("You have successfully signed in.");
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Login failed: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void StoreToken(string token)
        {
            Properties.Settings.Default.AuthToken = token; 
            Properties.Settings.Default.Save(); 
            MessageBox.Show("Token stored: " + token);

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated())
            {
                MessageBox.Show("You must be logged in to access this feature.");
                return;
            }

            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7271/api/Student");
                string token = Properties.Settings.Default.AuthToken;

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                try
                {
                    HttpResponseMessage response = await _httpClient.GetAsync("");
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        var students = await response.Content.ReadAsAsync<IEnumerable<Student>>();
                        var filteredStudents = students.Select(s => new { s.ID, s.Name, s.Email });
                        StudentsDataGridView.DataSource = filteredStudents.ToList();
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
        }


        private bool IsUserAuthenticated()
        {
            var token = Properties.Settings.Default.AuthToken;
            MessageBox.Show("Token stored: " + token);
            return !string.IsNullOrEmpty(token);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
                Properties.Settings.Default.AuthToken = string.Empty; 
                Properties.Settings.Default.Save(); 
                MessageBox.Show("You have successfully logged out.");
 
        }
    }
}
