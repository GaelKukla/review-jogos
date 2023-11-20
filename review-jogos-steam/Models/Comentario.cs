using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;

public class Comentario
{
    [Key]
    public int IdComentario { get; set; }
    public int? AvaliacaoId { get; set; }
    public Avaliacao? Avaliacao { get; set; }
    public string? Coment { get; set; }
}