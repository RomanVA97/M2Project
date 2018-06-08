using AutoMapper;
using M2BLL.DataTransferObjects;
using M2BLL.Interfaces;
using M2DAL.Interfaces;
using M2DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace M2BLL.Managers
{
    public class PlantManager : BaseManager
    {
        public PlantManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }

        public IEnumerable<PlantDTO> GetAll()
        {
            return _entityManager.GetAll<Plant, PlantDTO>();
        }
        public IEnumerable<PlantDTO> GetAllIncluding()
        {
            return _entityManager.GetAll<Plant, PlantDTO>(x => x.Areas);
        }
        
        public async Task<PlantDTO> Get(string id)
        {
            return await _entityManager.Get<Plant, PlantDTO>(id);
        }
        public async Task<PlantDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get<Plant, PlantDTO>(x=>x.Id == id,cancellationToken, x=>x.Areas);
        }

        public void Create(PlantDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Plant>().CreateAsync(_mapper.Map<Plant>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository<Plant>().Delete(id);
        }

        public void Update(PlantDTO item)
        {
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Plant>().Update(_mapper.Map<Plant>(item));
        }

    }
}
