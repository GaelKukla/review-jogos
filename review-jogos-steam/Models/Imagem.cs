using System.ComponentModel.DataAnnotations;
namespace review_jogos_steam.Models;
using review_jogos_steam.Models;

    public class Imagem
    {
        [Key]
        public int IdImagem { get; set; }
        public string? Url { get; set; }
        public int? JogoId { get; set; }
        public Jogo? Jogo { get; set; }
    }

