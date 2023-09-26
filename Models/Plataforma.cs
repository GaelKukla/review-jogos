using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;

public class Plataforma
{
    [Key]
    public string? Tipo { get; set; }
    public string? Descricao { get; set; }
}
