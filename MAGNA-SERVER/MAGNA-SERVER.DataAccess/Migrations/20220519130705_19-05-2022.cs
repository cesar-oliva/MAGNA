using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class _19052022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssembleProperty");

            migrationBuilder.DropColumn(
                name: "AssemblePropertyId",
                table: "Assemble");

            migrationBuilder.AddColumn<string>(
                name: "AssembleDayGuarantee",
                table: "Assemble",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssembleMaker",
                table: "Assemble",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssemblePurchaseDate",
                table: "Assemble",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssembleSerialNumber",
                table: "Assemble",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssembleDayGuarantee",
                table: "Assemble");

            migrationBuilder.DropColumn(
                name: "AssembleMaker",
                table: "Assemble");

            migrationBuilder.DropColumn(
                name: "AssemblePurchaseDate",
                table: "Assemble");

            migrationBuilder.DropColumn(
                name: "AssembleSerialNumber",
                table: "Assemble");

            migrationBuilder.AddColumn<Guid>(
                name: "AssemblePropertyId",
                table: "Assemble",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AssembleProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssembleDayGuarantee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssembleMaker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssemblePurchaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssembleSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssembleProperty", x => x.Id);
                });
        }
    }
}
