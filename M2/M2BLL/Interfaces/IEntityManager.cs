using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M2BLL.Interfaces
{
    public interface IEntityManager
    {
        void Create<E, D>(D item) where E : class where D : class;
        void Update<E, D>(D item) where E : class where D : class;
        void Delete<E>(string id) where E : class;
        IEnumerable<D> GetAll<E, D>() where E : class where D : class;
        IEnumerable<D> GetAll<E, D>(params Expression<Func<E, object>>[] includeProperties) where E : class where D : class;
        Task<D> Get<E, D>(string id) where E : class where D : class;
        Task<D> Get<E, D>(Expression<Func<E, bool>> predicate, CancellationToken cancellationToken, params Expression<Func<E, object>>[] includeProperties) where E : class where D : class;
        IEnumerable<D> Find<E, D>(Func<E, Boolean> predicate) where E : class where D : class;
        IEnumerable<D> Find<E, D>(Func<E, Boolean> predicate, params Expression<Func<E, object>>[] includeProperties) where E : class where D : class;
    }
}
