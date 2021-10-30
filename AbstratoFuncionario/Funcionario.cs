using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    abstract class Funcionario
    {
        public int Codigo { get; set; }//Forma compacta de realizar o encapsulamento
        public string Nome { get; set; }
        public double Salario { get; set; }

        protected Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public abstract double CalcularSalario(int diasUteis);//método abstrato só tem a assinatura
        //dele, se o método é abstrato as subclasses são OBRIGADAS A IMPLEMENTÁ-LOS,
        //você programador NÃO É OBGRIGADO A TER um método abstrato, É OPCIONAL

        public virtual void Mostrar()//método com polimorfismo
        {
            Console.WriteLine("Código: " + Codigo + "\tNome: " + Nome + "\tSalário: " + Salario);
        }
    }
}
