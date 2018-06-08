﻿// <auto-generated />
using M2DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace M2DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180604172250_change2")]
    partial class change2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("M2DAL.Entities.Alert", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatorId");

                    b.Property<string>("FileUrl");

                    b.Property<string>("Note");

                    b.Property<string>("OperationId");

                    b.Property<DateTime>("TimeStamps");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("OperationId");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("M2DAL.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("Age");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Login");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Password");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Phone");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("M2DAL.Entities.Area", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("PlantId");

                    b.Property<DateTime>("TimeStamps");

                    b.HasKey("Id");

                    b.HasIndex("PlantId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("M2DAL.Entities.ChemicalProduct", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("OperationId");

                    b.Property<DateTime>("TimeStamps");

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.ToTable("ChemicalProducts");
                });

            modelBuilder.Entity("M2DAL.Entities.Component", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("MachineId");

                    b.Property<string>("MaintenanceId");

                    b.Property<DateTime>("TimeStamps");

                    b.HasKey("Id");

                    b.HasIndex("MachineId");

                    b.HasIndex("MaintenanceId")
                        .IsUnique()
                        .HasFilter("[MaintenanceId] IS NOT NULL");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("M2DAL.Entities.Line", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreaId");

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("ManufacturerId");

                    b.Property<DateTime>("TimeStamps");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Lines");
                });

            modelBuilder.Entity("M2DAL.Entities.Location", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<DateTime>("TimeStamps");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("M2DAL.Entities.Machine", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<int?>("LineId");

                    b.Property<string>("LineId1");

                    b.Property<DateTime>("TimeStamps");

                    b.HasKey("Id");

                    b.HasIndex("LineId1");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("M2DAL.Entities.Maintenance", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Completed");

                    b.Property<int?>("ComponentId");

                    b.Property<bool>("ContaminationRisk");

                    b.Property<string>("Description");

                    b.Property<int>("ExtimatedTime");

                    b.Property<string>("LocationId");

                    b.Property<string>("MaintenancePatternTypeId");

                    b.Property<int>("Periodicity");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("M2DAL.Entities.Manufacturer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<DateTime>("TimeStamps");

                    b.HasKey("Id");

                    b.ToTable("Manufacturer");
                });

            modelBuilder.Entity("M2DAL.Entities.Operation", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ComponentId");

                    b.Property<bool>("ContaminationRisk");

                    b.Property<string>("CreatorId");

                    b.Property<string>("Description");

                    b.Property<bool>("Done");

                    b.Property<DateTime>("DueDate");

                    b.Property<bool>("ExternalMaintainer");

                    b.Property<string>("LocationId");

                    b.Property<bool>("MManagerApprove");

                    b.Property<int>("MachineStopTime");

                    b.Property<string>("MaintenanceId");

                    b.Property<string>("Note");

                    b.Property<int>("Number");

                    b.Property<bool>("PManagerApprove");

                    b.Property<bool>("QManagerApprove");

                    b.Property<bool>("ReferenceExist");

                    b.Property<bool>("SpareExist");

                    b.Property<DateTime>("TimeStamps");

                    b.Property<int>("Vote");

                    b.Property<string>("WorkerId");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LocationId");

                    b.HasIndex("MaintenanceId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("M2DAL.Entities.Plant", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<DateTime>("TimeStamps");

                    b.HasKey("Id");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("M2DAL.Entities.ApplicationRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");


                    b.ToTable("ApplicationRole");

                    b.HasDiscriminator().HasValue("ApplicationRole");
                });

            modelBuilder.Entity("M2DAL.Entities.Alert", b =>
                {
                    b.HasOne("M2DAL.Entities.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("M2DAL.Entities.Operation", "Operation")
                        .WithMany("Alerts")
                        .HasForeignKey("OperationId");
                });

            modelBuilder.Entity("M2DAL.Entities.Area", b =>
                {
                    b.HasOne("M2DAL.Entities.Plant", "Plant")
                        .WithMany("Areas")
                        .HasForeignKey("PlantId");
                });

            modelBuilder.Entity("M2DAL.Entities.ChemicalProduct", b =>
                {
                    b.HasOne("M2DAL.Entities.Operation", "Operation")
                        .WithMany("ChemicalProducts")
                        .HasForeignKey("OperationId");
                });

            modelBuilder.Entity("M2DAL.Entities.Component", b =>
                {
                    b.HasOne("M2DAL.Entities.Machine", "Machine")
                        .WithMany("Components")
                        .HasForeignKey("MachineId");

                    b.HasOne("M2DAL.Entities.Maintenance", "Maintenance")
                        .WithOne("Component")
                        .HasForeignKey("M2DAL.Entities.Component", "MaintenanceId");
                });

            modelBuilder.Entity("M2DAL.Entities.Line", b =>
                {
                    b.HasOne("M2DAL.Entities.Area", "Area")
                        .WithMany("Lines")
                        .HasForeignKey("AreaId");

                    b.HasOne("M2DAL.Entities.Manufacturer", "Manufacturer")
                        .WithMany("Lines")
                        .HasForeignKey("ManufacturerId");
                });

            modelBuilder.Entity("M2DAL.Entities.Machine", b =>
                {
                    b.HasOne("M2DAL.Entities.Line", "Line")
                        .WithMany("Machines")
                        .HasForeignKey("LineId1");
                });

            modelBuilder.Entity("M2DAL.Entities.Maintenance", b =>
                {
                    b.HasOne("M2DAL.Entities.Location", "Location")
                        .WithMany("Maintenances")
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("M2DAL.Entities.Operation", b =>
                {
                    b.HasOne("M2DAL.Entities.Component", "Component")
                        .WithMany()
                        .HasForeignKey("ComponentId");

                    b.HasOne("M2DAL.Entities.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("M2DAL.Entities.Location", "Location")
                        .WithMany("Operations")
                        .HasForeignKey("LocationId");

                    b.HasOne("M2DAL.Entities.Maintenance", "Maintenance")
                        .WithMany("Operations")
                        .HasForeignKey("MaintenanceId");

                    b.HasOne("M2DAL.Entities.ApplicationUser", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("M2DAL.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("M2DAL.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("M2DAL.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("M2DAL.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
