using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class AddStdTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EducationQualification",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Email",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FifthBrotherOrSisterName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBrotherOrSisterName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Students",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForthBrotherOrSisterName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JopTitle",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LandPhoneNumber",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Students",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherEducationQualification",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherFirstName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherJopTitle",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherLastName",
                table: "Students",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherPhoneNumber",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherSecondName",
                table: "Students",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentPhoneNumber",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SecondBrotherOrSisterName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondName",
                table: "Students",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdBrotherOrSisterName",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationQualification",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FifthBrotherOrSisterName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FirstBrotherOrSisterName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ForthBrotherOrSisterName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "JopTitle",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LandPhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MotherEducationQualification",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MotherFirstName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MotherJopTitle",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MotherLastName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MotherPhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "MotherSecondName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ParentPhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SecondBrotherOrSisterName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SecondName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ThirdBrotherOrSisterName",
                table: "Students");
        }
    }
}
