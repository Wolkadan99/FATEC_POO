using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregacaoVendaProduto
{
    class Venda
    {
        private int codigo;
        private string dtVenda;
        private List<Produto> vetProdutos;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string DtVenda
        {
            get { return dtVenda; }
            set { dtVenda = value; }
        }
        public List<Produto> VetProdutos
        {
            get { return vetProdutos; }
            set { vetProdutos = value; }
        }
    }
}
