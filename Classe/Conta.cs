using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Conta
    {
        //declaração de atributos - membros - características
        public int numero; // tipo nome da variável
        public string titular;
        public double saldo;

        //declaração dos métodos - funções
        public bool Sacar(double valorSaque)
        {
            if (saldo >= valorSaque && valorSaque > 0)
            {
                saldo = saldo - valorSaque;
                return true;
            }
            else
            {
                Console.WriteLine("Valor insuficiente para saque");
                return false;
            }
        }
        public void Depositar(double valorDeposito)
        {// valorDeposito é um parâmetro
            if (valorDeposito > 0)
                saldo += valorDeposito;//saldo = saldo + valorDeposito
            else
                Console.WriteLine("Valor negativo não é aceito");
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("\nNúmero: " + numero + "\tTitular: "
                + titular + "\tSaldo: " + saldo);
        }
        public void Transferir(double valor, Conta objeto)
        {
            saldo = saldo - valor;
            objeto.saldo = objeto.saldo + valor;
        }
        public void Transferir1(double valor, Conta objeto)
        {
            if (Sacar(valor))
                objeto.Depositar(valor);
        }
    }
}
