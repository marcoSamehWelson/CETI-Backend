using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class AddUserTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentParent",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    LandPhoneNumber = table.Column<int>(nullable: false),
                    EducationQualification = table.Column<string>(nullable: true),
                    JopTitle = table.Column<string>(nullable: true),
                    Email = table.Column<int>(nullable: false),
                    MotherFirstName = table.Column<string>(nullable: true),
                    MotherSecondName = table.Column<string>(maxLength: 50, nullable: true),
                    MotherLastName = table.Column<string>(maxLength: 50, nullable: true),
                    MotherPhoneNumber = table.Column<string>(nullable: true),
                    MotherEducationQualification = table.Column<string>(nullable: true),
                    MotherJopTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentParent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfDisability",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfDisability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    NationalID = table.Column<short>(nullable: false),
                    NightTrainer = table.Column<bool>(nullable: false),
                    BranchId = table.Column<Guid>(nullable: true),
                    ServiceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainer_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainer_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Age = table.Column<float>(nullable: true),
                    ServiceCardNumber = table.Column<int>(nullable: false),
                    TypeOfDisabilityId = table.Column<Guid>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    NationalID = table.Column<short>(nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    InSchool = table.Column<bool>(nullable: false),
                    SchoolName = table.Column<string>(nullable: true),
                    SchoolYear = table.Column<string>(nullable: true),
                    GotAJobPlacement = table.Column<bool>(nullable: false),
                    JopType = table.Column<string>(nullable: true),
                    JopPlace = table.Column<string>(nullable: true),
                    JopAdress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_TypeOfDisability_TypeOfDisabilityId",
                        column: x => x.TypeOfDisabilityId,
                        principalTable: "TypeOfDisability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_TypeOfDisabilityId",
                table: "Students",
                column: "TypeOfDisabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainer_BranchId",
                table: "Trainer",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainer_ServiceId",
                table: "Trainer",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentParent");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.DropTable(
                name: "TypeOfDisability");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Service");
        }
    }
}
