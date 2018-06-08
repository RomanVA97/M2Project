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
    public class AreaManager : BaseManager
    {
        public AreaManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }

        public IEnumerable<AreaDTO> GetAll()
        {
            return _entityManager.GetAll<Area, AreaDTO>();
        }
        public IEnumerable<AreaDTO> GetAllIncluding()
        {
            return _entityManager.GetAll<Area, AreaDTO>(x => x.Lines);
        }

        public async Task<AreaDTO> Get(string id)
        {
            return await _entityManager.Get<Area, AreaDTO>(id);
        }
        public async Task<AreaDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get<Area, AreaDTO>(x => x.Id == id, cancellationToken, x => x.Lines);
        }

        public void Create(AreaDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Area>().CreateAsync(_mapper.Map<Area>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository<Area>().Delete(id);
        }

        public void Update(AreaDTO item)
        {
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Area>().Update(_mapper.Map<Area>(item));
        }







    }
}
