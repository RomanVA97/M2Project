using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace M2DAL.Interfaces
{
    public interface IRepository<T> where T:class
    {
        IAsyncEnumerable<T> GetAllAsync();
        IAsyncEnumerable<T> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(string id);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken, params Expression<Func<T, object>>[] includeProperties);
        IAsyncEnumerable<T> FindAsync(Func<T, Boolean> predicate);
        IAsyncEnumerable<T> FindAsync(Func<T, Boolean> predicate, params Expression<Func<T, object>>[] includeProperties);
        void CreateAsync(T item);
        void Update(T item);
        void Delete(string id);



    }
}
