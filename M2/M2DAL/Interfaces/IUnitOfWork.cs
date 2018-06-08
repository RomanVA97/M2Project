using M2DAL.Entities;
using M2DAL.Identity;
using M2DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        EFRepository<T> EFRepository<T>() where T : class;
        ApplicationUserManager UserManager { get; set; }
        ApplicationRoleManager RoleManager { get; set; }
        ApplicationSignInManager SignInManager { get; set; }
    }
}
