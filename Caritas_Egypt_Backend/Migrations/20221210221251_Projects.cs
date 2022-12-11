using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class Projects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProjectsCategoryFEId",
                table: "ProjectsFEs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectsCategoryFEs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tittle = table.Column<string>(maxLength: 50, nullable: false),
                    Descreption = table.Column<string>(maxLength: 5000, nullable: true),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectsCategoryFEs", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectsFEs_ProjectsCategoryFEId",
                table: "ProjectsFEs",
                column: "ProjectsCategoryFEId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectsFEs_ProjectsCategoryFEs_ProjectsCategoryFEId",
                table: "ProjectsFEs",
                column: "ProjectsCategoryFEId",
                principalTable: "ProjectsCategoryFEs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectsFEs_ProjectsCategoryFEs_ProjectsCategoryFEId",
                table: "ProjectsFEs");

            migrationBuilder.DropTable(
                name: "ProjectsCategoryFEs");

            migrationBuilder.DropIndex(
                name: "IX_ProjectsFEs_ProjectsCategoryFEId",
                table: "ProjectsFEs");

            migrationBuilder.DropColumn(
                name: "ProjectsCategoryFEId",
                table: "ProjectsFEs");
        }
    }
}
