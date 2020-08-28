using Microsoft.EntityFrameworkCore.Migrations;

namespace Huddl.Data.Migrations
{
    public partial class AddMerchantEstablishmentToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MerchantEstablishment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstablishmentName = table.Column<string>(nullable: false),
                    EstablishmentAddress = table.Column<string>(nullable: false),
                    TeamAffiliate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantEstablishment", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MerchantEstablishment");
        }
    }
}
