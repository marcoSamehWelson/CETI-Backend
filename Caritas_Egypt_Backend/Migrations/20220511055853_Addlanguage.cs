using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class Addlanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NightTrainerInsentive",
                table: "Service",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServiceTypeId",
                table: "Service",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SessionTimeId",
                table: "Service",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "TrainerInsentive",
                table: "Service",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "languageId",
                table: "Service",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ServiceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Language_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ServiceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceType_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SessionTime",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ServiceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SessionTime_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Language_ServiceId",
                table: "Language",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceType_ServiceId",
                table: "ServiceType",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SessionTime_ServiceId",
                table: "SessionTime",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "ServiceType");

            migrationBuilder.DropTable(
                name: "SessionTime");

            migrationBuilder.DropColumn(
                name: "NightTrainerInsentive",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ServiceTypeId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "SessionTimeId",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "TrainerInsentive",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "languageId",
                table: "Service");
        }
    }
}
