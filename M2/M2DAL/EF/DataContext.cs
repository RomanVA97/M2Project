using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using M2DAL.Entities;
using M2DAL.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace M2DAL.EF
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        

        public DbSet<Alert> Alerts { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<ChemicalProduct> ChemicalProducts { get; set; }
        public DbSet<Component> Components { get; set; }
        //public DbSet<ComponentType> ComponentTypes { get; set; }
        //public DbSet<ExtraordinaryOperation> ExtraordinaryOperations { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Machine> Machines { get; set; }
        //public DbSet<MachineStopPeriod> MachineStopPeriods { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Operation> Operations { get; set; }
        //public DbSet<OrdinaryOperation> OrdinaryOperations { get; set; }
        public DbSet<Plant> Plants { get; set; }

    }
}
