using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessManager.DataLeyer.Migrations
{
    public partial class allowNullIdParentInMoshtaris : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdParent",
                table: "Moshtaris",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdParent",
                table: "Moshtaris",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
