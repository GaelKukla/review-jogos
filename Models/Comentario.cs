using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;

public class Comentario
{
    [Key]
    public int IdComentario { get; set; }
    public int IdUsuario { get; set; }
    public int IdJogo { get; set; }
    public string? Coment { get; set; }
}