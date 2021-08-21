using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    class Funcionario
    {
        //declaração de atributos
        public int codigo;
        public string nome;
        public double salario;

        //declaração do métodos-funções
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome +
                "\tSalário: " + salario);
        }
    }
}
