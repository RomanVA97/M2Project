using M2BLL.DataTransferObjects;
using M2BLL.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace M2BLL.Interfaces
{
    interface IUserManager
    {
        Task<OperationDetails> CreateAsync(UserDTO userDto);
        Task SetInitialDataAsync(UserDTO adminDto, List<string> roles);
    }
}
