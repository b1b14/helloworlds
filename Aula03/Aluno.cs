using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03
{
    public class Aluno
    {
        public Aluno(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }

        public int codigo { get; set; }
        public string? nome { get; set; }
    }
}
