using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;

        public virtual double CalcularBonificacao()
        {
            return salario * 10 / 100;
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
            Console.WriteLine("Bonificação: " + CalcularBonificacao()+"\n");
        }
        public Funcionario(double salario, string nome, int codigo)
        {
            Salario = salario;
            Nome = nome;
            Codigo = codigo;
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
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
