using System;
using System.Linq.Expressions;
using Aluraflix.Context;
using Microsoft.EntityFrameworkCore;

namespace Aluraflix.Repository
{
	public class Repository<T> : IRepository<T> where T : class
	{
        private readonly AppDbContext _context;

		public Repository(AppDbContext context)
		{
            _context = context;
		}

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetById(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(predicate);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<T>().Update(entity);
        }
    }
}

