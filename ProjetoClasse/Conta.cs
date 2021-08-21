using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasse
{
    public class Conta
    {
        public int id = 1000;
        public string titular;
        public double saldo;

        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
                saldo += valorDeposito;
            else
                Console.WriteLine("Valor de deposito deve ser positivo");

        }

        public void Sacar(double valorSaque)
        {
            if (saldo >= valorSaque)
                saldo -= valorSaque;
            else
                Console.WriteLine("Valor insuficiente para saque");

        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Numero da conta " + id);
            Console.WriteLine("Titular " + titular);
            Console.WriteLine("Valor saldo :" + saldo);
        }
    }

}