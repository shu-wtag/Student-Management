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
    public partial class CourseForm : Form
    {
        public CourseForm()
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
            CrsNameTextBox.Clear();
        }

        private async void Add_Click(object sender, EventArgs e)
        {
            //Input values
            string courseName = CrsNameTextBox.Text;
            string credit = CreditTextBox.Text;

            var courseDto = new
            {
                Credits = credit,
                Course_Name = courseName
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7271/");
                var json = JsonConvert.SerializeObject(courseDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                try
                {
                    var response = await client.PostAsync("api/Course", content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Course has successfully added");
                        ClearTextBoxes();
                    }
                    else
                    {
                        // Handle errors
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Failed: {errorMessage}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void CourseDetails_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Close();
        }

    }
}
