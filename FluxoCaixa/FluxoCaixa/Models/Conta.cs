namespace FluxoCaixa.Models
{
    public class Conta
    {
        public int ContaId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal DataVencimento { get; set; }

    }
}
