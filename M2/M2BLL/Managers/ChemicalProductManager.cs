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
    public class ChemicalProductManager : BaseManager
    {

        public ChemicalProductManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }

        public IEnumerable<ChemicalProductDTO> GetAll()
        {
            return _entityManager.GetAll<ChemicalProduct, ChemicalProductDTO>();
        }
        public IEnumerable<ChemicalProductDTO> GetAllIncluding()
        {
            return _entityManager.GetAll<ChemicalProduct, ChemicalProductDTO>(x => x.Operation);
        }

        public async Task<ChemicalProductDTO> Get(string id)
        {
            return await _entityManager.Get<ChemicalProduct, ChemicalProductDTO>(id);
        }
        public async Task<ChemicalProductDTO> GetIncluding(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            return await _entityManager.Get<ChemicalProduct, ChemicalProductDTO>(x => x.Id == id, cancellationToken, x => x.Operation);
        }

        public void Create(ChemicalProductDTO item)
        {
            item.Id = Guid.NewGuid().ToString();
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<ChemicalProduct>().CreateAsync(_mapper.Map<ChemicalProduct>(item));
        }

        public void Delete(string id)
        {
            _unitOfWork.EFRepository<ChemicalProduct>().Delete(id);
        }

        public void Update(ChemicalProductDTO item)
        {
            item.TimeStamps = DateTime.Now;
            _unitOfWork.EFRepository<ChemicalProduct>().Update(_mapper.Map<ChemicalProduct>(item));
        }

    }
}
