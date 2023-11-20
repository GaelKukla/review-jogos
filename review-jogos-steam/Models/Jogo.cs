using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;
using review_jogos_steam.Models;

public class Jogo
{
    [Key]
    public int Id { get; set; }

    public int? PlataformaId { get; set; }
    public Plataforma? Plataforma {get;  set;}

    public int? DesenvolvedorId { get; set; }
    public Desenvolvedor? Desenvolvedor { get; set; }

    public int? GeneroId { get; set; }
    public Genero? Genero {get; set;}

    public List<Tag>? Tags{get;  set;}
    public List<Avaliacao>? Avaliacoes {get;  set;}
    public List<Conquista>? Conquistas { get; set; }
    public string? Nome{get; set;}

}