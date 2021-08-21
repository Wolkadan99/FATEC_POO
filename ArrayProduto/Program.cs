using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduto
{
    class Program
    {
        /* Crie um vetor de 3 elementos
        * Insira/digite os valores dos atributos
        *
        * abra outro laço de repetição, aplique um percentual
        * de aumento aos produtos
        *
        * apresente ao final qual é a diferença entre o total dos preços
        * antigos e após o aumento
        *
        * Apenas use UM vetor e os atributos já definidos
        *
        * Apresente os atributos após o aumento
        */


        static void Main(string[] args)
        {
            Produto[] vetorProduto = new Produto[3];//declaração do vetor
            for (int i = 0; i < vetorProduto.Length; i++)
            {
                vetorProduto[i] = new Produto();
                Console.Write("Informe o código da produto: ");
                vetorProduto[i].codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Informe o descricao da produto: ");
                vetorProduto[i].descricao = Console.ReadLine();
                Console.Write("Informe o custo do produto: ");
                vetorProduto[i].custo = Convert.ToDouble(Console.ReadLine());
            }

            foreach (Produto produto in vetorProduto)
            {
                produto.MostrarCusto();
                Console.WriteLine("Percentual de aumento: ");
                produto.percentual = Convert.ToDouble(Console.ReadLine());
                produto.AumentoPreco();
            }

            Console.WriteLine("Valores anteriores");
            foreach (Produto produto in vetorProduto)
            {
                produto.MostrarCusto();
            }
            Console.WriteLine("Novos valores");
            foreach (Produto produto in vetorProduto) { 
                produto.MostrarPreco();
            }
            Console.ReadKey();
        }

    }
}