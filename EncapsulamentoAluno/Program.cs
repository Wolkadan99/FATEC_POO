using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] vetorAluno = new Aluno[3];
            for (int i = 0; i < vetorAluno.Length; i++)
            {
                vetorAluno[i] = new Aluno();
                int aux = 1;
                vetorAluno[i].Ra = aux++;
                Console.Write("Digite o Nome: ");
                vetorAluno[i].Nome = Console.ReadLine();
                Console.Write("Digite o nota da Prova 1: ");
                vetorAluno[i].Prova1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o nota da Prova 2: ");
                vetorAluno[i].Prova2 = Convert.ToDouble(Console.ReadLine());
                vetorAluno[i].Media = (vetorAluno[i].Prova1 + vetorAluno[i].Prova2) / 2;
            }
            foreach (Aluno a in vetorAluno)
            {
                Console.WriteLine($"RA: {a.Ra}\tNome:{a.Nome} \nP1:{a.Prova1}\tP2{a.Prova2}\nMédia:{a.Media}\n");
            }
            for (int i = 0; i < vetorAluno.Length; i++)
            {
                if (vetorAluno[i].Media >= 6)
                 Console.WriteLine($"Aprovados\nAluno: {vetorAluno[i].Nome} Média: {vetorAluno[i].Media}"); 
                else
                    Console.WriteLine($"Reprovados\nAluno: { vetorAluno[i].Nome} Média: { vetorAluno[i].Media}");
            }
            Console.ReadKey();
        }

    }
}

