using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class new02052022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AreaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssembleProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssemblePropertyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssemblePropertyDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssembleProperty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssembleType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssembleTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssembleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departament",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartamentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departament", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenderDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderState = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Noticecategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoticeCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeCategoryState = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Noticecategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NoticePriority",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoticePriorityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticePriorityState = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticePriority", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NoticeState",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoticeStateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeStateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticeState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NoticeType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoticeTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrderState",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkOrderStateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrderState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeBirthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeState = table.Column<bool>(type: "bit", nullable: false),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalLocation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TechnicalLocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalLocationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechnicalLocation_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TechnicalLocation_Departament_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TechnicalLocation_Sector_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assemble",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssembleDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AssembleTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TechnicalLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleMaker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssembleSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssemblePurchaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssembleDayGuarantee = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assemble", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assemble_AssembleType_AssembleTypeId",
                        column: x => x.AssembleTypeId,
                        principalTable: "AssembleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assemble_TechnicalLocation_TechnicalLocationId",
                        column: x => x.TechnicalLocationId,
                        principalTable: "TechnicalLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssembleAssembleProperty",
                columns: table => new
                {
                    AssembliesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssembleAssembleProperty", x => new { x.AssembliesId, x.PropertiesId });
                    table.ForeignKey(
                        name: "FK_AssembleAssembleProperty_Assemble_AssembliesId",
                        column: x => x.AssembliesId,
                        principalTable: "Assemble",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssembleAssembleProperty_AssembleProperty_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "AssembleProperty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoticeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FaultType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectedPart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaultDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoticePriorityyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoticeStateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoticeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoticePriorityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notice_Assemble_AssembleId",
                        column: x => x.AssembleId,
                        principalTable: "Assemble",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notice_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notice_Noticecategory_NoticeCategoryId",
                        column: x => x.NoticeCategoryId,
                        principalTable: "Noticecategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notice_NoticePriority_NoticePriorityId",
                        column: x => x.NoticePriorityId,
                        principalTable: "NoticePriority",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notice_NoticeState_NoticeStateId",
                        column: x => x.NoticeStateId,
                        principalTable: "NoticeState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notice_NoticeType_NoticeTypeId",
                        column: x => x.NoticeTypeId,
                        principalTable: "NoticeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubAssemble",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleVersionNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAssemble", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubAssemble_Assemble_Id",
                        column: x => x.Id,
                        principalTable: "Assemble",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkOrder",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkOrderCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkOrderDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkOrderStartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkOrderEndingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    NoticeId = table.Column<int>(type: "int", nullable: false),
                    WorkOrderStateId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NoticeId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WorkOrderStateId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrder_Employee_EmployeeId1",
                        column: x => x.EmployeeId1,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkOrder_Notice_NoticeId1",
                        column: x => x.NoticeId1,
                        principalTable: "Notice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkOrder_WorkOrderState_WorkOrderStateId1",
                        column: x => x.WorkOrderStateId1,
                        principalTable: "WorkOrderState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssembleSubAssemble",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleVersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssembleSubAssemble", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssembleSubAssemble_Assemble_AssembleId",
                        column: x => x.AssembleId,
                        principalTable: "Assemble",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssembleSubAssemble_SubAssemble_AssembleVersionId",
                        column: x => x.AssembleVersionId,
                        principalTable: "SubAssemble",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Assemble_AssembleTypeId",
                table: "Assemble",
                column: "AssembleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assemble_TechnicalLocationId",
                table: "Assemble",
                column: "TechnicalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssembleAssembleProperty_PropertiesId",
                table: "AssembleAssembleProperty",
                column: "PropertiesId");

            migrationBuilder.CreateIndex(
                name: "IX_AssembleSubAssemble_AssembleId",
                table: "AssembleSubAssemble",
                column: "AssembleId");

            migrationBuilder.CreateIndex(
                name: "IX_AssembleSubAssemble_AssembleVersionId",
                table: "AssembleSubAssemble",
                column: "AssembleVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_GenderId",
                table: "Employee",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Notice_AssembleId",
                table: "Notice",
                column: "AssembleId");

            migrationBuilder.CreateIndex(
                name: "IX_Notice_EmployeeId",
                table: "Notice",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notice_NoticeCategoryId",
                table: "Notice",
                column: "NoticeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Notice_NoticePriorityId",
                table: "Notice",
                column: "NoticePriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Notice_NoticeStateId",
                table: "Notice",
                column: "NoticeStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Notice_NoticeTypeId",
                table: "Notice",
                column: "NoticeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalLocation_AreaId",
                table: "TechnicalLocation",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalLocation_DepartamentId",
                table: "TechnicalLocation",
                column: "DepartamentId");

            migrationBuilder.CreateIndex(
                name: "IX_TechnicalLocation_SectorId",
                table: "TechnicalLocation",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_EmployeeId1",
                table: "WorkOrder",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_NoticeId1",
                table: "WorkOrder",
                column: "NoticeId1");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrder_WorkOrderStateId1",
                table: "WorkOrder",
                column: "WorkOrderStateId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AssembleAssembleProperty");

            migrationBuilder.DropTable(
                name: "AssembleSubAssemble");

            migrationBuilder.DropTable(
                name: "WorkOrder");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AssembleProperty");

            migrationBuilder.DropTable(
                name: "SubAssemble");

            migrationBuilder.DropTable(
                name: "Notice");

            migrationBuilder.DropTable(
                name: "WorkOrderState");

            migrationBuilder.DropTable(
                name: "Assemble");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Noticecategory");

            migrationBuilder.DropTable(
                name: "NoticePriority");

            migrationBuilder.DropTable(
                name: "NoticeState");

            migrationBuilder.DropTable(
                name: "NoticeType");

            migrationBuilder.DropTable(
                name: "AssembleType");

            migrationBuilder.DropTable(
                name: "TechnicalLocation");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Departament");

            migrationBuilder.DropTable(
                name: "Sector");
        }
    }
}
