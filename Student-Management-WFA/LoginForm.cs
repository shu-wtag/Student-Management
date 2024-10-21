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
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
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

        private void LogOut_Click(object sender, EventArgs e)
        {
                Properties.Settings.Default.AuthToken = string.Empty; 
                Properties.Settings.Default.Save(); 
                MessageBox.Show("You have successfully logged out.");
 
        }
    }
}
