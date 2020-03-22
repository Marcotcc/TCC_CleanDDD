using Microsoft.EntityFrameworkCore.Migrations;

namespace TCC.Infrasctructure.Migrations
{
    public partial class InserindoCpfCnpjNoProprietario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CpfCnpj",
                table: "Proprietario",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CpfCnpj",
                table: "Proprietario");
        }
    }
}
