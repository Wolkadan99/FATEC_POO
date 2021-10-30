using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{//classe derivada : classe base
    class Juridico : Cliente //extends palavra usada em Java para herança
    {
        private int cnpj;
        private int ie;

        public int Ie
        {
            get { return ie; }
            set { ie = value; }
        }

        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

    }
}
