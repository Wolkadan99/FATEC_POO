using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConstrutorFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            funcionario1.MostrarAtributos();

            Funcionario funcionario2 = new Funcionario(50);
            funcionario2.MostrarAtributos();

            Funcionario funcionario3 = new Funcionario(51, "Alberto");
            funcionario3.MostrarAtributos();

            Funcionario funcionario4 = new Funcionario(52, "Junberto", 1500);
            funcionario4.MostrarAtributos();
            
            Console.WriteLine($"                                                                    Registros[{Funcionario.Contador}]");            
            Console.ReadKey();
        }
    }
}
