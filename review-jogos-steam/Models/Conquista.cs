using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;

public class Conquista
{
    [Key]
    public int IdConquista { get; set; }
    public string? Tipo { get; set; }
    public string? Descricao { get; set; }
}