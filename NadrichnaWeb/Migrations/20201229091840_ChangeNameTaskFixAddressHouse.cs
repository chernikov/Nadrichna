using Microsoft.EntityFrameworkCore.Migrations;

namespace NadrichnaWeb.Migrations
{
    public partial class ChangeNameTaskFixAddressHouse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Houses");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Houses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Houses");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Tasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
