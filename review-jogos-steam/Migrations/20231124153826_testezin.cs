using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace review_jogos_steam.Migrations
{
    /// <inheritdoc />
    public partial class testezin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conquista_Jogo_JogoId",
                table: "Conquista");

            migrationBuilder.DropForeignKey(
                name: "FK_JogoTag_Jogo_JogoId",
                table: "JogoTag");

            migrationBuilder.RenameColumn(
                name: "JogoId",
                table: "JogoTag",
                newName: "JogoIdJogo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Jogo",
                newName: "IdJogo");

            migrationBuilder.RenameColumn(
                name: "JogoId",
                table: "Conquista",
                newName: "JogoIdJogo");

            migrationBuilder.RenameIndex(
                name: "IX_Conquista_JogoId",
                table: "Conquista",
                newName: "IX_Conquista_JogoIdJogo");

            migrationBuilder.AddForeignKey(
                name: "FK_Conquista_Jogo_JogoIdJogo",
                table: "Conquista",
                column: "JogoIdJogo",
                principalTable: "Jogo",
                principalColumn: "IdJogo");

            migrationBuilder.AddForeignKey(
                name: "FK_JogoTag_Jogo_JogoIdJogo",
                table: "JogoTag",
                column: "JogoIdJogo",
                principalTable: "Jogo",
                principalColumn: "IdJogo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conquista_Jogo_JogoIdJogo",
                table: "Conquista");

            migrationBuilder.DropForeignKey(
                name: "FK_JogoTag_Jogo_JogoIdJogo",
                table: "JogoTag");

            migrationBuilder.RenameColumn(
                name: "JogoIdJogo",
                table: "JogoTag",
                newName: "JogoId");

            migrationBuilder.RenameColumn(
                name: "IdJogo",
                table: "Jogo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "JogoIdJogo",
                table: "Conquista",
                newName: "JogoId");

            migrationBuilder.RenameIndex(
                name: "IX_Conquista_JogoIdJogo",
                table: "Conquista",
                newName: "IX_Conquista_JogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conquista_Jogo_JogoId",
                table: "Conquista",
                column: "JogoId",
                principalTable: "Jogo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JogoTag_Jogo_JogoId",
                table: "JogoTag",
                column: "JogoId",
                principalTable: "Jogo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
