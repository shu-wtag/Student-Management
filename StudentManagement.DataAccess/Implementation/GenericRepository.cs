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
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly ApplicationDbContext _context;
        private readonly Microsoft.EntityFrameworkCore.DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context )
        {
            _context = context;
            _dbSet = context.Set<T>();
        }


        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }
        //public async Task<T> FindAsync(int id)
        //{
        //    return await _context.Students.FindAsync(id);
        //}

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }


        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync(); 
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public Task<IEnumerable<T>> ToListasync()
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<T>> ExecuteStoredProcedureAsync(string storedProcedureName, params object[] parameters)
        //{
        //    return await _dbSet.FromSqlRaw($"EXEC {storedProcedureName}", parameters).ToListAsync();
        //}

        //public void FirstOrDefault(T entity)
        //{
        //    _context.Set<T>().FirstOrDefault(entity);
        //}
    }
}
