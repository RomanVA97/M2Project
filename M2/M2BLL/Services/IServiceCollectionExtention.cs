using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using M2DAL.Services;
using M2BLL.Interfaces;
using M2BLL.Managers;

namespace M2BLL.Services
{
    public static class IServiceCollectionExtention
    {
        public static IServiceCollection AddBLLServices(this IServiceCollection services)
        {
            services.AddTransient<IEntityManager, EFEntityManager>();

            services.AddTransient<UserManager>();
            services.AddTransient<PlantManager>();
            services.AddTransient<AccountManager>();
            services.AddTransient<AreaManager>();


            services.AddAutoMapper();
            services.AddDALServices();
            return services;

        }
    }
}
