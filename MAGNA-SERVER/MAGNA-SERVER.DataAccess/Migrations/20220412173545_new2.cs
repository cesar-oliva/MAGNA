using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class new2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assemble_Assemble_AssembleId",
                table: "Assemble");

            migrationBuilder.DropForeignKey(
                name: "FK_Assemble_Location_LocationId",
                table: "Assemble");

            migrationBuilder.DropIndex(
                name: "IX_Assemble_AssembleId",
                table: "Assemble");

            migrationBuilder.DropIndex(
                name: "IX_Assemble_LocationId",
                table: "Assemble");

            migrationBuilder.DropColumn(
                name: "AssembleDayGuarantee",
                table: "Assemble");

            migrationBuilder.DropColumn(
                name: "AssembleId",
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

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Assemble");

            migrationBuilder.AddColumn<string>(
                name: "AssembleDayGuarantee",
                table: "AssembleVersion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssembleMaker",
                table: "AssembleVersion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssemblePurchaseDate",
                table: "AssembleVersion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssembleSerialNumber",
                table: "AssembleVersion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssembleVersionCode",
                table: "AssembleVersion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssembleVersionDescription",
                table: "AssembleVersion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "AssembleVersion",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AssembleProperty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssemblePropertyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssemblePropertyDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssembleVersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssembleProperty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssembleProperty_AssembleVersion_AssembleVersionId",
                        column: x => x.AssembleVersionId,
                        principalTable: "AssembleVersion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssembleVersion_LocationId",
                table: "AssembleVersion",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssembleProperty_AssembleVersionId",
                table: "AssembleProperty",
                column: "AssembleVersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssembleVersion_Location_LocationId",
                table: "AssembleVersion",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssembleVersion_Location_LocationId",
                table: "AssembleVersion");

            migrationBuilder.DropTable(
                name: "AssembleProperty");

            migrationBuilder.DropIndex(
                name: "IX_AssembleVersion_LocationId",
                table: "AssembleVersion");

            migrationBuilder.DropColumn(
                name: "AssembleDayGuarantee",
                table: "AssembleVersion");

            migrationBuilder.DropColumn(
                name: "AssembleMaker",
                table: "AssembleVersion");

            migrationBuilder.DropColumn(
                name: "AssemblePurchaseDate",
                table: "AssembleVersion");

            migrationBuilder.DropColumn(
                name: "AssembleSerialNumber",
                table: "AssembleVersion");

            migrationBuilder.DropColumn(
                name: "AssembleVersionCode",
                table: "AssembleVersion");

            migrationBuilder.DropColumn(
                name: "AssembleVersionDescription",
                table: "AssembleVersion");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "AssembleVersion");

            migrationBuilder.AddColumn<string>(
                name: "AssembleDayGuarantee",
                table: "Assemble",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "AssembleId",
                table: "Assemble",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "Assemble",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Assemble_AssembleId",
                table: "Assemble",
                column: "AssembleId");

            migrationBuilder.CreateIndex(
                name: "IX_Assemble_LocationId",
                table: "Assemble",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assemble_Assemble_AssembleId",
                table: "Assemble",
                column: "AssembleId",
                principalTable: "Assemble",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Assemble_Location_LocationId",
                table: "Assemble",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
