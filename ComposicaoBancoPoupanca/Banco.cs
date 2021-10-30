using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoBancoPoupanca
{
    class Banco
    {
        private string nome;
        private List<Poupanca> vetPoupancas;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public List<Poupanca> VetPoupancas
        {
            get { return vetPoupancas; }
            set { vetPoupancas = value; }
        }
        public Banco(string nome, List<Poupanca> vetPoupancas)
        {
            Nome = nome;
            VetPoupancas = vetPoupancas;
        }
        ~Banco()//destrutor
        {
            VetPoupancas = null;//retirando a referência do objeto instanciado
            Console.WriteLine("Destrutor do Banco");
        }
    }
}
