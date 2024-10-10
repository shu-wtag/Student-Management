using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Entities
{
    public class CourseTeach
    {
        public int Id { get; set; }
        public Course? courseID { get; set; }
        public Teacher? teach_ID { get; set; }
    }
}
