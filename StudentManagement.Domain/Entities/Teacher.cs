using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Entities
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        //One to Many
        public List<CourseTeach>? CourseTeaches { get; set; }

        //Many to Many
        public List<Course>? courses { get; set; }
    }
}
