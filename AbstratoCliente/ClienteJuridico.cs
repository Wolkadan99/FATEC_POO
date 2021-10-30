using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
        public ClienteJuridico(int codigo, string nome, int idade, int cnpj) : base(codigo, nome, idade)
        {
            Cnpj = cnpj;
        }
        public override void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tIdade: "+Idade+"\tCnpj: " + Cnpj);
        }
        public override string VerificaIdade()
        {
            if (Idade >= 50)
                return "Cliente jurídico";
            else
                return "";
        }
    }
}
