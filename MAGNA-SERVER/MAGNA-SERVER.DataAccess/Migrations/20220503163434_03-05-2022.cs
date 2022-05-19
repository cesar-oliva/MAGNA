using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class _03052022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssemblePropertyDescription",
                table: "AssembleProperty");

            migrationBuilder.DropColumn(
                name: "AssemblePropertyDetail",
                table: "AssembleProperty");

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

            migrationBuilder.AddColumn<string>(
                name: "AssembleDayGuarantee",
                table: "AssembleProperty",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssembleMaker",
                table: "AssembleProperty",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssemblePurchaseDate",
                table: "AssembleProperty",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssembleSerialNumber",
                table: "AssembleProperty",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssembleDayGuarantee",
                table: "AssembleProperty");

            migrationBuilder.DropColumn(
                name: "AssembleMaker",
                table: "AssembleProperty");

            migrationBuilder.DropColumn(
                name: "AssemblePurchaseDate",
                table: "AssembleProperty");

            migrationBuilder.DropColumn(
                name: "AssembleSerialNumber",
                table: "AssembleProperty");

            migrationBuilder.AddColumn<string>(
                name: "AssemblePropertyDescription",
                table: "AssembleProperty",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssemblePropertyDetail",
                table: "AssembleProperty",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
