using AutoMapper;
using M2BLL.Interfaces;
using M2DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace M2PL.Services
{
    public class BLLEntityService : BaseService, IEntityService
    {
        public BLLEntityService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public void Create<V, D>(D item)
            where V : class
            where D : class
        {
            throw new NotImplementedException();
        }

        public void Delete<V>(string id) where V : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<D> Find<V, D>(Func<V, bool> predicate)
            where V : class
            where D : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<D> Find<V, D>(Func<V, bool> predicate, params Expression<Func<V, object>>[] includeProperties)
            where V : class
            where D : class
        {
            throw new NotImplementedException();
        }

        public Task<D> Get<V, D>(string id)
            where V : class
            where D : class
        {
            throw new NotImplementedException();
        }

        public Task<D> Get<V, D>(Expression<Func<V, bool>> predicate, CancellationToken cancellationToken, params Expression<Func<V, object>>[] includeProperties)
            where V : class
            where D : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<D> GetAll<V, D>()
            where V : class
            where D : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<D> GetAll<V, D>(params Expression<Func<V, object>>[] includeProperties)
            where V : class
            where D : class
        {
            throw new NotImplementedException();
        }

        public void Update<V, D>(D item)
            where V : class
            where D : class
        {
            throw new NotImplementedException();
        }
    }
}
