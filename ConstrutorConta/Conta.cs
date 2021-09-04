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
        private static int contador;

        public static int Contador
        {
            get
            {
                return contador;
            }
        }

        //declaração dos métodos construtores
        public Conta()
        {
            contador++;
        }
        public Conta(int numero)
        {
            this.numero = numero;
            contador++;
        }
        public Conta(double saldo)
        {
            this.saldo = saldo;
            contador++;
        }
        public Conta(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            contador++;

        }
        public Conta(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
            contador++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"\nNúmero: {numero}\tTitular:{titular}\tSaldo:{saldo:C}");
        }
    }

}

