using Microsoft.EntityFrameworkCore.Migrations;

namespace Roberto.Migrations
{
    public partial class AddColumYearManagerAndSignatureManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SignatureManager",
                table: "AboutUs",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearManager",
                table: "AboutUs",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SignatureManager",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "YearManager",
                table: "AboutUs");
        }
    }
}
