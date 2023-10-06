// Parte feita pelo GPT

using System.ComponentModel.DataAnnotations;

namespace review_jogos_steam.Models
{
    public class Tag
    {
        [Key]
        public int IdTag { get; set; } // Identificador único da tag
        public string Nome { get; set; } // Nome da tag
        public string Descricao { get; set; } // Descrição da tag
    }
}