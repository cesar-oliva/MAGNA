using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class actualizacionaviso1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notice_NoticePriority_NoticePriorityId",
                table: "Notice");

            migrationBuilder.DropColumn(
                name: "NoticePriorityyId",
                table: "Notice");

            migrationBuilder.RenameColumn(
                name: "TechnicallLocationId",
                table: "Notice",
                newName: "TechnicalLocationId");

            migrationBuilder.AlterColumn<Guid>(
                name: "NoticePriorityId",
                table: "Notice",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notice_NoticePriority_NoticePriorityId",
                table: "Notice",
                column: "NoticePriorityId",
                principalTable: "NoticePriority",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notice_NoticePriority_NoticePriorityId",
                table: "Notice");

            migrationBuilder.RenameColumn(
                name: "TechnicalLocationId",
                table: "Notice",
                newName: "TechnicallLocationId");

            migrationBuilder.AlterColumn<Guid>(
                name: "NoticePriorityId",
                table: "Notice",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "NoticePriorityyId",
                table: "Notice",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Notice_NoticePriority_NoticePriorityId",
                table: "Notice",
                column: "NoticePriorityId",
                principalTable: "NoticePriority",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
