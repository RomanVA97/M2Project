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
    class OperationManager : BaseManager
    {
        public OperationManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }


        public IEnumerable<OperationDTO> GetAll()
        {
            return _entityManager.GetAll<Operation, OperationDTO>();
        }
        public IEnumerable<OperationDTO> GetAllIncluding()
        {
            return _entityManager.GetAll<Operation, OperationDTO>(x => x.Maintenance, c => c.Component, l=>l.Creator, w => w.Worker, q => q.ChemicalProducts, e => e.Location, r => r.Alerts);
        }

        public async Task<OperationDTO> Get(string id)
        {
            return await _entityManager.Get<Operation, OperationDTO>(id);
        }
        public async Task<OperationDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get<Operation, OperationDTO>(x => x.Id == id, cancellationToken, x => x.Maintenance, c => c.Component, l => l.Creator, w => w.Worker, q => q.ChemicalProducts, e => e.Location, r => r.Alerts);
        }

        public void Create(OperationDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Operation>().CreateAsync(_mapper.Map<Operation>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository<Operation>().Delete(id);
        }

        public void Update(OperationDTO item)
        {
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Operation>().Update(_mapper.Map<Operation>(item));
        }
    }
}
