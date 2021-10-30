using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uma forma de demonstrar a agregação
            Cliente cli1 = new Cliente();
            cli1.Nome = "Bia";
            cli1.Rg = 111;
            cli1.Cpf = 111;

            Conta conta1 = new Conta();
            conta1.Numero = 1;
            conta1.Saldo = 100;
            conta1.Titular = cli1; // o atributo titular recebe um objeto, então a partir daqui o titular também é um objeto

            //outra forma de demonstrar a agregação
            Conta conta2 = new Conta();
            conta2.Numero = 2;
            conta2.Saldo = 200;
            conta2.Titular = new Cliente(); //o titular é um objeto representante da classe Cliente
            conta2.Titular.Nome = "Léo";
            conta2.Titular.Rg = 222;
            conta2.Titular.Cpf = 222;

        }
    }
}
