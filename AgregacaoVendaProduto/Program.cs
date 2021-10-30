using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVendaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            Console.Write("Informe o preço do produto: ");
            p1.Preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o tamanho do produto: ");
            p1.Tamanho = Convert.ToInt32(Console.ReadLine());

            Produto p2 = new Produto();
            Console.Write("Informe o preço do produto: ");
            p2.Preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o tamanho do produto: ");
            p2.Tamanho = Convert.ToInt32(Console.ReadLine());

            Venda v = new Venda();
            Console.Write("Informe o código da venda: ");
            v.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe a data da venda: ");
            v.DtVenda = Console.ReadLine();
            v.VetProdutos = new List<Produto>();
            v.VetProdutos.Add(p1);
            v.VetProdutos.Add(p2);

            Console.ReadKey();
        }
    }
}
