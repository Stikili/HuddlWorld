using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Huddl.Data.Migrations
{
    public partial class FixtureSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FixtureSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Fixture = table.Column<string>(nullable: false),
                    Sport = table.Column<string>(nullable: false),
                    League = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixtureSchedule", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FixtureSchedule");
        }
    }
}
