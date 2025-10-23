using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ControleEstoque.Models
{
    public class Movimentacao
    {
        public int MovimentacaoId { get; set; }

        [Required]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Required]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Tipo de Movimentação")]
        public string? Tipo { get; set; } // "Entrada" ou "Saída"


        [DataType(DataType.Date)]
        [Display(Name = "Data da Movimentação")]
        public DateTime? DataMovimentacao { get; set; }
        //reacionamento com a tabela de usuarios

        [Display(Name = "Usuário")]
        public string? UsuarioId { get; set; }
        public IdentityUser? Usuario { get; set; }

        [Display(Name = "Observação")]
        [DataType(DataType.MultilineText)]
        public string? Observacao { get; set; }
    }
}
