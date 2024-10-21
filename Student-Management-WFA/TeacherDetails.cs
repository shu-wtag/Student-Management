using StudentManagement.Domain.Entities;
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
    public partial class TeacherDetails : Form
    {
        public TeacherDetails()
        {
            InitializeComponent();
        }

        private async void AllTeachers_Click(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated())
            {
                MessageBox.Show("You must be logged in to access this feature.");
                return;
            }

            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7271/api/Teacher");
                string token = Properties.Settings.Default.AuthToken;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                try
                {
                    HttpResponseMessage response = await _httpClient.GetAsync("");
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        var teachers = await response.Content.ReadAsAsync<IEnumerable<Teacher>>();
                        var filteredTeachers = teachers.Select(t => new { t.ID, t.Name, t.Email });
                        TeacherView.DataSource = filteredTeachers.ToList();
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

        private async void Edit_Click(object sender, EventArgs e)
        {
            if (!IsUserAuthenticated())
            {
                MessageBox.Show("You must be logged in to access this feature.");
                return;
            }

            if (TeacherView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No item is selected.");
                return;
            }

            var selectedRow = TeacherView.SelectedRows[0];
            var teacherId = (int)selectedRow.Cells["ID"].Value;
            var teacherName = nameTextBox.Text;
            var teacherEmail = emailTextBox.Text;

            var updatedTeacher = new Teacher
            {
                ID = teacherId,
                Name = teacherName,
                Email = teacherEmail
            };

            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7271/api/Teacher/");
                string token = Properties.Settings.Default.AuthToken;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                try
                {
                    var response = await _httpClient.PutAsJsonAsync(teacherId.ToString(), updatedTeacher);
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show("Teacher updated successfully!");
                    await LoadTeachers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
        }
        private async Task LoadTeachers()
        {
            if (!IsUserAuthenticated())
            {
                MessageBox.Show("You must be logged in to access this feature.");
                return;
            }
            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new Uri("https://localhost:7271/api/Teacher");
                string token = Properties.Settings.Default.AuthToken;
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                try
                {
                    HttpResponseMessage response = await _httpClient.GetAsync("");
                    response.EnsureSuccessStatusCode();

                    var teachers = await response.Content.ReadAsAsync<IEnumerable<Student>>();

                    var filteredStudents = teachers.Select(s => new
                    {
                        s.ID,
                        s.Name,
                        s.Email
                    });
                    TeacherView.DataSource = filteredStudents.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
        }

        private void TeacherView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = TeacherView.Rows[e.RowIndex];
                nameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                emailTextBox.Text = selectedRow.Cells["Email"].Value.ToString();
            }
        }
    }
}
