using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVetorContaCliente
{
    class Conta
    {
        private int numero;
        private List<Cliente> vetTitular; //agregação
        private double saldo;
        //Cliente[] vetCliente = new Cliente[3];

        public List<Cliente> VetTitular
        {
            get
            {
                return this.vetTitular;
            }
            set
            {
                this.vetTitular = value;
            }
        }
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
        
    }
}
