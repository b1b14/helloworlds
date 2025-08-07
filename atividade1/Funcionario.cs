using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{
    public class Funcionario(string nome, int idade, string cargo) : Pessoa(nome, idade)
    {
        public string Cargo { get; set; } = cargo;

        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome} | Idade: {Idade} | Cargo: {Cargo}");
        }
    }
}
