using Microsoft.EntityFrameworkCore.Migrations;

namespace WebWeek4.Data.Migrations
{
    public partial class Songs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Songs",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Album",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Artist",
                table: "Songs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Songs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Album",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "Artist",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Songs",
                newName: "ID");
        }
    }
}
