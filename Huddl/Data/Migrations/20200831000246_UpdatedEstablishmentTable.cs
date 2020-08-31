using Microsoft.EntityFrameworkCore.Migrations;

namespace Huddl.Data.Migrations
{
    public partial class UpdatedEstablishmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstablishmentAddress",
                table: "MerchantEstablishment");

            migrationBuilder.DropColumn(
                name: "EstablishmentName",
                table: "MerchantEstablishment");

            migrationBuilder.DropColumn(
                name: "TeamAffiliate",
                table: "MerchantEstablishment");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "MerchantEstablishment",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Establishment",
                table: "MerchantEstablishment",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "MerchantEstablishment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "MerchantEstablishment");

            migrationBuilder.DropColumn(
                name: "Establishment",
                table: "MerchantEstablishment");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "MerchantEstablishment");

            migrationBuilder.AddColumn<string>(
                name: "EstablishmentAddress",
                table: "MerchantEstablishment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EstablishmentName",
                table: "MerchantEstablishment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TeamAffiliate",
                table: "MerchantEstablishment",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
