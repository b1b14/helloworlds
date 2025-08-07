using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjeto
{
    public class Professor : Pessoa
    {
        public string? Especialidade { get; set; }
        public int? Registro { get; set; }
        public double Salario { get; set; }

        public void Apresentar()
        {
            base.Apresetar();
            Console.WriteLine($"Sou especialista  em {Especialidade}, meu registro é {Registro} e meu salário é {Salario}");
        }
    }
}
