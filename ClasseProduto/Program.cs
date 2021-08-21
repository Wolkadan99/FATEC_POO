using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            //intância de objeto
            Produto produto1 = new Produto();
            Console.Write("Digite o código do produto: ");
            produto1.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome do produto: ");
            produto1.descricao = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            produto1.preco = Convert.ToDouble(Console.ReadLine());

            Produto produto2 = new Produto();
            Console.Write("Digite o código do produto: ");
            produto2.codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o nome do produto: ");
            produto2.descricao = Console.ReadLine();
            Console.Write("Digite o valor do produto: ");
            produto2.preco = Convert.ToDouble(Console.ReadLine());
            double soma = produto1.preco + produto2.preco;
            Console.WriteLine("\nTotal de valores: " + soma + "\n");
            produto1.MostrarAtributos();
            produto2.MostrarAtributos();

            Console.ReadKey();
        }
    }
}
