using AutoMapper;
using M2BLL.Interfaces;
using M2DAL.Implements;
using M2DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace M2BLL.Managers
{
    public class BaseManager
    {
        protected readonly IEntityManager _entityManager;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public BaseManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _entityManager = entityManager;
        }

    }
}
