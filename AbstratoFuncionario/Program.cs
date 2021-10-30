using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Funcionario f = new Funcionario();
            Assalariado a1 = new Assalariado(1,"Bia",1000);
            Comissionado c1 = new Comissionado(2, "Lia",1000,0.2);
            Assalariado a2 = new Assalariado(3, "Leo", 2000);
            Comissionado c2 = new Comissionado(4, "Ana",2000, 0.2);

            Departamento d1 = new Departamento(10, "TI");
            Departamento d2 = new Departamento(11, "RH");
            d1.VetF = new List<Funcionario>();
            d2.VetF = new List<Funcionario>();
            d1.Admitir(a1);
            d1.Admitir(c1);
            d2.Admitir(a2);
            d2.Admitir(c2);
            d1.Listar();
            d2.Listar();
            Console.WriteLine(d1.CalcularFolha(30));
            Console.WriteLine(d2.CalcularFolha(30));
            d2.Demitir(4);
            d2.Listar();
            Console.ReadKey();
        }
    }
}
