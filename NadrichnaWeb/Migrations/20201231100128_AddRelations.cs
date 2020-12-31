using Microsoft.EntityFrameworkCore.Migrations;

namespace NadrichnaWeb.Migrations
{
    public partial class AddRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Tasks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "Players",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_PlayerId",
                table: "Tasks",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_HouseId",
                table: "Players",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Houses_HouseId",
                table: "Players",
                column: "HouseId",
                principalTable: "Houses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Players_PlayerId",
                table: "Tasks",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Houses_HouseId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Players_PlayerId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_PlayerId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Players_HouseId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "Players");
        }
    }
}
