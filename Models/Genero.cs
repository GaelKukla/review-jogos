using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;

public class Genero
{
    [Key]
    public int IdGenero { get; set; }
    public string? Tipo { get; set; }
    public string? Descricao { get; set; }
}