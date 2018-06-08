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
    public class ComponentManager : BaseManager
    {
        public ComponentManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }


        public IEnumerable<ComponentDTO> GetAll()
        {
            return _entityManager.GetAll<Component, ComponentDTO>();
        }
        public IEnumerable<ComponentDTO> GetAllIncluding()
        {
            return _entityManager.GetAll<Component, ComponentDTO>(x => x.Machine, c=>c.Maintenance);
        }

        public async Task<ComponentDTO> Get(string id)
        {
            return await _entityManager.Get<Component, ComponentDTO>(id);
        }
        public async Task<ComponentDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get<Component, ComponentDTO>(x => x.Id == id, cancellationToken, x => x.Machine, c => c.Maintenance);
        }

        public void Create(ComponentDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Component>().CreateAsync(_mapper.Map<Component>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository<Component>().Delete(id);
        }

        public void Update(ComponentDTO item)
        {
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Component>().Update(_mapper.Map<Component>(item));
        }


    }
}
