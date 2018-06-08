using AutoMapper;
using M2BLL.DataTransferObjects;
using M2BLL.Interfaces;
using M2DAL.Entities;
using M2DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace M2BLL.Managers
{
    public class AccountManager : BaseManager
    {
        public AccountManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }

        public async Task<SignInResult> SignInAsync(LoginDTO loginDTO)
        {
            return await _unitOfWork.SignInManager.PasswordSignInAsync(loginDTO.Email, loginDTO.Password, loginDTO.RememberMe, false);
        }

        //public Task<SignInResult> AuthenticateAsync(UserDTO userDto)
        //{
        //    throw new NotImplementedException();
        //}

        public void SignOutAsync()
        {
            _unitOfWork.SignInManager.SignOutAsync();
        }


    }
}
