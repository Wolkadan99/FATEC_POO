using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            funcionario1.Codigo = 1; //Quando atribui valor, o método set esta sendo acionado
            funcionario1.Nome = "Marco";
            funcionario1.Salario = 50;
            Console.WriteLine($"Funcionario {funcionario1.Nome}");

            Funcionario funcionario2 = new Funcionario();

            Console.ReadKey();
        }
    }
}
