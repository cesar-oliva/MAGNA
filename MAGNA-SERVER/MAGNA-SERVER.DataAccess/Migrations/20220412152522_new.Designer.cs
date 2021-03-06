// <auto-generated />
using System;
using MAGNA_SERVER.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20220412152522_new")]
    partial class @new
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AssembleAssembleVersion", b =>
                {
                    b.Property<Guid>("AssembleVersionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AssembliesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AssembleVersionsId", "AssembliesId");

                    b.HasIndex("AssembliesId");

                    b.ToTable("Assemble_Version");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Area", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AreaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Assemble", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssembleCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssembleDayGuarantee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssembleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("AssembleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssembleMaker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssemblePurchaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssembleSerialNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("AssembleTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssembleId");

                    b.HasIndex("AssembleTypeId");

                    b.HasIndex("LocationId");

                    b.ToTable("Assemble");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.AssembleType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssembleTypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssembleTypeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssembleType");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.AssembleVersion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AssembleVersionNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AssembleVersion");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Departament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DepartamentDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departament");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmployeeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmployeeBirthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeEmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmployeeEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeePhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EmployeeStartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EmployeeState")
                        .HasColumnType("bit");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GenderDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GenderState")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AreaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DepartamentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LocationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SectorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("DepartamentId");

                    b.HasIndex("SectorId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Notice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AffectedPart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("AssembleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FaultDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaultType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("NoticeCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NoticeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NoticeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoticeDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoticePriority")
                        .HasColumnType("int");

                    b.Property<Guid?>("NoticeStateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TechnicalLocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssembleId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("NoticeCategoryId");

                    b.HasIndex("NoticeStateId");

                    b.ToTable("Notice");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.NoticeCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NoticeCategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NoticeCategory");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.NoticeState", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NoticeStateCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoticeStateDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NoticeState");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Sector", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SectorDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.WorkOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<Guid?>("EmployeeId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NoticeId")
                        .HasColumnType("int");

                    b.Property<Guid?>("NoticeId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WorkOrderCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkOrderDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WorkOrderEndingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WorkOrderStartingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkOrderStateId")
                        .HasColumnType("int");

                    b.Property<Guid?>("WorkOrderStateId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId1");

                    b.HasIndex("NoticeId1");

                    b.HasIndex("WorkOrderStateId1");

                    b.ToTable("WorkOrder");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.WorkOrderState", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WorkOrderStateDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkOrderState");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AssembleAssembleVersion", b =>
                {
                    b.HasOne("MAGNA_SERVER.Entities.AssembleVersion", null)
                        .WithMany()
                        .HasForeignKey("AssembleVersionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MAGNA_SERVER.Entities.Assemble", null)
                        .WithMany()
                        .HasForeignKey("AssembliesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Assemble", b =>
                {
                    b.HasOne("MAGNA_SERVER.Entities.Assemble", null)
                        .WithMany("SubAssemble")
                        .HasForeignKey("AssembleId");

                    b.HasOne("MAGNA_SERVER.Entities.AssembleType", "AssembleType")
                        .WithMany()
                        .HasForeignKey("AssembleTypeId");

                    b.HasOne("MAGNA_SERVER.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssembleType");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Employee", b =>
                {
                    b.HasOne("MAGNA_SERVER.Entities.Gender", null)
                        .WithMany("Employee")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Location", b =>
                {
                    b.HasOne("MAGNA_SERVER.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId");

                    b.HasOne("MAGNA_SERVER.Entities.Departament", "Departament")
                        .WithMany()
                        .HasForeignKey("DepartamentId");

                    b.HasOne("MAGNA_SERVER.Entities.Sector", "Sector")
                        .WithMany()
                        .HasForeignKey("SectorId");

                    b.Navigation("Area");

                    b.Navigation("Departament");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Notice", b =>
                {
                    b.HasOne("MAGNA_SERVER.Entities.Assemble", "Assemble")
                        .WithMany()
                        .HasForeignKey("AssembleId");

                    b.HasOne("MAGNA_SERVER.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("MAGNA_SERVER.Entities.NoticeCategory", "NoticeCategory")
                        .WithMany()
                        .HasForeignKey("NoticeCategoryId");

                    b.HasOne("MAGNA_SERVER.Entities.NoticeState", "NoticeState")
                        .WithMany()
                        .HasForeignKey("NoticeStateId");

                    b.Navigation("Assemble");

                    b.Navigation("Employee");

                    b.Navigation("NoticeCategory");

                    b.Navigation("NoticeState");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.WorkOrder", b =>
                {
                    b.HasOne("MAGNA_SERVER.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId1");

                    b.HasOne("MAGNA_SERVER.Entities.Notice", "Notice")
                        .WithMany()
                        .HasForeignKey("NoticeId1");

                    b.HasOne("MAGNA_SERVER.Entities.WorkOrderState", "WorkOrderState")
                        .WithMany()
                        .HasForeignKey("WorkOrderStateId1");

                    b.Navigation("Employee");

                    b.Navigation("Notice");

                    b.Navigation("WorkOrderState");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Assemble", b =>
                {
                    b.Navigation("SubAssemble");
                });

            modelBuilder.Entity("MAGNA_SERVER.Entities.Gender", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
