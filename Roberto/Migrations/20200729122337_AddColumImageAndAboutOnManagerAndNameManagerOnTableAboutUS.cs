using Microsoft.EntityFrameworkCore.Migrations;

namespace Roberto.Migrations
{
    public partial class AddColumImageAndAboutOnManagerAndNameManagerOnTableAboutUS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AboutOnManager",
                table: "AboutUs",
                maxLength: 1500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageManager",
                table: "AboutUs",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutOnManager",
                table: "AboutUs");

            migrationBuilder.DropColumn(
                name: "ImageManager",
                table: "AboutUs");
        }
    }
}
