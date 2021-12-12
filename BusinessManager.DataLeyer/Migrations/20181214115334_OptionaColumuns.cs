using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessManager.DataLeyer.Migrations
{
    public partial class OptionaColumuns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Moshtaris",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "Mobail",
                table: "Moshtaris",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Moshtaris",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telephone",
                table: "Moshtaris",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mobail",
                table: "Moshtaris",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Moshtaris",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
