using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProduto
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

    class Produto
    {
        //declaração de atributos
        public int codigo;
        public string descricao;
        public double custo;
        public double preco;
        internal double aux;
        internal double percentual;
        
        //declaração de Métodos
        public void MostrarCusto()
        {
            Console.WriteLine($"Código: {codigo}\tNome: {descricao}\tValor de custo: R$ {custo}");
        }
        public void MostrarPreco()
        {
            Console.WriteLine($"Código {codigo}\tNome: {descricao}\tValor de venda: R$ {preco}");
        }
        public void AumentoPreco()
        {
            aux = custo;
            aux += custo * (percentual/100);
            preco = aux;
        }
    }
}
