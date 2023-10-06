using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;
using review_jogos_steam.Models;

public class Jogo
{
    [Key]
    public int Id { get; set; }

    public string? Nome{get; set;}

    public Desenvolvedor? Dev { get; set; }

    public Genero? Gen{get; set;}

    public List<Conquista>? Conq { get; set; }

    public Plataforma? Plat{get;  set;}

    public List<Tag>? Tags{get;  set;}

    public Imagem img{get;  set;}

    public List<Comentario> Comentarios/*Cagol Destruidor*/ {    get;    set;}


}