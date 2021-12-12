using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessManager.DataLeyer.Migrations
{
    public partial class hesab_moshtari : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "hesabMoshtaris",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "hesabMoshtaris",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "hesabMoshtaris",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "hesabMoshtaris",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
