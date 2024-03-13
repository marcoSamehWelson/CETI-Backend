using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class addserial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "serial",
                table: "TrainingFEs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "serial",
                table: "ProjectsFEs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "serial",
                table: "ProjectsCategoryFEs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "serial",
                table: "ProgramsFEs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "serial",
                table: "ProgramsCategoryFEs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "serial",
                table: "OurPartnersFEs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "serial",
                table: "JobFEs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "serial",
                table: "ActivitiesAndEventsFEs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "serial",
                table: "TrainingFEs");

            migrationBuilder.DropColumn(
                name: "serial",
                table: "ProjectsFEs");

            migrationBuilder.DropColumn(
                name: "serial",
                table: "ProjectsCategoryFEs");

            migrationBuilder.DropColumn(
                name: "serial",
                table: "ProgramsFEs");

            migrationBuilder.DropColumn(
                name: "serial",
                table: "ProgramsCategoryFEs");

            migrationBuilder.DropColumn(
                name: "serial",
                table: "OurPartnersFEs");

            migrationBuilder.DropColumn(
                name: "serial",
                table: "JobFEs");

            migrationBuilder.DropColumn(
                name: "serial",
                table: "ActivitiesAndEventsFEs");
        }
    }
}
