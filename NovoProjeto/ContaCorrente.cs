using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjeto
{
    public class ContaCorrente : ContaGenerica
    {


        public ContaCorrente(string banco, int agencia, int conta, decimal saldo, decimal limite)
            : base(banco, agencia, conta, saldo)
        {
            this.Limite = limite;
        }
        public decimal Limite { get; private set; }
    }
}
