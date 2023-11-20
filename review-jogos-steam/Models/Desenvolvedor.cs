using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;

public class Desenvolvedor
{
    [Key]
    public int IdDesenvolvedor { get; set; }
    public string? Nome { get; set; }
    public List<Jogo>? Jogos { get; set; }
}