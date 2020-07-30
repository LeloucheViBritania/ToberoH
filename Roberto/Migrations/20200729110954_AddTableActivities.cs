using Microsoft.EntityFrameworkCore.Migrations;

namespace Roberto.Migrations
{
    public partial class AddTableActivities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageActivity = table.Column<string>(maxLength: 250, nullable: true),
                    CommentOnActivity = table.Column<string>(maxLength: 1000, nullable: true),
                    TypeActivity = table.Column<string>(maxLength: 90, nullable: true),
                    NameActivity = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
