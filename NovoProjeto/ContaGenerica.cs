using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjeto
{

    public class ContaGenerica
    {
        public string Banco { get; private set; }
        public int Agencia { get; private set; }
        public int Conta { get; private set; }
        public decimal Saldo { get; private set; }

        public ContaGenerica(string banco, int agencia, int conta, decimal saldo)
        {
            Banco = banco;
            Agencia = agencia;
            Conta = conta;
            Saldo = saldo;
        }

        public decimal Sacar(int Valor)
        {
            if (Valor > 0 && Valor <= Saldo)
            {
                Saldo -= Valor;
                return Valor;
            }
            else
            {
                Console.WriteLine("Saque inválido. Verifique o valor e tente novamente.");
                return 0;
            }
        }

        public decimal Depositar(int Valor)
        {
            if (Valor <= 0)
            {
                Console.WriteLine("Depósito inválido. O valor deve ser maior que zero.");
                return 0;
            }
            else
            {
                Saldo += Valor;
                return Valor;
            }

        }
    }
}


