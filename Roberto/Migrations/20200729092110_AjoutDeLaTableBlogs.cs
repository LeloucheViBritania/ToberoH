using Microsoft.EntityFrameworkCore.Migrations;

namespace Roberto.Migrations
{
    public partial class AjoutDeLaTableBlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Comments_CommentId",
                table: "Clients");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 300, nullable: true),
                    Videos = table.Column<string>(maxLength: 300, nullable: true),
                    CommmentPhotoos = table.Column<string>(maxLength: 1500, nullable: true),
                    CommentVideos = table.Column<string>(maxLength: 1500, nullable: true),
                    TypeEvent = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Comments_CommentId",
                table: "Clients",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "CommentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Comments_CommentId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Comments_CommentId",
                table: "Clients",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "CommentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
