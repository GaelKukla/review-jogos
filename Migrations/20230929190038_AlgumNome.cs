using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace review_jogos_steam.Migrations
{
    /// <inheritdoc />
    public partial class AlgumNome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Plataforma",
                table: "Plataforma");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comentario",
                table: "Comentario");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genero",
                newName: "IdGenero");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Conquista",
                newName: "IdConquista");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comentario",
                newName: "IdUsuario");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Plataforma",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "IdPlataforma",
                table: "Plataforma",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Genero",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Genero",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Conquista",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Conquista",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "Comentario",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "IdComentario",
                table: "Comentario",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Coment",
                table: "Comentario",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdJogo",
                table: "Comentario",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plataforma",
                table: "Plataforma",
                column: "IdPlataforma");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comentario",
                table: "Comentario",
                column: "IdComentario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Plataforma",
                table: "Plataforma");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comentario",
                table: "Comentario");

            migrationBuilder.DropColumn(
                name: "IdPlataforma",
                table: "Plataforma");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Genero");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Genero");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Conquista");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Conquista");

            migrationBuilder.DropColumn(
                name: "IdComentario",
                table: "Comentario");

            migrationBuilder.DropColumn(
                name: "Coment",
                table: "Comentario");

            migrationBuilder.DropColumn(
                name: "IdJogo",
                table: "Comentario");

            migrationBuilder.RenameColumn(
                name: "IdGenero",
                table: "Genero",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdConquista",
                table: "Conquista",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Comentario",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Plataforma",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Comentario",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plataforma",
                table: "Plataforma",
                column: "Tipo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comentario",
                table: "Comentario",
                column: "Id");
        }
    }
}
