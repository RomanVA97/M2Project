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
    public class MachineManager : BaseManager
    {
        public MachineManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }



        public IEnumerable<MachineDTO> GetAll()
        {
            return _entityManager.GetAll<Machine, MachineDTO>();
        }
        public IEnumerable< MachineDTO> GetAllIncluding()
        {
            return _entityManager.GetAll< Machine,  MachineDTO>(x => x.Line, c => c.Components);
        }

        public async Task< MachineDTO> Get(string id)
        {
            return await _entityManager.Get< Machine,  MachineDTO>(id);
        }
        public async Task< MachineDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get< Machine,  MachineDTO>(x => x.Id == id, cancellationToken, x => x.Line, c => c.Components);
        }

        public void Create( MachineDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository< Machine>().CreateAsync(_mapper.Map< Machine>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository< Machine>().Delete(id);
        }

        public void Update( MachineDTO item)
        {
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository< Machine>().Update(_mapper.Map< Machine>(item));
        }
    }
}
