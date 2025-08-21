using System.ComponentModel.DataAnnotations;

namespace Interclasses.Models
{
    public class Campeonato
    {
        [Required(ErrorMessage = "O campo Nome do Campeonato é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome do Campeonato pode ter, no máximo, 50 caracteres")]
        [Display(Name = "Nome do Campeonato")]
        public string? Nome { get; set; }

        //relacionamento
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; }
        public Esporte? Esporte { get; set; }
    }
}
