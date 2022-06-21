﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SystemData;

namespace SystemData.Migrations
{
    [DbContext(typeof(SystemContext))]
    [Migration("20181217102929_MyFirstMigratioklkn")]
    partial class MyFirstMigratioklkn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SystemData.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<long?>("FacebookId");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<int?>("OfficeId");

                    b.Property<string>("Password");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PictureUrl");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Token");

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

                    b.HasIndex("OfficeId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SystemData.Models.Bills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppUserId");

                    b.Property<int?>("BillsNumber");

                    b.Property<int>("BoxId");

                    b.Property<int?>("BoxesId");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime>("DateBills");

                    b.Property<int?>("DateStartRent");

                    b.Property<DateTime>("ExpiretDate");

                    b.Property<DateTime>("InsertDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsManual");

                    b.Property<int?>("PayTypeId");

                    b.Property<decimal>("TotalBills");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("BoxesId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PayTypeId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("SystemData.Models.Boxes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsUsed");

                    b.Property<long>("NumberBox");

                    b.Property<int>("OfficeId");

                    b.Property<bool>("State");

                    b.Property<int>("TypeBoxId");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TypeBoxId");

                    b.ToTable("Boxes");
                });

            modelBuilder.Entity("SystemData.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("CustomerIdentityId");

                    b.Property<int>("CustomerJobsId");

                    b.Property<int>("CustomerTypeId");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhonNumber1");

                    b.Property<string>("PhonNumber2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerIdentityId");

                    b.HasIndex("CustomerJobsId");

                    b.HasIndex("CustomerTypeId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SystemData.Models.CustomerIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CustomerIdentity");
                });

            modelBuilder.Entity("SystemData.Models.CustomerJobs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CustomerJobs");
                });

            modelBuilder.Entity("SystemData.Models.CustomerType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CustomerType");
                });

            modelBuilder.Entity("SystemData.Models.DetailsCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DayFrom");

                    b.Property<int>("DayTo");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("DetailsCost");
                });

            modelBuilder.Entity("SystemData.Models.DetailsRent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost");

                    b.Property<int>("DetailsCostId");

                    b.Property<bool>("IsValid");

                    b.Property<bool>("IsValidDate");

                    b.Property<int>("TypeBoxId");

                    b.HasKey("Id");

                    b.HasIndex("DetailsCostId");

                    b.HasIndex("TypeBoxId");

                    b.ToTable("DetailsRent");
                });

            modelBuilder.Entity("SystemData.Models.ExtraCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("ServesCost");

                    b.HasKey("Id");

                    b.ToTable("ExtraCost");
                });

            modelBuilder.Entity("SystemData.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("SystemData.Models.OtherDetailsRent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillsId");

                    b.Property<int>("ExtraCostId");

                    b.Property<DateTime>("InsertDate");

                    b.HasKey("Id");

                    b.HasIndex("BillsId");

                    b.HasIndex("ExtraCostId");

                    b.ToTable("OtherDetailsRent");
                });

            modelBuilder.Entity("SystemData.Models.PayType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PayType");
                });

            modelBuilder.Entity("SystemData.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("SystemData.Models.TypeBox", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TypeBox");
                });

            modelBuilder.Entity("SystemData.Models.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UserType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("SystemData.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("SystemData.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SystemData.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("SystemData.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SystemData.Models.AppUser", b =>
                {
                    b.HasOne("SystemData.Models.Office", "Office")
                        .WithMany("User")
                        .HasForeignKey("OfficeId");
                });

            modelBuilder.Entity("SystemData.Models.Bills", b =>
                {
                    b.HasOne("SystemData.Models.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("SystemData.Models.Boxes", "Boxes")
                        .WithMany("Bills")
                        .HasForeignKey("BoxesId");

                    b.HasOne("SystemData.Models.Customer", "Customer")
                        .WithMany("Bills")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SystemData.Models.PayType", "PayType")
                        .WithMany()
                        .HasForeignKey("PayTypeId");
                });

            modelBuilder.Entity("SystemData.Models.Boxes", b =>
                {
                    b.HasOne("SystemData.Models.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SystemData.Models.TypeBox", "TypeBox")
                        .WithMany("Boxes")
                        .HasForeignKey("TypeBoxId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SystemData.Models.Customer", b =>
                {
                    b.HasOne("SystemData.Models.CustomerIdentity", "Identity")
                        .WithMany("Customer")
                        .HasForeignKey("CustomerIdentityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SystemData.Models.CustomerJobs", "CustomerJobsNavigation")
                        .WithMany("Customer")
                        .HasForeignKey("CustomerJobsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SystemData.Models.CustomerType", "CustomerType")
                        .WithMany("Customer")
                        .HasForeignKey("CustomerTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SystemData.Models.DetailsRent", b =>
                {
                    b.HasOne("SystemData.Models.DetailsCost", "DetailsCost")
                        .WithMany("DetailsRent")
                        .HasForeignKey("DetailsCostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SystemData.Models.TypeBox", "TypeBox")
                        .WithMany("DetailsRent")
                        .HasForeignKey("TypeBoxId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SystemData.Models.OtherDetailsRent", b =>
                {
                    b.HasOne("SystemData.Models.Bills", "Bills")
                        .WithMany("OtherDetailsRent")
                        .HasForeignKey("BillsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SystemData.Models.ExtraCost", "ExtraCost")
                        .WithMany("OtherDetailsRent")
                        .HasForeignKey("ExtraCostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
