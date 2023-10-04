using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace review_jogos_steam.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoDesenvolvedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuario",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Desenvolvedor",
                newName: "IdDesenvolvedor");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Usuario",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Usuario",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Desenvolvedor",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Desenvolvedor");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Usuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdDesenvolvedor",
                table: "Desenvolvedor",
                newName: "Id");
        }
    }
}
