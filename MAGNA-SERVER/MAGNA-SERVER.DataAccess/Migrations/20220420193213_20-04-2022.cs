using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class _20042022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoticePriority",
                table: "Notice");

            migrationBuilder.AddColumn<Guid>(
                name: "NoticePriorityId",
                table: "Notice",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Notice_NoticePriorityId",
                table: "Notice",
                column: "NoticePriorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notice_NoticePriority_NoticePriorityId",
                table: "Notice",
                column: "NoticePriorityId",
                principalTable: "NoticePriority",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notice_NoticePriority_NoticePriorityId",
                table: "Notice");

            migrationBuilder.DropTable(
                name: "NoticePriority");

            migrationBuilder.DropIndex(
                name: "IX_Notice_NoticePriorityId",
                table: "Notice");

            migrationBuilder.DropColumn(
                name: "NoticePriorityId",
                table: "Notice");

            migrationBuilder.AddColumn<int>(
                name: "NoticePriority",
                table: "Notice",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
