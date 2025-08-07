using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace atividade1
{

    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        public int Acelerar(int Valor)
        {
            if (Valor > 0)
            {
                Velocidade += Valor;
            }
            return Velocidade;
        }

        public int Desacelerar(int Valor)
        {
            if (Valor > 0)
            {
                Velocidade -= Valor;
            }
            return Velocidade;
        }

    }
}
