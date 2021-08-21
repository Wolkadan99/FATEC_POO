using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseProduto
{
    class Produto
    {
        //declaração de atributos
        public int codigo;
        public string descricao;
        public double preco;
        public double custo;

        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + descricao +
                "\tValor de venda: " + preco);

        }
    }
}

