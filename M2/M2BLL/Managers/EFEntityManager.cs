using M2BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using M2DAL;
using M2DAL.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace M2BLL.Managers
{
    public class EFEntityManager : BaseManager, IEntityManager
    {
        public EFEntityManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }

        public void Create<E, D>(D item) where E : class where D : class
        {
            _unitOfWork.EFRepository<E>().CreateAsync(_mapper.Map<E>(item));
        }

        public void Delete<E>(string id) where E : class
        {
            _unitOfWork.EFRepository<E>().Delete(id);
        }

        public void Update<E, D>(D item) where E : class where D : class
        {
            _unitOfWork.EFRepository<E>().Update(_mapper.Map<E>(item));
        }

        public IEnumerable<D> Find<E, D>(Func<E, bool> predicate) where E : class where D : class
        {
            return _mapper.Map<IEnumerable<D>>(_unitOfWork.EFRepository<E>().FindAsync(predicate));
        }

        public IEnumerable<D> Find<E, D>(Func<E, bool> predicate, params Expression<Func<E, object>>[] includeProperties) where E : class where D : class
        {
            var query = _unitOfWork.EFRepository<E>().FindAsync(predicate, includeProperties);
            return _mapper.Map<IEnumerable<D>>(query);
        }

        public async Task<D> Get<E, D>(string id) where E : class where D : class
        {
            var query = await _unitOfWork.EFRepository<E>().GetAsync(id);
            return _mapper.Map<D>(query);
        }

        public async Task<D> Get<E, D>(Expression<Func<E, bool>> predicate, CancellationToken cancellationToken, params Expression<Func<E, object>>[] includeProperties) where E : class where D : class
        {
            var query = await _unitOfWork.EFRepository<E>().GetAsync(predicate, cancellationToken, includeProperties);
            return _mapper.Map<D>(query);
        }

        public IEnumerable<D> GetAll<E, D>() where E : class where D : class
        {
            return _mapper.Map<IEnumerable<D>>(_unitOfWork.EFRepository<E>().GetAllAsync().ToEnumerable());
        }

        public IEnumerable<D> GetAll<E, D>(params Expression<Func<E, object>>[] includeProperties) where E : class where D : class
        {
            var query = _unitOfWork.EFRepository<E>().GetAllAsync(includeProperties);
            return _mapper.Map<IEnumerable<D>>(query.ToEnumerable());
        }


    }
}
