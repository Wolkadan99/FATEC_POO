using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario(1000, "Funcionario", 1);
            Secretario s = new Secretario(1000, "Secretario", 2);
            Gerente g = new Gerente(1000, "Gerenteee", 3);
            Diretor d = new Diretor(1000, "Diretor", 4);
            f.Mostrar();
            s.Mostrar();
            g.Mostrar();
            d.Mostrar();
            Console.ReadKey();
        }
    }
}
