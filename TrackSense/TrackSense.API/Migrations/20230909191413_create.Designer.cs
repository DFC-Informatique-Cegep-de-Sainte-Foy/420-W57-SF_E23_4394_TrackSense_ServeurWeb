﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackSense.API.Data;

#nullable disable

namespace TrackSense.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230909191413_create")]
    partial class create
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.AddressDTO", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AppartmentNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("LocationDTOLocationId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AddressId");

                    b.HasIndex("LocationDTOLocationId");

                    b.ToTable("address");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.CompletedRideDTO", b =>
                {
                    b.Property<Guid>("CompletedRideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("PlannedRideId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("StatisticsCompletedRideId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CompletedRideId");

                    b.HasIndex("PlannedRideId");

                    b.HasIndex("StatisticsCompletedRideId");

                    b.ToTable("CompletedRide");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.CompletedRidePointDTO", b =>
                {
                    b.Property<Guid>("CompletedRideId")
                        .HasColumnType("char(36)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<Guid?>("CompletedRideDTOCompletedRideId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("RideStep")
                        .HasColumnType("int");

                    b.Property<double?>("Temperature")
                        .HasColumnType("double");

                    b.HasKey("CompletedRideId", "LocationId");

                    b.HasIndex("CompletedRideDTOCompletedRideId");

                    b.HasIndex("LocationId");

                    b.ToTable("CompletedRidePoint");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.CompletedRideStatisticsDTO", b =>
                {
                    b.Property<Guid>("CompletedRideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double?>("AverageSpeed")
                        .HasColumnType("double");

                    b.Property<int?>("Calories")
                        .HasColumnType("int");

                    b.Property<double?>("Distance")
                        .HasColumnType("double");

                    b.Property<DateTime?>("Duration")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Falls")
                        .HasColumnType("int");

                    b.Property<double?>("MaximumSpeed")
                        .HasColumnType("double");

                    b.HasKey("CompletedRideId");

                    b.ToTable("CompletedRideStatistics");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.LocationDTO", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Altitude")
                        .HasColumnType("double");

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<double>("Longitude")
                        .HasColumnType("double");

                    b.Property<double>("Speed")
                        .HasColumnType("double");

                    b.HasKey("LocationId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.PlannedRideDTO", b =>
                {
                    b.Property<Guid>("PlannedRideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsFavorite")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("StatisticsPlannedRideId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PlannedRideId");

                    b.HasIndex("StatisticsPlannedRideId");

                    b.ToTable("PlannedRide");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.PlannedRidePointDTO", b =>
                {
                    b.Property<Guid>("PlannedRideId")
                        .HasColumnType("char(36)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("LocationDTOLocationId")
                        .HasColumnType("int");

                    b.Property<Guid?>("PlannedRideDTOPlannedRideId")
                        .HasColumnType("char(36)");

                    b.Property<int>("RideStep")
                        .HasColumnType("int");

                    b.Property<double>("Temperature")
                        .HasColumnType("double");

                    b.HasKey("PlannedRideId", "LocationId");

                    b.HasIndex("LocationDTOLocationId");

                    b.HasIndex("PlannedRideDTOPlannedRideId");

                    b.ToTable("PlannedRidePoint");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.PlannedRideStatisticsDTO", b =>
                {
                    b.Property<Guid>("PlannedRideId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double>("AverageDuration")
                        .HasColumnType("double");

                    b.Property<double>("AverageSpeed")
                        .HasColumnType("double");

                    b.Property<double>("MaximumSpeed")
                        .HasColumnType("double");

                    b.HasKey("PlannedRideId");

                    b.ToTable("PlannedRideStatistics");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.UserDTO", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AddressDTOAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("CodePostal")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserLogin")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("AddressDTOAddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTO.UserDTO", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTO.UserDTO", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackSense.API.Services.DTO.UserDTO", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTO.UserDTO", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.AddressDTO", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTO.LocationDTO", "LocationDTO")
                        .WithMany()
                        .HasForeignKey("LocationDTOLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LocationDTO");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.CompletedRideDTO", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTO.PlannedRideDTO", "PlannedRide")
                        .WithMany()
                        .HasForeignKey("PlannedRideId");

                    b.HasOne("TrackSense.API.Services.DTO.CompletedRideStatisticsDTO", "Statistics")
                        .WithMany()
                        .HasForeignKey("StatisticsCompletedRideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlannedRide");

                    b.Navigation("Statistics");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.CompletedRidePointDTO", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTO.CompletedRideDTO", null)
                        .WithMany("CompletedRidePoints")
                        .HasForeignKey("CompletedRideDTOCompletedRideId");

                    b.HasOne("TrackSense.API.Services.DTO.LocationDTO", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.PlannedRideDTO", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTO.PlannedRideStatisticsDTO", "Statistics")
                        .WithMany()
                        .HasForeignKey("StatisticsPlannedRideId");

                    b.Navigation("Statistics");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.PlannedRidePointDTO", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTO.LocationDTO", "LocationDTO")
                        .WithMany()
                        .HasForeignKey("LocationDTOLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackSense.API.Services.DTO.PlannedRideDTO", null)
                        .WithMany("RidePoints")
                        .HasForeignKey("PlannedRideDTOPlannedRideId");

                    b.Navigation("LocationDTO");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.UserDTO", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTO.AddressDTO", "AddressDTO")
                        .WithMany()
                        .HasForeignKey("AddressDTOAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressDTO");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.CompletedRideDTO", b =>
                {
                    b.Navigation("CompletedRidePoints");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTO.PlannedRideDTO", b =>
                {
                    b.Navigation("RidePoints");
                });
#pragma warning restore 612, 618
        }
    }
}