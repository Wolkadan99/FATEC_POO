using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    class Conta
    {
        //declaração dos atributos
        private int numero;
        private string titular;
        private double saldo;





        //declaração dos métodos construtores
        public Conta()
        {

        }
        public Conta(int numero)
        {
            this.numero = numero;
        }
        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;

        }
        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"\nNúmero: {numero}\tTitular:{titular}\tSaldo:{saldo:C}");
        }
    }

}

