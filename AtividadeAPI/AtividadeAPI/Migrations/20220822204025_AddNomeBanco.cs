using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AtividadeAPI.Migrations
{
    public partial class AddNomeBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeBanco",
                table: "Banco",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeBanco",
                table: "Banco");
        }
    }
}
