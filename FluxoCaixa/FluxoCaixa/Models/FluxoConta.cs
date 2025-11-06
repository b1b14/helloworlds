namespace FluxoCaixa.Models
{
    public class FluxoConta
    {
        public int FluxoContaId { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public int ContaId { get; set; }
        public int ContaFinanceiraId { get; set; }
        public int UsuarioId { get; set; }
    }
}
