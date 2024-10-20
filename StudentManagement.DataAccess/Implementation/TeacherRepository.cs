using Microsoft.EntityFrameworkCore;
using StudentManagement.DataAccess.Context;
using StudentManagement.Domain.Entities;
using StudentManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccess.Implementation
{
    public class TeacherRepository : GenericRepository<Teacher> , ITeacher
    {
        private readonly ApplicationDbContext _context;
        public TeacherRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        
       
    }
}
