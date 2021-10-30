using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoContaCliente
{
    class Conta
    {
        private int numero;
        private Cliente titular;//agregação
        private double saldo;

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }
        public Cliente Titular
        {
            get
            {
                return this.titular;
            }
            set
            {
                this.titular = value;
            }
        }
    }
}
