using StudentManagement.DataAccess.Context;
using StudentManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Student = new StudentRepository(_context);
            Course = new CourseRepository(_context);
            CourseTeach = new CourseTeachRepository(_context);
            Teacher = new TeacherRepository(_context);
            Enrollment = new EnrollmentRepository(_context);
        }
        public ICourse Course { get; private set; }
        public IStudent Student { get; private set; }
        public ITeacher Teacher { get; private set; }
        public IEnrollment Enrollment { get; private set; }
        public ICourseTeach CourseTeach { get; private set; }
        public int Save ()
        {
            return _context.SaveChanges();
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
