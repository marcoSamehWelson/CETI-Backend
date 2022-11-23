using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class addSessionReservationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SessionReservation");
        }
    }
}
