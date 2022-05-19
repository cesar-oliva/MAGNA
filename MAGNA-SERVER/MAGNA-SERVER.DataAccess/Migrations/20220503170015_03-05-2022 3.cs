using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class _030520223 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssembleProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleMaker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssembleSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssemblePurchaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssembleDayGuarantee = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssembleProperty", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssembleProperty");
        }
    }
}
