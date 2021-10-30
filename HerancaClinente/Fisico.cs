using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    //subclasse  : superclasse
    class Fisico : Cliente
    {
        private int rg;
        private int cpf;

        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public void Mostrar()
        {
            Console.WriteLine("Código: "+ codigo + "\tNome: " + nome + "\tEndereço: " + endereco+
                "\tRg: "+rg + "\tCpf: "+cpf);
        }
    }
}
