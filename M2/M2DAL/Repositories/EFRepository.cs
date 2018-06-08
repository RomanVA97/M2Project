using M2DAL.EF;
using M2DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M2DAL.Repositories
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private readonly DataContext _dbContext;

        public EFRepository(DataContext appContext) => _dbContext = appContext;

        public void CreateAsync(T item)
        {
            _dbContext.Set<T>().AddAsync(item);
            _dbContext.SaveChanges();
        }

        public void Delete(string id)
        {
            _dbContext.Set<T>().Remove(_dbContext.Set<T>().Find(id));
            _dbContext.SaveChanges();
        }

        public void Update(T item)
        {
            _dbContext.Set<T>().Update(item);
            _dbContext.SaveChanges();
        }

        public IAsyncEnumerable<T> FindAsync(Func<T, bool> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).ToAsyncEnumerable();
        }
        public IAsyncEnumerable<T> FindAsync(Func<T, bool> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _dbContext.Set<T>().AsQueryable();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.Where(predicate).ToAsyncEnumerable();
        }

        public Task<T> GetAsync(string id)
        {
            return _dbContext.Set<T>().FindAsync(id);
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken, params Expression<Func<T, object>>[] includeProperties)
        {
            var query = _dbContext.Set<T>().AsQueryable();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.FirstOrDefaultAsync(predicate, cancellationToken);
        }

        public IAsyncEnumerable<T> GetAllAsync()
        {
            return _dbContext.Set<T>().ToAsyncEnumerable();
        }

        public IAsyncEnumerable<T> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            foreach (Expression<Func<T, object>> includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.ToAsyncEnumerable();
        }
 
    }
}
