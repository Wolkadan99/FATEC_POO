using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoBancoPoupanca
{
    class Poupanca
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        ~Poupanca()
        {
            Console.WriteLine("Destrutor Poupança");
        }
    }
}
