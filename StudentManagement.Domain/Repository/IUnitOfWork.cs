using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IStudent Student { get; }
        ICourse Course { get; }
        ICourseTeach CourseTeach { get; }
        ITeacher Teacher { get; }
        IEnrollment Enrollment { get; }
        int Save();
        public Task<int> SaveAsync();
    }
}
