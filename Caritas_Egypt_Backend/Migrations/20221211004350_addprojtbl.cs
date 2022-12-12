using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class addprojtbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "ProjectsFEs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mainactivities",
                table: "ProjectsFEs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Objectives",
                table: "ProjectsFEs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Partners",
                table: "ProjectsFEs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TargetgrouporBeneficiaries",
                table: "ProjectsFEs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "ProjectsFEs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "ProjectsFEs");

            migrationBuilder.DropColumn(
                name: "Mainactivities",
                table: "ProjectsFEs");

            migrationBuilder.DropColumn(
                name: "Objectives",
                table: "ProjectsFEs");

            migrationBuilder.DropColumn(
                name: "Partners",
                table: "ProjectsFEs");

            migrationBuilder.DropColumn(
                name: "TargetgrouporBeneficiaries",
                table: "ProjectsFEs");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "ProjectsFEs");
        }
    }
}
