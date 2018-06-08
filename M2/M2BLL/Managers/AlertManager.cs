using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using M2BLL.DataTransferObjects;
using M2BLL.Interfaces;
using M2DAL.Entities;
using M2DAL.Interfaces;

namespace M2BLL.Managers
{
    public class AlertManager : BaseManager
    {
        public AlertManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }

        public IEnumerable<AlertDTO> GetAll()
        {
            return _entityManager.GetAll<Alert, AlertDTO>();
        }
        public IEnumerable<AlertDTO> GetAllIncluding()
        {
            return _entityManager.GetAll<Alert, AlertDTO>(x => x.Creator , c => c.Operation);
        }

        public async Task<AlertDTO> Get(string id)
        {
            return await _entityManager.Get<Alert, AlertDTO>(id);
        }
        public async Task<AlertDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get<Alert, AlertDTO>(x => x.Id == id, cancellationToken, x => x.Creator, c => c.Operation);
        }

        public void Create(AlertDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Alert>().CreateAsync(_mapper.Map<Alert>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository<Alert>().Delete(id);
        }

        public void Update(AlertDTO item)
        {
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Alert>().Update(_mapper.Map<Alert>(item));
        }

    }
}
