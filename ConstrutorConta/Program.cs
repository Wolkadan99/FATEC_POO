using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            conta1.MostrarAtributos();
            
            Conta conta2 = new Conta(50);
            conta2.MostrarAtributos();          

            Conta conta3 = new Conta(51, "Alberto");
            conta3.MostrarAtributos();

            Conta conta4 = new Conta(52, "Junberto", 1500);
            conta4.MostrarAtributos();

            Conta conta5 = new Conta(150.2);// Necessário informar como double, se não entrará como int
            conta5.MostrarAtributos();
            Console.WriteLine($"                                                                          |{Conta.Contador}|");

            Console.ReadKey();
        }
    }
}
