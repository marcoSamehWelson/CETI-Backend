using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FifthBrotherOrSisterNationalID",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FifthBrotherOrSisterPhoneNumber",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBrotherOrSisterNationalID",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstBrotherOrSisterPhoneNumber",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForthBrotherOrSisterNationalID",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ForthBrotherOrSisterPhoneNumber",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumberForWatsapp",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBrotherOrSisterNationalID",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondBrotherOrSisterPhoneNumber",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdBrotherOrSisterNationalID",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdBrotherOrSisterPhoneNumber",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FifthBrotherOrSisterNationalID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FifthBrotherOrSisterPhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FirstBrotherOrSisterNationalID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FirstBrotherOrSisterPhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ForthBrotherOrSisterNationalID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ForthBrotherOrSisterPhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PhoneNumberForWatsapp",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SecondBrotherOrSisterNationalID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SecondBrotherOrSisterPhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ThirdBrotherOrSisterNationalID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ThirdBrotherOrSisterPhoneNumber",
                table: "Students");
        }
    }
}
