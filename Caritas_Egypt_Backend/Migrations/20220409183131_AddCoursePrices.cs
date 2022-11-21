using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class AddCoursePrices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainer_Branch_BranchId",
                table: "Trainer");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainer_Service_ServiceId",
                table: "Trainer");

            migrationBuilder.DropIndex(
                name: "IX_Trainer_BranchId",
                table: "Trainer");

            migrationBuilder.DropIndex(
                name: "IX_Trainer_ServiceId",
                table: "Trainer");

            migrationBuilder.AlterColumn<Guid>(
                name: "ServiceId",
                table: "Trainer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BranchId",
                table: "Trainer",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TrainerId",
                table: "Service",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TrainerId",
                table: "Branch",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Service_TrainerId",
                table: "Service",
                column: "TrainerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_Trainer_TrainerId",
                table: "Branch",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Trainer_TrainerId",
                table: "Service",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branch_Trainer_TrainerId",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Trainer_TrainerId",
                table: "Service");

            migrationBuilder.DropTable(
                name: "CoursePrices");

            migrationBuilder.DropTable(
                name: "StudentNationalities");

            migrationBuilder.DropIndex(
                name: "IX_Service_TrainerId",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Branch_TrainerId",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Branch");

            migrationBuilder.AlterColumn<Guid>(
                name: "ServiceId",
                table: "Trainer",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "BranchId",
                table: "Trainer",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.CreateIndex(
                name: "IX_Trainer_BranchId",
                table: "Trainer",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainer_ServiceId",
                table: "Trainer",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainer_Branch_BranchId",
                table: "Trainer",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainer_Service_ServiceId",
                table: "Trainer",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
