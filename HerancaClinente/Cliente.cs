using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class Cliente
    {
        protected int codigo;
        protected string nome;
        protected string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
