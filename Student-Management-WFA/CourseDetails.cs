using StudentManagement.API.DTOs.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_WFA
{
    public partial class CourseDetails : Form
    {
        private readonly HttpClient _httpClient;
        public CourseDetails()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7271/api/") };
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is CourseDto selectedCourse)
            {
                MessageBox.Show($"Course ID: {selectedCourse.ID}\nCredits: {selectedCourse.Credits}\nName: {selectedCourse.Course_Name}");
            }
            else if (e.Node.Tag is int credits)
            {
               
                MessageBox.Show($"Credits: {credits}");
            }
        }

        private async void CourseDetails_Load(object sender, EventArgs e)
        {
            await LoadCoursesAsync();
        }
        private async Task LoadCoursesAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<CourseDto>>("Course");
                if (response != null)
                {
                    TreeView1(response);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading courses: {ex.Message}");
            }
        }
        private void TreeView1(IEnumerable<CourseDto> courses)
        {
            treeView1.Nodes.Clear(); // Clear existing nodes

            foreach (var course in courses)
            {
                var courseNode = new TreeNode(course.Course_Name)
                {
                    Tag = course 
                };
                var CreditsNode = new TreeNode($"Credits: {course.Credits}");
                {
                    Tag = course.Credits;
                };

                treeView1.Nodes.Add(CreditsNode);
                treeView1.Nodes.Add(courseNode);
            }
        }
    }
}