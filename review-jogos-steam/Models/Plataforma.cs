using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;

public class Plataforma
{
    [Key]
    public int IdPlataforma { get; set; }
    public string? Tipo { get; set; }
    public string? Descricao { get; set; }
    public List<Jogo>? Jogos {get; set;}
}
