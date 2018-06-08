using AutoMapper;
using M2BLL.DataTransferObjects;
using M2BLL.Infrastructure;
using M2BLL.Interfaces;
using M2DAL.Entities;
using M2DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Collections;

namespace M2BLL.Managers
{
    public class UserManager : BaseManager, IUserManager
    {
        public UserManager(IUnitOfWork unitOfWork, IMapper mapper, IEntityManager entityManager) : base(unitOfWork, mapper, entityManager)
        {
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            return _mapper.Map<IEnumerable<UserDTO>>(_unitOfWork.UserManager.Users.ToList());
        }

        public async Task<UserDTO> GetUserByIdAsync(string id)
        {
            return _mapper.Map<UserDTO>(await _unitOfWork.UserManager.FindByIdAsync(id));
        }

        public async Task DeleteUserById(string id)
        {
            await _unitOfWork.UserManager.DeleteAsync(await _unitOfWork.UserManager.FindByIdAsync(id));
        }
        
        public async Task<OperationDetails> CreateAsync(UserDTO userDto)
        {
            ApplicationUser user = null;
            string str = "";
            try
            {
                user = await _unitOfWork.UserManager.FindByEmailAsync(userDto.Email);
            }
            catch(Exception e)
            {
                str = e.InnerException.Message;
            }

            if (user == null)
            {
                user = new ApplicationUser { Email = userDto.Email, UserName = userDto.Email };
                var result = await _unitOfWork.UserManager.CreateAsync(user, userDto.Password);
                if (result.Errors.Count() > 0)
                    return new OperationDetails(false, result.Errors.FirstOrDefault().Description, "");
                
                
                return new OperationDetails(true, "Регистрация успешно пройдена", "");
            }
            else
            {
                return new OperationDetails(false, "Пользователь с таким логином уже существует", "Email");
            }
        }

        public async Task<OperationDetails> UpdateAsync(UserDTO userDto, string id)
        {
            UserDTO user2 = new UserDTO();
            ApplicationUser user = null;
            string str = "";
            //user2 = _mapper.Map<UserDTO>(await _unitOfWork.UserManager.FindByIdAsync(id));
            try
            {
                user = await _unitOfWork.UserManager.FindByIdAsync(id);
            }
            catch (Exception e)
            {
                str = e.Message;
            }

            if (user != null)
            {
                ChangeUserProps(user, _mapper.Map<ApplicationUser>(userDto));
                await _unitOfWork.UserManager.UpdateAsync(user);
                
                //user = new ApplicationUser { Email = userDto.Email, UserName = userDto.Email };
                //var result = await _unitOfWork.UserManager.CreateAsync(user, userDto.Password);
                //if (result.Errors.Count() > 0)
                //    return new OperationDetails(false, result.Errors.FirstOrDefault().Description, "");
                return new OperationDetails(true, "Изменение прошло успешно", "");
            }
            else
            {
                return new OperationDetails(false, "Пользователь не найден", "Id");
            }
        }
        
        public async Task SetInitialDataAsync(UserDTO adminDto, List<string> roles)
        {
            foreach (string roleName in roles)
            {
                var role = await _unitOfWork.RoleManager.FindByNameAsync(roleName);
                if (role == null)
                {
                    role = new ApplicationRole { Name = roleName };
                    await _unitOfWork.RoleManager.CreateAsync(role);
                }
            }
            await CreateAsync(adminDto);
        }
        
        public void ChangeUserProps(ApplicationUser user, ApplicationUser user2)
        {
            user.Age = user2.Age;
            user.Email = user2.Email;
            user.LastName = user2.LastName;
            user.Login = user2.Login;
            user.Password = user2.Password;
            user.Phone = user2.Phone;
            user.PhoneNumber = user2.PhoneNumber;
            user.UserName = user2.UserName;



        }


    }
}
