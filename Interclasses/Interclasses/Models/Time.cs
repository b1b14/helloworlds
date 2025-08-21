using System.ComponentModel.DataAnnotations;

namespace Interclasses.Models
{
    public class Time
    {
        public int TimeId { get; set; }
        [Required(ErrorMessage = "O campo Nome do Time é obrigatório ")]
        [MaxLength(50, ErrorMessage = "O nome do Time pode ter, no máximo, 50 caracteres")]
        [Display(Name = "Nome do Time")]
        public string? Nome { get; set; }
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; }

        public Esporte? Esporte { get; set; }



    }

}
