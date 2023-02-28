using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgrammingLearning.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
