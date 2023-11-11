using MySql.Data.MySqlClient;
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

        public void depositoSaldo(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Tem coisa errada ai parceiro.");
            }

            Conexao conexao = new Conexao();
            this.saldo += valor;
 
        }
        public void saqueSaldo(double valor)
        {
            if (valor <= 0 || saldo <= valor)
            {
                throw new Exception("Tem coisa errada ai parceiro.");
            }
            this.saldo -= valor;
        }

    }
}
