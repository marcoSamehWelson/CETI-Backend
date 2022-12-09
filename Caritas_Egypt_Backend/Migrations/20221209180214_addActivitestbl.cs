using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class addActivitestbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivitiesAndEventsFEs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tittle = table.Column<string>(maxLength: 50, nullable: false),
                    Descreption = table.Column<string>(maxLength: 5000, nullable: true),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesAndEventsFEs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingCoursess_branchId",
                table: "TrainingCoursess",
                column: "branchId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingCoursess_Branch_branchId",
                table: "TrainingCoursess",
                column: "branchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingCoursess_Branch_branchId",
                table: "TrainingCoursess");

            migrationBuilder.DropTable(
                name: "ActivitiesAndEventsFEs");

            migrationBuilder.DropIndex(
                name: "IX_TrainingCoursess_branchId",
                table: "TrainingCoursess");
        }
    }
}
