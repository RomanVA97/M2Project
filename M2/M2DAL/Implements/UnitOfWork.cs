using M2DAL.EF;
using M2DAL.Identity;
using M2DAL.Interfaces;
using M2DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace M2DAL.Implements
{
    public class UnitOfWork : IUnitOfWork
    {
        DataContext _appContext;
        bool _disposed;

        public UnitOfWork(DataContext appContext, ApplicationUserManager applicationUserManager, ApplicationRoleManager applicationRoleManager,
            ApplicationSignInManager applicationSignInManager)
        {
            _disposed = false;
            _appContext = appContext;
            UserManager = applicationUserManager;
            RoleManager = applicationRoleManager;
            SignInManager = applicationSignInManager;
        }

        public EFRepository<T> EFRepository<T>() where T : class
        {
            return new EFRepository<T>(_appContext);
        }

        public ApplicationUserManager UserManager { get; set; } 
        public ApplicationRoleManager RoleManager { get; set; }
        public ApplicationSignInManager SignInManager { get; set; }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _appContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        
    }
}
