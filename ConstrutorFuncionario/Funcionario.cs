using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    class Funcionario
    {
        //declaração dos atributos
        private int codigo;
        private string nome;
        private double salario;
        private static int contador;

        public static int Contador
        {
            get
            {
                return contador;
            }
        }

        //declaração dos métodos construtores
        public Funcionario()
        {
            contador++;
        }
        public Funcionario(int codigo)
        {
            this.codigo = codigo;
            contador++;
        }
        public Funcionario(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
            contador++;

        }
        public Funcionario(int codigo, string titular, double salario)
        {
            this.codigo = codigo;
            this.nome = titular;
            this.salario = salario;
            contador++;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"\nNúmero de matricula: {codigo}\tFuncionário:{nome}\tSalario:{salario:C}");
        }
    }

}

