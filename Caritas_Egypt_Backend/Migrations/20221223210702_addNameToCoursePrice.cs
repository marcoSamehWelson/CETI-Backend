using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class addNameToCoursePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CoursePrices",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "CoursePrices");
        }
    }
}
