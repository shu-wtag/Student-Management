using Azure;
using Newtonsoft.Json.Linq;
using StudentManagement.API.DTOs.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_WFA
{
    public partial class ViewStudents : Form
    {

        public ViewStudents()
        {
            InitializeComponent();

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
            return !string.IsNullOrEmpty(token);
        }

        //Update Data
        private async void Edit_Click(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated())
            {
                MessageBox.Show("You must be logged in to access this feature.");
                return;
            }
            // Check if a row is selected in the DataGridView
            if (StudentsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No item is selected.");
                return;
            }

            // Get the selected row
            var selectedRow = StudentsDataGridView.SelectedRows[0];
            var studentId = (int)selectedRow.Cells["ID"].Value;
            var studentName = nameTextBox.Text; 
            var studentEmail = emailTextBox.Text; 


            // Create the updated Student object
            var updatedStudent = new Student
            {
                ID = studentId,
                Name = studentName,
                Email = studentEmail
            };

            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7271/api/Student/ID");
                string token = Properties.Settings.Default.AuthToken;

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                try
                {
                    // Send a PUT request with the updated student data
                    var response = await _httpClient.PutAsJsonAsync(studentId.ToString(), updatedStudent);
                    response.EnsureSuccessStatusCode(); // Throws if the status code is not success

                    MessageBox.Show("Student updated successfully!");
                    await LoadStudents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
        }

        private void StudentsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                var selectedRow = StudentsDataGridView.Rows[e.RowIndex];

                // Assuming there are text boxes named nameTextBox and emailTextBox
                nameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                emailTextBox.Text = selectedRow.Cells["Email"].Value.ToString();
            }
        }



        //Delete a particular record
        private async void Delete_Click(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated())
            {
                MessageBox.Show("You must be logged in to access this feature.");
                return;
            }
            // Check if a row is selected in the DataGridView
            if (StudentsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No item is selected.");
                return;
            }

            var selectedRow = StudentsDataGridView.SelectedRows[0];
            var studentId = (int)selectedRow.Cells["ID"].Value;

            var confirmResult = MessageBox.Show(
                "Do you want to delete this information?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                using (HttpClient _httpClient = new HttpClient())
                {
                    _httpClient.BaseAddress = new Uri($"https://localhost:7271/api/Student/");
                    string token = Properties.Settings.Default.AuthToken;
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    try
                    {
                        
                        var response = await _httpClient.DeleteAsync(studentId.ToString());
                        response.EnsureSuccessStatusCode(); // Throws if the status code is not success

                        MessageBox.Show("Student deleted successfully!");

                        await LoadStudents();
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show($"Request error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                    }
                }
            }
        }


        private async Task LoadStudents()
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

                    var students = await response.Content.ReadAsAsync<IEnumerable<Student>>();

                    var filteredStudents = students.Select(s => new
                    {
                        s.ID,
                        s.Name,
                        s.Email
                    });

                    StudentsDataGridView.DataSource = filteredStudents.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }
    }
}
