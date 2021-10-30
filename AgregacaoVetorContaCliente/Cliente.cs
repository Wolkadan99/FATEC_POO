using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVetorContaCliente
{
    class Cliente
    {
        private string nome;
        private int rg;
        private int cpf;

        public string Nome
        {
            set
            {
                this.nome = value;
            }
            get
            {
                return this.nome;
            }
        }
        public int Rg
        {
            set
            {
                this.rg = value;
            }
            get
            {
                return this.rg;
            }
        }
        public int Cpf
        {
            set
            {
                this.cpf = value;
            }
            get
            {
                return this.cpf;
            }
        }
    }
}
