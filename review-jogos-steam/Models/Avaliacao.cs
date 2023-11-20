using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;
using review_jogos_steam.Models;

public class Avaliacao
{
    [Key]
    public int IdAvaliacao { get; set; }
    public int? JogoID { get; set; }
    public Jogo? Jogo { get; set; }
    public int Nota{get; set;}
    


}