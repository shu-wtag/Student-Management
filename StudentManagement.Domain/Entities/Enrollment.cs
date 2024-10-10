using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Entities
{
    public class Enrollment
    {
        public string Enroll_date { get; set; } = string.Empty;
        public int? StudentId { get; set; }
        public int? CourseId { get; set; }
        public Student? Student { get; set; }
        public Course? Course { get; set; }

    }
}
