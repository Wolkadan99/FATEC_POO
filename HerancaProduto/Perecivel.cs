using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProduto
{//subclasse ou classe derivada
    class Perecivel : Produto
    {
        private int lote;
        private string dtValidade;
        private string dtFabricacao;

        public Perecivel(string dtFabricacao, string dtValidade, int lote, double preco, 
            string nome, int codigo) : base (preco, nome, codigo) //base executa o construtor
        {                                                         //da classe base (superclasse)
            DtFabricacao = dtFabricacao;
            DtValidade = dtValidade;
            Lote = lote;
        }

        public override void Mostrar()
        {
            base.Mostrar(); //base, pode ser usada na chamada de método da classe base (superclasse)
            Console.WriteLine("Data de Fabricação: "+dtFabricacao+"\tData de Validade: " + dtValidade+
                "\tLote: "+lote);
        }
        public string DtFabricacao
        {
            get { return dtFabricacao; }
            set { dtFabricacao = value; }
        }
        public string DtValidade
        {
            get { return dtValidade; }
            set { dtValidade = value; }
        }
        public int Lote
        {
            get { return lote; }
            set { lote = value; }
        }

    }
}
