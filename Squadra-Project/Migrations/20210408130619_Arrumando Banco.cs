using Microsoft.EntityFrameworkCore.Migrations;

namespace Squadra_Project.Migrations
{
    public partial class ArrumandoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "carro",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "carro",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Cor",
                table: "carro",
                newName: "cor");

            migrationBuilder.RenameColumn(
                name: "Ano",
                table: "carro",
                newName: "ano");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "carro",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "valor",
                table: "carro",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "carro",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "cor",
                table: "carro",
                newName: "Cor");

            migrationBuilder.RenameColumn(
                name: "ano",
                table: "carro",
                newName: "Ano");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "carro",
                newName: "Id");
        }
    }
}
