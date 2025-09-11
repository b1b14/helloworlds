namespace AgendasMedicas.Models
{
    public class Medico
    {
        public Guid MedicoId { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }

        public string Celular { get; set; }


        //
        public Guid EspecialidadeId { get; set; }

        public Especialidade? Especialidade { get; set; }
    }
}
