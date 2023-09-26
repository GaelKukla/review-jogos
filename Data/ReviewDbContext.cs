using review_jogos_steam.Models;
using Microsoft.EntityFrameworkCore;

namespace review_jogos_steam.Data;

public class ReviewDbContext : DbContext
{
    public DbSet<Avaliacao>? Avaliacao { get; set; }
    public DbSet<Comentario>? Comentario { get; set; }
    public DbSet<Conquista>? Conquista { get; set; }
    public DbSet<Desenvolvedor>? Desenvolvedor { get; set; }
    public DbSet<Genero>? Genero { get; set; }
    public DbSet<Imagem>? Imagem { get; set; }
    public DbSet<Plataforma>? Plataforma { get; set; }
    public DbSet<Tag>? Tag { get; set; }
    public DbSet<Usuario>? Usuario { get; set; }
    public DbSet<Jogo>? Jogo { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=review_steam.db;Cache=Shared");
    }

}