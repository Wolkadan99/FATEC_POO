using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoClasse
{
    class Program
    {
        public Conta conta;
        static void Main(string[] args)
        {
            Conta objetoConta = new Conta();
            objetoConta.id = +1;
            objetoConta.titular = "Joana";
            objetoConta.saldo = 253.00 ;
            objetoConta.MostrarAtributos();
            Console.ReadKey();
        }
    }
}