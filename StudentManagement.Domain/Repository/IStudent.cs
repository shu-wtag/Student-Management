using StudentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Repository
{
    public interface IStudent : IGenericRepository<Student>
    {
        public Task<List<Student>> GetAllStudents();
        public Task<IEnumerable<Student>> GetStudentsWithEnrollments();


    }
}
