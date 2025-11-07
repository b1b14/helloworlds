using System.ComponentModel.DataAnnotations;

namespace FluxoCaixa.Models
{
    public class FluxoConta
    {

        public int FluxoContaId { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string StatusPagamento { get; set; }
    }
}
