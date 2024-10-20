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

    public class StudentRepository : GenericRepository<Student>, IStudent
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetStudentsWithEnrollments()
        {
            var studentWithEnrollments = await _context.Students.Include(u => u.Enrollments).ToListAsync();
            return studentWithEnrollments;
        }
        public async Task<List<Student>> GetAllStudents()
        {
            return await _context.Students
                                 .FromSqlRaw("EXEC GetAllStudents")
                                 .ToListAsync();
        }


    }
}
