namespace AppTarefas.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}
