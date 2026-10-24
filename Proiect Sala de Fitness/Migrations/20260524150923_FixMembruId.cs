using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Sala_de_Fitness.Migrations
{
    public partial class FixMembruId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LogSala_Membri_MembruID",
                table: "LogSala");

            migrationBuilder.RenameColumn(
                name: "MembruID",
                table: "LogSala",
                newName: "MembruId");

            migrationBuilder.RenameIndex(
                name: "IX_LogSala_MembruID",
                table: "LogSala",
                newName: "IX_LogSala_MembruId");

            migrationBuilder.AddForeignKey(
                name: "FK_LogSala_Membri_MembruId",
                table: "LogSala",
                column: "MembruId",
                principalTable: "Membri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LogSala_Membri_MembruId",
                table: "LogSala");

            migrationBuilder.RenameColumn(
                name: "MembruId",
                table: "LogSala",
                newName: "MembruID");

            migrationBuilder.RenameIndex(
                name: "IX_LogSala_MembruId",
                table: "LogSala",
                newName: "IX_LogSala_MembruID");

            migrationBuilder.AddForeignKey(
                name: "FK_LogSala_Membri_MembruID",
                table: "LogSala",
                column: "MembruID",
                principalTable: "Membri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
