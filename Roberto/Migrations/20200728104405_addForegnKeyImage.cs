using Microsoft.EntityFrameworkCore.Migrations;

namespace Roberto.Migrations
{
    public partial class addForegnKeyImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BedRooms_Images_ÏmageImgId",
                table: "BedRooms");

            migrationBuilder.DropIndex(
                name: "IX_BedRooms_ÏmageImgId",
                table: "BedRooms");

            migrationBuilder.DropColumn(
                name: "ÏmageImgId",
                table: "BedRooms");

            migrationBuilder.AddColumn<int>(
                name: "ImgId",
                table: "BedRooms",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BedRooms_ImgId",
                table: "BedRooms",
                column: "ImgId");

            migrationBuilder.AddForeignKey(
                name: "FK_BedRooms_Images_ImgId",
                table: "BedRooms",
                column: "ImgId",
                principalTable: "Images",
                principalColumn: "ImgId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BedRooms_Images_ImgId",
                table: "BedRooms");

            migrationBuilder.DropIndex(
                name: "IX_BedRooms_ImgId",
                table: "BedRooms");

            migrationBuilder.DropColumn(
                name: "ImgId",
                table: "BedRooms");

            migrationBuilder.AddColumn<int>(
                name: "ÏmageImgId",
                table: "BedRooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BedRooms_ÏmageImgId",
                table: "BedRooms",
                column: "ÏmageImgId");

            migrationBuilder.AddForeignKey(
                name: "FK_BedRooms_Images_ÏmageImgId",
                table: "BedRooms",
                column: "ÏmageImgId",
                principalTable: "Images",
                principalColumn: "ImgId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
