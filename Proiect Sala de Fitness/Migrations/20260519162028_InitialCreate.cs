using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Sala_de_Fitness.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Antrenori",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    Specializare = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    NumarTelefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antrenori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Membri",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NumarTelefon = table.Column<string>(nullable: true),
                    DataInscriere = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Abonamente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembruId = table.Column<int>(nullable: false),
                    Tip = table.Column<int>(nullable: false),
                    Pret = table.Column<decimal>(nullable: false),
                    DataStart = table.Column<DateTime>(nullable: false),
                    DataExpirare = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonamente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Abonamente_Membri_MembruId",
                        column: x => x.MembruId,
                        principalTable: "Membri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervari",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembruId = table.Column<int>(nullable: false),
                    AntrenorId = table.Column<int>(nullable: false),
                    DataOraIncepere = table.Column<DateTime>(nullable: false),
                    TipRezervare = table.Column<int>(nullable: false),
                    Durata = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezervari_Antrenori_AntrenorId",
                        column: x => x.AntrenorId,
                        principalTable: "Antrenori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervari_Membri_MembruId",
                        column: x => x.MembruId,
                        principalTable: "Membri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abonamente_MembruId",
                table: "Abonamente",
                column: "MembruId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervari_AntrenorId",
                table: "Rezervari",
                column: "AntrenorId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervari_MembruId",
                table: "Rezervari",
                column: "MembruId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abonamente");

            migrationBuilder.DropTable(
                name: "Rezervari");

            migrationBuilder.DropTable(
                name: "Antrenori");

            migrationBuilder.DropTable(
                name: "Membri");
        }
    }
}
