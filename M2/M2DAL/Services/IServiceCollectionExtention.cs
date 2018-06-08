using M2DAL.EF;
using M2DAL.Implements;
using M2DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using M2DAL.Repositories;
using Microsoft.EntityFrameworkCore.Design;
using M2DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using M2DAL.Identity;

namespace M2DAL.Services
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddDALServices(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ApplicationUserManager>();
            services.AddTransient<ApplicationRoleManager>();
            services.AddTransient<ApplicationSignInManager>();

            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configurate.GetConnectionString("DefaultConnection")));


            services.AddIdentity<ApplicationUser, ApplicationRole>
                (options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequiredLength = 6;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;

                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                    options.Lockout.MaxFailedAccessAttempts = 10;

                }).AddEntityFrameworkStores<DataContext>()
                .AddDefaultTokenProviders();


            return services;

        }
    }
}