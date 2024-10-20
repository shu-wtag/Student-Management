using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Domain.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll(); //IEnumerable will execute select query on server side, load data in-memory on client side and then filter data.

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void AddRange(IEnumerable<T> entitties);
        //void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        public Task<IEnumerable<T>> GetAllAsync();
        public Task<IEnumerable<T>> ToListasync();
        public Task RemoveAsync(T entity);
        public Task RemoveRangeAsync(IEnumerable<T> entities);
        public Task AddAsync(T entity);
        public Task<T?> GetByIdAsync(int id);
   



    }
}
