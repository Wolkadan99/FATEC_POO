using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVetorContaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            cli1.Nome = "Bia";
            cli1.Rg = 111;
            cli1.Cpf = 111;

            Cliente cli2 = new Cliente();
            cli2.Nome = "Lia";
            cli2.Rg = 222;
            cli2.Cpf = 222;

            Cliente cli3 = new Cliente();
            cli3.Nome = "Ana";
            cli3.Rg = 333;
            cli3.Cpf = 333;

            Conta c = new Conta();
            c.Numero = 1;
            c.Saldo = 10000;
            c.VetTitular = new List<Cliente>();
            c.VetTitular.Add(cli1);
            c.VetTitular.Add(cli2);
            c.VetTitular.Add(cli3);
            foreach (Cliente ci in c.VetTitular)
            {
                Console.WriteLine("Nome do cliente: " + ci.Nome);
            }
            Console.ReadKey();
        }
    }
}
