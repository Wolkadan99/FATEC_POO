using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVendaProduto
{
    class Produto
    {
        private double preco;
        private int tamanho;

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
    }
}
