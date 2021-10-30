using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProduto
{
    class Produto //superclasse ou classe base
    {
        protected int codigo; // protected é um modificador de acesso/visibilidade de herança
        protected string nome;// permite a subclasse acessar/ver os atributos da superclasse
        protected double preco;

        public Produto(double preco, string nome, int codigo)
        {
            Preco = preco;
            Nome = nome;
            Codigo = codigo;
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tPreço: " + Preco);
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
