using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }


        [Required(ErrorMessage = "O nome do produto é obrigatório.")]// Indica que o campo é obrigatório
        [StringLength(100, ErrorMessage = "O nome do produto não pode ter mais de 100 catacteres.")]
        [Display(Name = "Nome do Produto")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A marca do produto é obrigatório.")]// Indica que o campo é obrigatório
        [StringLength(100, ErrorMessage = "A marca do produto não pode ter mais de 100 catacteres.")]
        [Display(Name = "Marca")]
        public string? Marca { get; set; }

        //relaicionamento com a categoria(Chave Estrangeira)

        [Required(ErrorMessage = "A categoria é obrigatória")]
        [Display(Name = "Nome da categoria")]
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }// Calsse que pertence ao Id estrangeira

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = " O estoque Atual não pode ser negativo")]
        [Display(Name = "Estoque Atual")]
        public int EstoqueAtual { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = " O estoque Mínimo não pode ser negativo")]
        [Display(Name = "Estoque Mínimo")]
        public int EstoqueMinimo { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Informe uma data válida.")]
        [Display(Name = "Data de Validade")]
        public DateTime? DataValidade { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço de Custo")]
        public decimal? PrecoCusto { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço de Venda")]
        public decimal? PrecoVenda { get; set; }

        [Display(Name = "Descrição Detalhada")]
        [DataType(DataType.MultilineText)]
        public string? Descricao { get; set; }
    }
}
