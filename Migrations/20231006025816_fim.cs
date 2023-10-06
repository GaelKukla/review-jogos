using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace review_jogos_steam.Migrations
{
    /// <inheritdoc />
    public partial class fim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Avaliacao",
                table: "Avaliacao");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tag",
                newName: "IdTag");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Imagem",
                newName: "IdImagem");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Avaliacao",
                newName: "Nota");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Tag",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "JogoId",
                table: "Tag",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Tag",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DevIdDesenvolvedor",
                table: "Jogo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GenIdGenero",
                table: "Jogo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Jogo",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlatIdPlataforma",
                table: "Jogo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "imgIdImagem",
                table: "Jogo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Imagem",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "JogoId",
                table: "Conquista",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JogoId",
                table: "Comentario",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Nota",
                table: "Avaliacao",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "IdAvaliacao",
                table: "Avaliacao",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Avaliacao",
                table: "Avaliacao",
                column: "IdAvaliacao");

            migrationBuilder.CreateIndex(
                name: "IX_Tag_JogoId",
                table: "Tag",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_DevIdDesenvolvedor",
                table: "Jogo",
                column: "DevIdDesenvolvedor");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_GenIdGenero",
                table: "Jogo",
                column: "GenIdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_imgIdImagem",
                table: "Jogo",
                column: "imgIdImagem");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_PlatIdPlataforma",
                table: "Jogo",
                column: "PlatIdPlataforma");

            migrationBuilder.CreateIndex(
                name: "IX_Conquista_JogoId",
                table: "Conquista",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_JogoId",
                table: "Comentario",
                column: "JogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentario_Jogo_JogoId",
                table: "Comentario",
                column: "JogoId",
                principalTable: "Jogo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Conquista_Jogo_JogoId",
                table: "Conquista",
                column: "JogoId",
                principalTable: "Jogo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogo_Desenvolvedor_DevIdDesenvolvedor",
                table: "Jogo",
                column: "DevIdDesenvolvedor",
                principalTable: "Desenvolvedor",
                principalColumn: "IdDesenvolvedor");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogo_Genero_GenIdGenero",
                table: "Jogo",
                column: "GenIdGenero",
                principalTable: "Genero",
                principalColumn: "IdGenero");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogo_Imagem_imgIdImagem",
                table: "Jogo",
                column: "imgIdImagem",
                principalTable: "Imagem",
                principalColumn: "IdImagem",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogo_Plataforma_PlatIdPlataforma",
                table: "Jogo",
                column: "PlatIdPlataforma",
                principalTable: "Plataforma",
                principalColumn: "IdPlataforma");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Jogo_JogoId",
                table: "Tag",
                column: "JogoId",
                principalTable: "Jogo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentario_Jogo_JogoId",
                table: "Comentario");

            migrationBuilder.DropForeignKey(
                name: "FK_Conquista_Jogo_JogoId",
                table: "Conquista");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogo_Desenvolvedor_DevIdDesenvolvedor",
                table: "Jogo");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogo_Genero_GenIdGenero",
                table: "Jogo");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogo_Imagem_imgIdImagem",
                table: "Jogo");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogo_Plataforma_PlatIdPlataforma",
                table: "Jogo");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Jogo_JogoId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_JogoId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Jogo_DevIdDesenvolvedor",
                table: "Jogo");

            migrationBuilder.DropIndex(
                name: "IX_Jogo_GenIdGenero",
                table: "Jogo");

            migrationBuilder.DropIndex(
                name: "IX_Jogo_imgIdImagem",
                table: "Jogo");

            migrationBuilder.DropIndex(
                name: "IX_Jogo_PlatIdPlataforma",
                table: "Jogo");

            migrationBuilder.DropIndex(
                name: "IX_Conquista_JogoId",
                table: "Conquista");

            migrationBuilder.DropIndex(
                name: "IX_Comentario_JogoId",
                table: "Comentario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Avaliacao",
                table: "Avaliacao");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "JogoId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "DevIdDesenvolvedor",
                table: "Jogo");

            migrationBuilder.DropColumn(
                name: "GenIdGenero",
                table: "Jogo");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Jogo");

            migrationBuilder.DropColumn(
                name: "PlatIdPlataforma",
                table: "Jogo");

            migrationBuilder.DropColumn(
                name: "imgIdImagem",
                table: "Jogo");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Imagem");

            migrationBuilder.DropColumn(
                name: "JogoId",
                table: "Conquista");

            migrationBuilder.DropColumn(
                name: "JogoId",
                table: "Comentario");

            migrationBuilder.DropColumn(
                name: "IdAvaliacao",
                table: "Avaliacao");

            migrationBuilder.RenameColumn(
                name: "IdTag",
                table: "Tag",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdImagem",
                table: "Imagem",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Nota",
                table: "Avaliacao",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Avaliacao",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Avaliacao",
                table: "Avaliacao",
                column: "Id");
        }
    }
}
