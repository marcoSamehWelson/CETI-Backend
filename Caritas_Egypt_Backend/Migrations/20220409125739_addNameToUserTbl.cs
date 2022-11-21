using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class addNameToUserTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");
        }
    }
}
