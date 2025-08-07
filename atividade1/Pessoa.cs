using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    public class Pessoa(string nome, int idade)
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Envelhecer(int anos)
        {
            Idade += anos;
            Console.WriteLine($"{Nome} envelheceu {anos} ano(s) e agora tem {Idade} anos,");
        }
    }
}
