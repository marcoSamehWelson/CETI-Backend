using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class add_training_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobFEs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tittle = table.Column<string>(maxLength: 50, nullable: false),
                    Descreption = table.Column<string>(maxLength: 5000, nullable: true),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobFEs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingFEs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Tittle = table.Column<string>(maxLength: 50, nullable: false),
                    Descreption = table.Column<string>(maxLength: 5000, nullable: true),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingFEs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobFEs");

            migrationBuilder.DropTable(
                name: "TrainingFEs");
        }
    }
}
