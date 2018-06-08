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
    public class LineManager : BaseManager
    {
        public LineManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }

        public IEnumerable<LineDTO> GetAll()
        {
            return _entityManager.GetAll<Line, LineDTO>();
        }
        public IEnumerable<LineDTO> GetAllIncluding()
        {
            return _entityManager.GetAll<Line, LineDTO>(x => x.Area, c=>c.Manufacturer, v=>v.Machines);
        }

        public async Task<LineDTO> Get(string id)
        {
            return await _entityManager.Get<Line, LineDTO>(id);
        }
        public async Task<LineDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get<Line, LineDTO>(x => x.Id == id, cancellationToken, x => x.Area, c => c.Manufacturer, v => v.Machines);
        }

        public void Create(LineDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Line>().CreateAsync(_mapper.Map<Line>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository<Line>().Delete(id);
        }

        public void Update(LineDTO item)
        {
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<Line>().Update(_mapper.Map<Line>(item));
        }



    }
}
