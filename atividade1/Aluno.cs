using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    public class Aluno
    {
        public int rm { get; set; }
        public required string nome { get; set; }
        public DateTime nascimento { get; set; }
        public string? email { get; set; }
    }
}

