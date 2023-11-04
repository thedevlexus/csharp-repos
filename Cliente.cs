using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    internal class Cliente
    {
        public string nome;
        public double saldo;

        public double depositoSaldo(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Tem coisa errada ai parceiro.");
            }

            saldo += valor;
            return saldo;
        }
        public double saqueSaldo(double valor)
        {
            if (valor <= 0 || saldo <= valor)
            {
                throw new Exception("Tem coisa errada ai parceiro.");
            }
            saldo -= valor;
            return saldo;
        }

    }
}
