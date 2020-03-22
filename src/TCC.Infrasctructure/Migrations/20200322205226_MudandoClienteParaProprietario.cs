using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TCC.Infrasctructure.Migrations
{
    public partial class MudandoClienteParaProprietario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Cliente_ClienteId",
                table: "Veiculo");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Veiculo",
                newName: "ProprietarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_ClienteId",
                table: "Veiculo",
                newName: "IX_Veiculo_ProprietarioId");

            migrationBuilder.CreateTable(
                name: "Proprietario",
                columns: table => new
                {
                    ProprietarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietario", x => x.ProprietarioId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Proprietario_ProprietarioId",
                table: "Veiculo",
                column: "ProprietarioId",
                principalTable: "Proprietario",
                principalColumn: "ProprietarioId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Proprietario_ProprietarioId",
                table: "Veiculo");

            migrationBuilder.DropTable(
                name: "Proprietario");

            migrationBuilder.RenameColumn(
                name: "ProprietarioId",
                table: "Veiculo",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Veiculo_ProprietarioId",
                table: "Veiculo",
                newName: "IX_Veiculo_ClienteId");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Cliente_ClienteId",
                table: "Veiculo",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
