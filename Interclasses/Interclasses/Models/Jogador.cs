using System.ComponentModel.DataAnnotations;
using Interclasses.Models;

namespace InterClasses.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }


        [Required(ErrorMessage = "O Nome do Jogador é obrigatório.")] //significa que o campo Nome deve ser obrigatório preencher
        [MaxLength(80, ErrorMessage = "O Nome do Jogador pode ter no máximo 80 caracteres.")]

        public string Nome { get; set; }


        [Required(ErrorMessage = "o numero do jogador deve ser obrigatório")]
        [Range(1, 99, ErrorMessage = "O número do jogador deve estar entre 1 e 99.")]
        [Display(Name = "Número")]
        public int Numero { get; set; }

        //relacionamento jogador x time

        [Display(Name = "Time")]
        public int TimeId { get; set; } //vincular o campo do id da tabela
        public Time? Time { get; set; } //vincular o objeto relacionado ao id acima

    }
}
