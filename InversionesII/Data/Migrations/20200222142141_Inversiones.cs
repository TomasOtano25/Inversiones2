using Microsoft.EntityFrameworkCore.Migrations;

namespace InversionesII.Data.Migrations
{
    public partial class Inversiones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Inversions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Clientes",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inversions_ClienteId",
                table: "Inversions",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inversions_Clientes_ClienteId",
                table: "Inversions",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inversions_Clientes_ClienteId",
                table: "Inversions");

            migrationBuilder.DropIndex(
                name: "IX_Inversions_ClienteId",
                table: "Inversions");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Inversions");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Clientes");
        }
    }
}
