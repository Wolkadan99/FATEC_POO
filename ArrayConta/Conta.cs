using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta
{
    class Conta
    {
        //declaração de atributos
        public int numero;
        public string titular;
        public double saldo;

        //declaração de método
        public void Mostrar()
        {
            Console.WriteLine("Número: " + numero+"\tTitular: "+titular+"\tSaldo: "+ saldo);
        }
    }
}