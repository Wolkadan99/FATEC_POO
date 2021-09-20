using System;

namespace Classe
{

    class Program
    {
        static void Main(string[] args)
        {//tipo nome_variável;
            Conta conta1; // declarando uma variável
            conta1 = new Conta(); // instancia de objeto
            conta1.numero = 1;
            conta1.titular = "Ana";
            conta1.saldo = 500;
            conta1.MostrarAtributos();
            //classe    objeto = alocação de memória     construtor
            Conta conta2 = new Conta();
            conta2.numero = 2;
            conta2.titular = "Bia";
            conta2.saldo = 300;
            conta2.MostrarAtributos();

            Console.WriteLine("\nTransferir");
            conta2.Transferir(100, conta1);
            conta2.MostrarAtributos();
            conta1.MostrarAtributos();

            Console.WriteLine("\nTransferir 1");
            conta2.Transferir1(500, conta1);
            conta2.MostrarAtributos();
            conta1.MostrarAtributos();

            /*      instanciação do objeto
            Conta c3 = new Conta();
            Console.Write("Digite um número de conta: ");
            c3.numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um titular de conta: ");
            c3.titular = Console.ReadLine();
            Console.Write("Digite um saldo de conta: ");
            c3.saldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Saldo c3: " + c3.saldo);
            Console.WriteLine("Qual valor quer sacar da sua conta? ");
            double vs = Convert.ToDouble(Console.ReadLine());
            c3.Sacar(vs);
            Console.WriteLine("Saldo c3 após o saque: " + c3.saldo);
            Console.WriteLine("Qual valor quer depositar da sua conta? ");
            double vd = Convert.ToDouble(Console.ReadLine());
            c3.Depositar(vd); // vd é um argumento para a função depositar
            c3.MostrarAtributos();*/
            Console.ReadKey();

        }
    }
}
