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
    public class EnrollmentRepository : GenericRepository<Enrollment> , IEnrollment
    {
        public EnrollmentRepository(ApplicationDbContext context) : base(context)
        {
            
        }
        public async Task<IEnumerable<Student>> GetAllStudentsWithEnrollmentsAsync()
        {
            var studentsWithEnrollments = await _context.Students
                .Include(s => s.Enrollments) // Include related enrollments
                .Select(static s => new Student
                {
                    ID = s.ID,
                    Name = s.Name,
                    Email = s.Email,
                    Enrollments = s.Enrollments.Select(e => new Enrollment
                    {
                        Enroll_date = e.Enroll_date,
                        CourseId = e.CourseId,
                        StudentId = e.StudentId
                    }).ToList()
                })
                .ToListAsync();

            return studentsWithEnrollments;
        }
    }
}
