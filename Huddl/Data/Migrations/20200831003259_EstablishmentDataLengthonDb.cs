using Microsoft.EntityFrameworkCore.Migrations;

namespace Huddl.Data.Migrations
{
    public partial class EstablishmentDataLengthonDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Team",
                table: "MerchantEstablishment",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Establishment",
                table: "MerchantEstablishment",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "MerchantEstablishment",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Team",
                table: "MerchantEstablishment",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Establishment",
                table: "MerchantEstablishment",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "MerchantEstablishment",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
