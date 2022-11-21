using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caritas_Egypt_Backend.Migrations
{
    public partial class addUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
