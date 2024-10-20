using Microsoft.EntityFrameworkCore;
using StudentManagement.DataAccess.Context;
using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccess.Implementation
{
    public class CourseRepository : GenericRepository<Course> , ICourse
    {
        public CourseRepository(ApplicationDbContext context) : base(context)
        {
            
        }
        
    }
}
