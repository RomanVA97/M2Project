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
    class ManufacturerManager : BaseManager
    {
        public ManufacturerManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }


        public IEnumerable<ManufacturerDTO> GetAll()
        {
            return _entityManager.GetAll<Manufacturer, ManufacturerDTO>();
        }
        public IEnumerable<ManufacturerDTO> GetAllIncluding()
        {
            return _entityManager.GetAll<Manufacturer, ManufacturerDTO>(x => x.Lines);
        }

        public async Task<ManufacturerDTO> Get(string id)
        {
            return await _entityManager.Get<Manufacturer, ManufacturerDTO>(id);
        }
        public async Task<ManufacturerDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get<Manufacturer, ManufacturerDTO>(x => x.Id == id, cancellationToken, x => x.Lines);
        }

        public void Create(ManufacturerDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Manufacturer>().CreateAsync(_mapper.Map<Manufacturer>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository<Manufacturer>().Delete(id);
        }

        public void Update(ManufacturerDTO item)
        {
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Manufacturer>().Update(_mapper.Map<Manufacturer>(item));
        }
    }
}
