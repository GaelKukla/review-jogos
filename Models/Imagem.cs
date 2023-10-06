// Feito pelo GPT

using System.ComponentModel.DataAnnotations;

namespace review_jogos_steam.Models
{
    public class Imagem
    {
        [Key]
        public int IdImagem { get; set; }
        public string Url { get; set; }
    }
}
