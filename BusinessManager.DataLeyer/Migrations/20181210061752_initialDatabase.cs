using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusinessManager.DataLeyer.Migrations
{
    public partial class initialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Frooshandes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Telephone = table.Column<string>(maxLength: 12, nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frooshandes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moshtaris",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Radif = table.Column<int>(nullable: false),
                    Nam = table.Column<string>(maxLength: 200, nullable: false),
                    Family = table.Column<string>(maxLength: 200, nullable: false),
                    IdParent = table.Column<int>(nullable: false),
                    Telephone = table.Column<string>(maxLength: 12, nullable: false),
                    Mobail = table.Column<string>(maxLength: 12, nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moshtaris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HesabFrooshandes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdFrooshande = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Meghdar = table.Column<string>(maxLength: 50, nullable: false),
                    BaghiMande = table.Column<string>(maxLength: 50, nullable: false),
                    ShomareFaktor = table.Column<string>(maxLength: 50, nullable: false),
                    FrooshandeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HesabFrooshandes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HesabFrooshandes_Frooshandes_FrooshandeId",
                        column: x => x.FrooshandeId,
                        principalTable: "Frooshandes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "hesabMoshtaris",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MoshtariId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    dateShamsi = table.Column<string>(nullable: false),
                    Description = table.Column<int>(nullable: false),
                    Debtor = table.Column<string>(maxLength: 50, nullable: false),
                    Creditor = table.Column<string>(maxLength: 50, nullable: false),
                    Remaining = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hesabMoshtaris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hesabMoshtaris_Moshtaris_MoshtariId",
                        column: x => x.MoshtariId,
                        principalTable: "Moshtaris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RizKharids",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdHesabFrooshande = table.Column<int>(nullable: false),
                    Radif = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Count = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<string>(maxLength: 50, nullable: false),
                    SalesPrice = table.Column<string>(maxLength: 50, nullable: false),
                    HesabFrooshandeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RizKharids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RizKharids_HesabFrooshandes_HesabFrooshandeId",
                        column: x => x.HesabFrooshandeId,
                        principalTable: "HesabFrooshandes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RizFrooshs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdHesabMoshtari = table.Column<int>(nullable: false),
                    Radif = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    Count = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<string>(maxLength: 50, nullable: false),
                    hesabMoshtariId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RizFrooshs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RizFrooshs_hesabMoshtaris_hesabMoshtariId",
                        column: x => x.hesabMoshtariId,
                        principalTable: "hesabMoshtaris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HesabFrooshandes_FrooshandeId",
                table: "HesabFrooshandes",
                column: "FrooshandeId");

            migrationBuilder.CreateIndex(
                name: "IX_hesabMoshtaris_MoshtariId",
                table: "hesabMoshtaris",
                column: "MoshtariId");

            migrationBuilder.CreateIndex(
                name: "IX_RizFrooshs_hesabMoshtariId",
                table: "RizFrooshs",
                column: "hesabMoshtariId");

            migrationBuilder.CreateIndex(
                name: "IX_RizKharids_HesabFrooshandeId",
                table: "RizKharids",
                column: "HesabFrooshandeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RizFrooshs");

            migrationBuilder.DropTable(
                name: "RizKharids");

            migrationBuilder.DropTable(
                name: "hesabMoshtaris");

            migrationBuilder.DropTable(
                name: "HesabFrooshandes");

            migrationBuilder.DropTable(
                name: "Moshtaris");

            migrationBuilder.DropTable(
                name: "Frooshandes");
        }
    }
}
