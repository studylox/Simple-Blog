using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgrammingLearning.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "Videos");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Videos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userPassword = table.Column<int>(type: "int", nullable: false),
                    userHeader = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Videos");

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "Videos",
                type: "int",
                nullable: true);
        }
    }
}
