using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assemble_AssembleType_AssembleTypeId",
                table: "Assemble");

            migrationBuilder.DropTable(
                name: "Assemble_Version");

            migrationBuilder.AlterColumn<Guid>(
                name: "AssembleTypeId",
                table: "Assemble",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AssembleVersionId",
                table: "Assemble",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Assemble_AssembleVersionId",
                table: "Assemble",
                column: "AssembleVersionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assemble_AssembleType_AssembleTypeId",
                table: "Assemble",
                column: "AssembleTypeId",
                principalTable: "AssembleType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assemble_AssembleVersion_AssembleVersionId",
                table: "Assemble",
                column: "AssembleVersionId",
                principalTable: "AssembleVersion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assemble_AssembleType_AssembleTypeId",
                table: "Assemble");

            migrationBuilder.DropForeignKey(
                name: "FK_Assemble_AssembleVersion_AssembleVersionId",
                table: "Assemble");

            migrationBuilder.DropIndex(
                name: "IX_Assemble_AssembleVersionId",
                table: "Assemble");

            migrationBuilder.DropColumn(
                name: "AssembleVersionId",
                table: "Assemble");

            migrationBuilder.AlterColumn<Guid>(
                name: "AssembleTypeId",
                table: "Assemble",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.CreateIndex(
                name: "IX_Assemble_Version_AssembliesId",
                table: "Assemble_Version",
                column: "AssembliesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assemble_AssembleType_AssembleTypeId",
                table: "Assemble",
                column: "AssembleTypeId",
                principalTable: "AssembleType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
