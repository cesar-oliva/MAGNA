using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class init_05042022 : Migration
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
                name: "AssembleVersion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleVersionNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssembleVersion", x => x.Id);
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
                name: "NoticeCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoticeCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoticeCategory", x => x.Id);
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
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Location_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Location_Departament_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Location_Sector_SectorId",
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
                    AssembleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssembleTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleMaker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaysGuarantee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssembleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assemble", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assemble_Assemble_AssembleId",
                        column: x => x.AssembleId,
                        principalTable: "Assemble",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assemble_AssembleType_AssembleTypeId",
                        column: x => x.AssembleTypeId,
                        principalTable: "AssembleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assemble_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assemble_Version",
                columns: table => new
                {
                    AssembleVersionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembliesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assemble_Version", x => new { x.AssembleVersionsId, x.AssembliesId });
                    table.ForeignKey(
                        name: "FK_Assemble_Version_Assemble_AssembliesId",
                        column: x => x.AssembliesId,
                        principalTable: "Assemble",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assemble_Version_AssembleVersion_AssembleVersionsId",
                        column: x => x.AssembleVersionsId,
                        principalTable: "AssembleVersion",
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
                    NoticePriority = table.Column<int>(type: "int", nullable: false),
                    FaultType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AffectedPart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaultDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticeCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NoticeStateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AssembleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notice_Assemble_AssembleId",
                        column: x => x.AssembleId,
                        principalTable: "Assemble",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notice_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notice_NoticeCategory_NoticeCategoryId",
                        column: x => x.NoticeCategoryId,
                        principalTable: "NoticeCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notice_NoticeState_NoticeStateId",
                        column: x => x.NoticeStateId,
                        principalTable: "NoticeState",
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
                name: "IX_Assemble_AssembleId",
                table: "Assemble",
                column: "AssembleId");

            migrationBuilder.CreateIndex(
                name: "IX_Assemble_AssembleTypeId",
                table: "Assemble",
                column: "AssembleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assemble_LocationId",
                table: "Assemble",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Assemble_Version_AssembliesId",
                table: "Assemble_Version",
                column: "AssembliesId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_GenderId",
                table: "Employee",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_AreaId",
                table: "Location",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_DepartamentId",
                table: "Location",
                column: "DepartamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_SectorId",
                table: "Location",
                column: "SectorId");

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
                name: "IX_Notice_NoticeStateId",
                table: "Notice",
                column: "NoticeStateId");

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
                name: "Assemble_Version");

            migrationBuilder.DropTable(
                name: "WorkOrder");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AssembleVersion");

            migrationBuilder.DropTable(
                name: "Notice");

            migrationBuilder.DropTable(
                name: "WorkOrderState");

            migrationBuilder.DropTable(
                name: "Assemble");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "NoticeCategory");

            migrationBuilder.DropTable(
                name: "NoticeState");

            migrationBuilder.DropTable(
                name: "AssembleType");

            migrationBuilder.DropTable(
                name: "Location");

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
