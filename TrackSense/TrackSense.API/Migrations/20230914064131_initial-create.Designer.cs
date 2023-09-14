﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrackSense.API.Data;

#nullable disable

namespace TrackSense.API.Migrations
{
    [DbContext(typeof(TracksenseContext))]
    [Migration("20230914064131_initial-create")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Address", b =>
                {
                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AppartmentNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Country")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StreetName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StreetNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("AddressId")
                        .HasName("PK__Address__091C2AFB166146D8");

                    b.HasIndex("LocationId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.ApplicationToken", b =>
                {
                    b.Property<int>("ApplicationTokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApplicationTokenId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("LastUsedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ApplicationTokenId")
                        .HasName("PK__Applicat__51EA9096072F9446");

                    b.HasIndex(new[] { "Token" }, "UQ__Applicat__1EB4F8176BA0B319")
                        .IsUnique();

                    b.ToTable("ApplicationToken", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.CompletedRide", b =>
                {
                    b.Property<Guid>("CompletedRideId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PlannedRideId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserLogin1")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CompletedRideId")
                        .HasName("PK__Complete__3D404232BE9BF58B");

                    b.HasIndex("PlannedRideId");

                    b.HasIndex("UserLogin1");

                    b.ToTable("CompletedRide", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.CompletedRidePoint", b =>
                {
                    b.Property<Guid>("CompletedRideId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<int?>("RideStep")
                        .HasColumnType("int");

                    b.Property<double?>("Temperature")
                        .HasColumnType("float");

                    b.HasKey("CompletedRideId", "LocationId")
                        .HasName("PK__Complete__533FA87BD1669A65");

                    b.HasIndex("LocationId");

                    b.ToTable("CompletedRidePoint", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.CompletedRideStatistic", b =>
                {
                    b.Property<Guid>("CompletedRideId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("AvgSpeed")
                        .HasColumnType("float");

                    b.Property<int?>("Calories")
                        .HasColumnType("int");

                    b.Property<double?>("Distance")
                        .HasColumnType("float");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("TimeSpan");

                    b.Property<int?>("Falls")
                        .HasColumnType("int");

                    b.Property<double?>("MaxSpeed")
                        .HasColumnType("float");

                    b.HasKey("CompletedRideId")
                        .HasName("PK__Complete__3D4042327B20BD26");

                    b.ToTable("CompletedRideStatistics");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Contact", b =>
                {
                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Fullname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("UserLogin")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ContactId")
                        .HasName("PK_contact");

                    b.HasIndex("UserLogin");

                    b.ToTable("Contact", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Credential", b =>
                {
                    b.Property<string>("UserLogin")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UserLogin")
                        .HasName("PK__Credenti__7F8E8D5FB80D981D");

                    b.ToTable("Credential", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.InterestPoint", b =>
                {
                    b.Property<int>("InterestPointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestPointId"));

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserLogin")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("InterestPointId")
                        .HasName("PK__Interest__E13EB84985BF89F7");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserLogin");

                    b.ToTable("InterestPoint", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<double?>("Altitude")
                        .HasColumnType("float");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<double?>("Speed")
                        .HasColumnType("float");

                    b.HasKey("LocationId")
                        .HasName("PK__Location__E7FEA497B2F12385");

                    b.ToTable("Location", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.PlannedRide", b =>
                {
                    b.Property<Guid>("PlannedRideId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsFavorite")
                        .HasColumnType("bit")
                        .HasColumnName("isFavorite");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserLoginNavigationUserLogin")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PlannedRideId")
                        .HasName("PK__PlannedR__807DE2956F2B5FAE");

                    b.HasIndex("UserLoginNavigationUserLogin");

                    b.ToTable("PlannedRide", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.PlannedRidePoint", b =>
                {
                    b.Property<Guid>("PlannedRideId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int?>("RideStep")
                        .HasColumnType("int");

                    b.Property<double?>("Temperature")
                        .HasColumnType("float");

                    b.HasKey("PlannedRideId", "LocationId")
                        .HasName("PK__PlannedR__EE0208DC97FCB4A7");

                    b.HasIndex("LocationId");

                    b.ToTable("PlannedRidePoint", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.PlannedRideStatistic", b =>
                {
                    b.Property<Guid>("PlannedRideId")
                        .HasMaxLength(36)
                        .HasColumnType("uniqueidentifier");

                    b.Property<double?>("AverageDuration")
                        .HasColumnType("float");

                    b.Property<double?>("AverageSpeed")
                        .HasColumnType("float");

                    b.Property<int?>("Calories")
                        .HasColumnType("int");

                    b.Property<double?>("Distance")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Duration")
                        .HasColumnType("datetime");

                    b.Property<int?>("Falls")
                        .HasColumnType("int");

                    b.Property<double?>("MaximumSpeed")
                        .HasColumnType("float");

                    b.HasKey("PlannedRideId")
                        .HasName("PK__PlannedR__807DE295481CB488");

                    b.ToTable("PlannedRideStatistics");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Tracksense", b =>
                {
                    b.Property<Guid>("TracksenseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("IsFallen")
                        .HasColumnType("bit")
                        .HasColumnName("isFallen");

                    b.Property<bool?>("IsStolen")
                        .HasColumnType("bit")
                        .HasColumnName("isStolen");

                    b.Property<decimal?>("LastAltitude")
                        .HasColumnType("decimal(18, 6)");

                    b.Property<DateTime?>("LastCommunication")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("LastLatitude")
                        .HasColumnType("decimal(18, 6)");

                    b.Property<decimal?>("LastLongitude")
                        .HasColumnType("decimal(18, 6)");

                    b.Property<string>("UserLogin")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TracksenseId")
                        .HasName("PK__Tracksen__6AF72C603CA58608");

                    b.HasIndex(new[] { "UserLogin" }, "UQ__Tracksen__7F8E8D5EC0100CC1")
                        .IsUnique()
                        .HasFilter("[UserLogin] IS NOT NULL");

                    b.ToTable("Tracksense", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.User", b =>
                {
                    b.Property<string>("UserLogin")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserCodePostal")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("UserEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserFirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserLastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserPhoneNumber")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("UserLogin");

                    b.HasIndex(new[] { "UserLogin" }, "UQ__user__7F8E8D5EC31A1ED4")
                        .IsUnique();

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.UserStatistic", b =>
                {
                    b.Property<string>("UserLogin")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("AvgSpeed")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Duration")
                        .HasColumnType("datetime");

                    b.Property<double?>("MaxSpeed")
                        .HasColumnType("float");

                    b.HasKey("UserLogin")
                        .HasName("PK__UserStat__7F8E8D5FF90916AF");

                    b.ToTable("UserStatistics");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.UserToken", b =>
                {
                    b.Property<int>("UserTokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserTokenId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("LastUsedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserLogin")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserTokenId")
                        .HasName("PK__UserToke__BD92DEDB60619A76");

                    b.HasIndex("UserLogin");

                    b.HasIndex(new[] { "Token" }, "UQ__UserToke__1EB4F817FB3EA34C")
                        .IsUnique();

                    b.ToTable("UserToken", (string)null);
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Address", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.Location", "Location")
                        .WithMany("Addresses")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK_Address_Location");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.CompletedRide", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.PlannedRide", null)
                        .WithMany("CompletedRides")
                        .HasForeignKey("PlannedRideId");

                    b.HasOne("TrackSense.API.Services.DTOs.User", null)
                        .WithMany("CompletedRides")
                        .HasForeignKey("UserLogin1");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.CompletedRidePoint", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.CompletedRide", "CompletedRide")
                        .WithMany("CompletedRidePoints")
                        .HasForeignKey("CompletedRideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackSense.API.Services.DTOs.Location", "Location")
                        .WithMany("CompletedRidePoints")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompletedRide");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.CompletedRideStatistic", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.CompletedRide", "CompletedRide")
                        .WithOne("CompletedRideStatistic")
                        .HasForeignKey("TrackSense.API.Services.DTOs.CompletedRideStatistic", "CompletedRideId")
                        .IsRequired()
                        .HasConstraintName("FK_CompletedRideStatistics_CompletedRide");

                    b.Navigation("CompletedRide");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Contact", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.User", "UserLoginNavigation")
                        .WithMany("Contacts")
                        .HasForeignKey("UserLogin")
                        .HasConstraintName("FK_Contact_User");

                    b.Navigation("UserLoginNavigation");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Credential", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.User", "UserLoginNavigation")
                        .WithOne("Credential")
                        .HasForeignKey("TrackSense.API.Services.DTOs.Credential", "UserLogin")
                        .IsRequired()
                        .HasConstraintName("FK_Credential_User");

                    b.Navigation("UserLoginNavigation");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.InterestPoint", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.Address", "Address")
                        .WithMany("InterestPoints")
                        .HasForeignKey("AddressId")
                        .IsRequired()
                        .HasConstraintName("FK_InterestPoint_Address");

                    b.HasOne("TrackSense.API.Services.DTOs.User", "UserLoginNavigation")
                        .WithMany("InterestPoints")
                        .HasForeignKey("UserLogin")
                        .HasConstraintName("FK_InterestPoint_User");

                    b.Navigation("Address");

                    b.Navigation("UserLoginNavigation");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.PlannedRide", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.User", "UserLoginNavigation")
                        .WithMany("PlannedRides")
                        .HasForeignKey("UserLoginNavigationUserLogin");

                    b.Navigation("UserLoginNavigation");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.PlannedRidePoint", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.Location", "Location")
                        .WithMany("PlannedRidePoints")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrackSense.API.Services.DTOs.PlannedRide", "PlannedRide")
                        .WithMany("PlannedRidePoints")
                        .HasForeignKey("PlannedRideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("PlannedRide");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.PlannedRideStatistic", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.PlannedRide", "PlannedRide")
                        .WithOne("PlannedRideStatistic")
                        .HasForeignKey("TrackSense.API.Services.DTOs.PlannedRideStatistic", "PlannedRideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlannedRide");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Tracksense", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.User", "UserLoginNavigation")
                        .WithOne("Tracksense")
                        .HasForeignKey("TrackSense.API.Services.DTOs.Tracksense", "UserLogin")
                        .HasConstraintName("FK_Tracksense_User");

                    b.Navigation("UserLoginNavigation");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.UserStatistic", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.User", "UserLoginNavigation")
                        .WithOne("UserStatistic")
                        .HasForeignKey("TrackSense.API.Services.DTOs.UserStatistic", "UserLogin")
                        .IsRequired()
                        .HasConstraintName("FK_UserStatistics_User");

                    b.Navigation("UserLoginNavigation");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.UserToken", b =>
                {
                    b.HasOne("TrackSense.API.Services.DTOs.User", "UserLoginNavigation")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserLogin")
                        .IsRequired()
                        .HasConstraintName("FK_UserToken_User");

                    b.Navigation("UserLoginNavigation");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Address", b =>
                {
                    b.Navigation("InterestPoints");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.CompletedRide", b =>
                {
                    b.Navigation("CompletedRidePoints");

                    b.Navigation("CompletedRideStatistic");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.Location", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("CompletedRidePoints");

                    b.Navigation("PlannedRidePoints");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.PlannedRide", b =>
                {
                    b.Navigation("CompletedRides");

                    b.Navigation("PlannedRidePoints");

                    b.Navigation("PlannedRideStatistic");
                });

            modelBuilder.Entity("TrackSense.API.Services.DTOs.User", b =>
                {
                    b.Navigation("CompletedRides");

                    b.Navigation("Contacts");

                    b.Navigation("Credential");

                    b.Navigation("InterestPoints");

                    b.Navigation("PlannedRides");

                    b.Navigation("Tracksense");

                    b.Navigation("UserStatistic");

                    b.Navigation("UserTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
