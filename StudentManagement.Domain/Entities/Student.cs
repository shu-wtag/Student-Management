using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        //many to many
        public List<Course>? Courses { get; set; }

        //One to Many
        public List<Enrollment>? Enrollments { get; set; }
    }
}
