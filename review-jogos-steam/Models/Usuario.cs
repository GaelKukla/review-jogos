using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;

public class Usuario
{
    [Key]
    public int IdUsuario { get; set; }
    public string? Nome { get; set; }
    public string? Senha { get; set; }

    public List<Avaliacao>? Avaliacoes {get;  set;}
}