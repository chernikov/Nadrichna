using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NadrichnaWeb.Migrations
{
    public partial class addTaskCompleteDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompleteDate",
                table: "Tasks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompleteDate",
                table: "Tasks");
        }
    }
}
