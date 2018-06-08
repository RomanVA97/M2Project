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
    public class LocationManager : BaseManager
    {
        public LocationManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }

        public IEnumerable<LocationDTO> GetAll()
        {
            return _entityManager.GetAll<Location, LocationDTO>();
        }
        public IEnumerable<LocationDTO> GetAllIncluding()
        {
            return _entityManager.GetAll<Location, LocationDTO>(x => x.Maintenances, c=>c.Operations);
        }

        public async Task<LocationDTO> Get(string id)
        {
            return await _entityManager.Get<Location, LocationDTO>(id);
        }
        public async Task<LocationDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get<Location, LocationDTO>(x => x.Id == id, cancellationToken, x => x.Maintenances, c => c.Operations);
        }

        public void Create(LocationDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Location>().CreateAsync(_mapper.Map<Location>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository<Location>().Delete(id);
        }

        public void Update(LocationDTO item)
        {
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Location>().Update(_mapper.Map<Location>(item));
        }



    }
}
