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
    class MaintenanceManager : BaseManager
    {
        public MaintenanceManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }


        public IEnumerable<MaintenanceDTO> GetAll()
        {
            return _entityManager.GetAll<Maintenance, MaintenanceDTO>();
        }
        public IEnumerable<MaintenanceDTO> GetAllIncluding()
        {
            return _entityManager.GetAll<Maintenance, MaintenanceDTO>(x => x.Component, c => c.Operations, l => l.Location);
        }

        public async Task<MaintenanceDTO> Get(string id)
        {
            return await _entityManager.Get<Maintenance, MaintenanceDTO>(id);
        }
        public async Task<MaintenanceDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get<Maintenance, MaintenanceDTO>(x => x.Id == id, cancellationToken, x => x.Component, c => c.Operations, l => l.Location);
        }

        public void Create(MaintenanceDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            //item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Maintenance>().CreateAsync(_mapper.Map<Maintenance>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository<Maintenance>().Delete(id);
        }

        public void Update(MaintenanceDTO item)
        {
            //item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Maintenance>().Update(_mapper.Map<Maintenance>(item));
        }
    }
}
