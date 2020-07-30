using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Roberto.Migrations
{
    public partial class UpdateBedRoomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Capacité_Chambre",
                table: "BedRooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date_Disponible",
                table: "BedRooms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Note",
                table: "BedRooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Service",
                table: "BedRooms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacité_Chambre",
                table: "BedRooms");

            migrationBuilder.DropColumn(
                name: "Date_Disponible",
                table: "BedRooms");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "BedRooms");

            migrationBuilder.DropColumn(
                name: "Service",
                table: "BedRooms");
        }
    }
}
