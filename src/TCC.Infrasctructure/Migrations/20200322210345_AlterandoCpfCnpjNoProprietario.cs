using Microsoft.EntityFrameworkCore.Migrations;

namespace TCC.Infrasctructure.Migrations
{
    public partial class AlterandoCpfCnpjNoProprietario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CpfCnpj",
                table: "Proprietario",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CpfCnpj",
                table: "Proprietario",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
