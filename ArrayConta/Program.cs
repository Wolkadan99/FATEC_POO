using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta[] vetorConta = new Conta[3];//declaração do vetor
            for(int i=0; i < vetorConta.Length; i++)
            {
                vetorConta[i] = new Conta();
                Console.Write("Informe o número da conta: ");
                vetorConta[i].numero = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o titular da conta: ");
                vetorConta[i].titular = Console.ReadLine();
                Console.Write("Informe o saldo em conta: ");
                vetorConta[i].saldo = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Exemplo com for .\t.\t.\t.\t.\t.\t.\t.\t.\t.\t.\t.\t.\t.\t");
            for (int i = 0; i < vetorConta.Length; i++)
            {
                vetorConta[i].Mostrar();
            }
            Console.WriteLine("Exemplo com foreach .\t.\t.\t.\t.\t.\t.\t.\t.\t.\t.\t.\t.\t.\t");
            foreach (Conta conta in vetorConta)
            {
                conta.Mostrar();
            }
            Console.ReadKey();
        }
    }
}
