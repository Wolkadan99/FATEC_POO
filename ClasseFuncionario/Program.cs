using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //intância de objeto
            Funcionario funcionario1 = new Funcionario();
            Console.Write("Digite o código do funcionário: ");
            funcionario1.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome do funcionário: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            funcionario1.salario = Convert.ToDouble(Console.ReadLine());

            Funcionario funcionario2 = new Funcionario();
            Console.Write("Digite o código do funcionário: ");
            funcionario2.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome do funcionário: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            funcionario2.salario = Convert.ToDouble(Console.ReadLine());
            double soma = funcionario1.salario + funcionario2.salario;
            Console.WriteLine("\nTotal de salários: "+ soma+"\n");
            funcionario1.MostrarAtributos();
            funcionario2.MostrarAtributos();

            Console.ReadKey();
        }
    }
}
