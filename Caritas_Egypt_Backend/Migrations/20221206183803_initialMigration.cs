using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiscriptionLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscriptionLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramsCategoryFEs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tittle = table.Column<string>(maxLength: 50, nullable: false),
                    Descreption = table.Column<string>(maxLength: 5000, nullable: true),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramsCategoryFEs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectsFEs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tittle = table.Column<string>(maxLength: 50, nullable: false),
                    Paragraph = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsFEs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SessionTime",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentNationalities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentNationalities", x => x.Id);
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
                    BranchId = table.Column<Guid>(nullable: false),
                    ServiceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingCoursess",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tittle = table.Column<string>(maxLength: 50, nullable: false),
                    Descreption = table.Column<string>(maxLength: 5000, nullable: true),
                    img = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCoursess", x => x.Id);
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
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UserTypeId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    ChangePassword = table.Column<bool>(nullable: false),
                    ExtraDetails = table.Column<string>(nullable: true),
                    TempPassword = table.Column<string>(nullable: true),
                    LastPasswordChage = table.Column<DateTime>(nullable: true),
                    LastPasswordChangeBy = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgramsFEs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tittle = table.Column<string>(maxLength: 50, nullable: false),
                    Descreption = table.Column<string>(maxLength: 500, nullable: true),
                    img = table.Column<string>(nullable: true),
                    ProgramsCategoryFEId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramsFEs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramsFEs_ProgramsCategoryFEs_ProgramsCategoryFEId",
                        column: x => x.ProgramsCategoryFEId,
                        principalTable: "ProgramsCategoryFEs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    TrainerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branch_Trainer_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    TrainerInsentive = table.Column<string>(nullable: true),
                    NightTrainerInsentive = table.Column<string>(nullable: true),
                    ServiceTypeId = table.Column<Guid>(nullable: false),
                    languageId = table.Column<Guid>(nullable: false),
                    SessionTimeId = table.Column<Guid>(nullable: false),
                    TrainerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_ServiceType_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_SessionTime_SessionTimeId",
                        column: x => x.SessionTimeId,
                        principalTable: "SessionTime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Service_Trainer_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Service_Language_languageId",
                        column: x => x.languageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    NationalID = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    InSchool = table.Column<bool>(nullable: false),
                    SchoolName = table.Column<string>(nullable: true),
                    SchoolYear = table.Column<string>(nullable: true),
                    GotAJobPlacement = table.Column<bool>(nullable: false),
                    JopType = table.Column<string>(nullable: true),
                    JopPlace = table.Column<string>(nullable: true),
                    JopAdress = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    SecondName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    ParentPhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberForWatsapp = table.Column<string>(nullable: true),
                    LandPhoneNumber = table.Column<string>(nullable: true),
                    EducationQualification = table.Column<string>(nullable: true),
                    JopTitle = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MotherFirstName = table.Column<string>(nullable: true),
                    MotherSecondName = table.Column<string>(maxLength: 50, nullable: true),
                    MotherLastName = table.Column<string>(maxLength: 50, nullable: true),
                    MotherPhoneNumber = table.Column<string>(nullable: true),
                    MotherEducationQualification = table.Column<string>(nullable: true),
                    MotherJopTitle = table.Column<string>(nullable: true),
                    FirstBrotherOrSisterName = table.Column<string>(nullable: true),
                    FirstBrotherOrSisterPhoneNumber = table.Column<string>(nullable: true),
                    FirstBrotherOrSisterNationalID = table.Column<string>(nullable: true),
                    SecondBrotherOrSisterName = table.Column<string>(nullable: true),
                    SecondBrotherOrSisterPhoneNumber = table.Column<string>(nullable: true),
                    SecondBrotherOrSisterNationalID = table.Column<string>(nullable: true),
                    ThirdBrotherOrSisterName = table.Column<string>(nullable: true),
                    ThirdBrotherOrSisterPhoneNumber = table.Column<string>(nullable: true),
                    ThirdBrotherOrSisterNationalID = table.Column<string>(nullable: true),
                    ForthBrotherOrSisterName = table.Column<string>(nullable: true),
                    ForthBrotherOrSisterPhoneNumber = table.Column<string>(nullable: true),
                    ForthBrotherOrSisterNationalID = table.Column<string>(nullable: true),
                    FifthBrotherOrSisterName = table.Column<string>(nullable: true),
                    FifthBrotherOrSisterPhoneNumber = table.Column<string>(nullable: true),
                    FifthBrotherOrSisterNationalID = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "CoursePrices",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ServiceId = table.Column<Guid>(nullable: true),
                    StudentNationalityId = table.Column<Guid>(nullable: true),
                    BranchId = table.Column<Guid>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoursePrices_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoursePrices_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoursePrices_StudentNationalities_StudentNationalityId",
                        column: x => x.StudentNationalityId,
                        principalTable: "StudentNationalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SessionReservation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    coursePriceId = table.Column<Guid>(nullable: true),
                    StudentId = table.Column<int>(nullable: true),
                    TrainerId = table.Column<Guid>(nullable: true),
                    SessionDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionReservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionReservation_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SessionReservation_Trainer_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SessionReservation_CoursePrices_coursePriceId",
                        column: x => x.coursePriceId,
                        principalTable: "CoursePrices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branch_TrainerId",
                table: "Branch",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePrices_BranchId",
                table: "CoursePrices",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePrices_ServiceId",
                table: "CoursePrices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursePrices_StudentNationalityId",
                table: "CoursePrices",
                column: "StudentNationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramsFEs_ProgramsCategoryFEId",
                table: "ProgramsFEs",
                column: "ProgramsCategoryFEId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ServiceTypeId",
                table: "Service",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_SessionTimeId",
                table: "Service",
                column: "SessionTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_TrainerId",
                table: "Service",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_languageId",
                table: "Service",
                column: "languageId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionReservation_StudentId",
                table: "SessionReservation",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionReservation_TrainerId",
                table: "SessionReservation",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionReservation_coursePriceId",
                table: "SessionReservation",
                column: "coursePriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TypeOfDisabilityId",
                table: "Students",
                column: "TypeOfDisabilityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscriptionLists");

            migrationBuilder.DropTable(
                name: "ProgramsFEs");

            migrationBuilder.DropTable(
                name: "ProjectsFEs");

            migrationBuilder.DropTable(
                name: "SessionReservation");

            migrationBuilder.DropTable(
                name: "StudentParent");

            migrationBuilder.DropTable(
                name: "TrainingCoursess");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ProgramsCategoryFEs");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "CoursePrices");

            migrationBuilder.DropTable(
                name: "TypeOfDisability");

            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "StudentNationalities");

            migrationBuilder.DropTable(
                name: "ServiceType");

            migrationBuilder.DropTable(
                name: "SessionTime");

            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.DropTable(
                name: "Language");
        }
    }
}
