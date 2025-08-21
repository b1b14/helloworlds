using System.ComponentModel.DataAnnotations;

namespace Interclasses.Models
{
    public class Esporte
    {
        public int EsporteId { get; set; }

        [Required(ErrorMessage = " O nome do Esporte é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome do Esporte pode ter, no máximo, 50 caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a quantidade máxima de Jogadores por time")]
        [Range(1, 125, ErrorMessage = "A quantidade de jogadores deve ser entre 1 e 25")]

        [Display(Name = "Quantidade de Jogadores")]
        public string QtdJogadores { get; set; }

    }
}
