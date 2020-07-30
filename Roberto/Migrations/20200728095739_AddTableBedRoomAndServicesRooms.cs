using Microsoft.EntityFrameworkCore.Migrations;

namespace Roberto.Migrations
{
    public partial class AddTableBedRoomAndServicesRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BedRooms",
                columns: table => new
                {
                    BedRoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PiceBedRoom = table.Column<int>(nullable: false),
                    NameBedRoom = table.Column<string>(maxLength: 250, nullable: true),
                    SizeBedRoom = table.Column<int>(maxLength: 500, nullable: false),
                    Disponible = table.Column<bool>(nullable: false),
                    NumberChild = table.Column<int>(maxLength: 6, nullable: false),
                    NumberAdult = table.Column<int>(maxLength: 6, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BedRooms", x => x.BedRoomId);
                });

            migrationBuilder.CreateTable(
                name: "ServicesRooms",
                columns: table => new
                {
                    ServiceRoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceListName = table.Column<string>(nullable: true),
                    BedRoomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesRooms", x => x.ServiceRoomId);
                    table.ForeignKey(
                        name: "FK_ServicesRooms_BedRooms_BedRoomId",
                        column: x => x.BedRoomId,
                        principalTable: "BedRooms",
                        principalColumn: "BedRoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServicesRooms_BedRoomId",
                table: "ServicesRooms",
                column: "BedRoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServicesRooms");

            migrationBuilder.DropTable(
                name: "BedRooms");
        }
    }
}
