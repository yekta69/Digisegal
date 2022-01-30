using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Digisegal.Migrations
{
    public partial class run : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Nationalcode = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RegisteryDate = table.Column<DateTime>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    IsDelete = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
