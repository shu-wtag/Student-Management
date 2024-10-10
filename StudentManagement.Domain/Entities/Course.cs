using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public string Course_Name { get; set; } = string.Empty;
        public int credits { get; set; }

        //Many to Many
        public List<Student>? Students { get; set; }

        //Many to Many
        public List<Teacher>? Teachers { get; set; }

        //One to Many
        public List<Enrollment>? Enrollments { get; set; }

        //One to Many
        public List<CourseTeach>? CourseTeaches { get; set; }
    }
}
