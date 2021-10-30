using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class ClienteFisico : Cliente
    {
        public int Rg { get; set; }

        public ClienteFisico(int codigo, string nome, int idade, int rg) : base(codigo, nome, idade)
        {
            Rg = rg;
        }
        public override void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tIdade: " + Idade + "\tRg: " + Rg);
        }
        public override string VerificaIdade()
        {
            if (Idade < 50)
                return "Cliente físico";
            else
                return "";
        }
    }
}
