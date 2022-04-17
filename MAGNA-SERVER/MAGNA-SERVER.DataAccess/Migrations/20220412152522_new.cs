using Microsoft.EntityFrameworkCore.Migrations;

namespace MAGNA_SERVER.DataAccess.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SerialNumber",
                table: "Assemble",
                newName: "AssembleSerialNumber");

            migrationBuilder.RenameColumn(
                name: "PurchaseDate",
                table: "Assemble",
                newName: "AssemblePurchaseDate");

            migrationBuilder.RenameColumn(
                name: "DaysGuarantee",
                table: "Assemble",
                newName: "AssembleDayGuarantee");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AssembleSerialNumber",
                table: "Assemble",
                newName: "SerialNumber");

            migrationBuilder.RenameColumn(
                name: "AssemblePurchaseDate",
                table: "Assemble",
                newName: "PurchaseDate");

            migrationBuilder.RenameColumn(
                name: "AssembleDayGuarantee",
                table: "Assemble",
                newName: "DaysGuarantee");
        }
    }
}
