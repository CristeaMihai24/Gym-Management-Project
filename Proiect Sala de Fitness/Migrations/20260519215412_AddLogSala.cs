using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Sala_de_Fitness.Migrations
{
    public partial class AddLogSala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogSala",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembruID = table.Column<int>(nullable: false),
                    TipEveniment = table.Column<byte>(nullable: false),
                    DataOra = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogSala", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LogSala_Membri_MembruID",
                        column: x => x.MembruID,
                        principalTable: "Membri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LogSala_MembruID",
                table: "LogSala",
                column: "MembruID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogSala");
        }
    }
}
