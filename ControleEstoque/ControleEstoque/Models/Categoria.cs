using System.ComponentModel.DataAnnotations;

namespace ControleEstoque.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "O nome da categioria é obrigatório.")]// Indica que o campo é obrigatório
        [StringLength(100, ErrorMessage = "O nome da categioria não pode ter mais de 100 catacteres.")]
        [Display(Name = "Nome da categioria")]
        public string? Nome { get; set; }
    }
}
