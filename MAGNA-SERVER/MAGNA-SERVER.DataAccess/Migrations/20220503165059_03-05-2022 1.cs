using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class _030520221 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssembleAssembleProperty");

            migrationBuilder.DropTable(
                name: "AssembleProperty");

            migrationBuilder.AddColumn<Guid>(
                name: "AssemblePropertyId",
                table: "Assemble",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssemblePropertyId",
                table: "Assemble");

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

            migrationBuilder.CreateIndex(
                name: "IX_AssembleAssembleProperty_PropertiesId",
                table: "AssembleAssembleProperty",
                column: "PropertiesId");
        }
    }
}
