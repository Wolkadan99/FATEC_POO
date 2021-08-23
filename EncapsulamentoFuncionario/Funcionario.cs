using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    class Funcionario
    {
        // declaração de atributos
        private int codigo;
        private string nome;
        private double salario;

        // declaração do encapsulamento
        public int Codigo
        {
            set
            {
                this.codigo = value;
            }
            get
            {
                return this.codigo;
            }
        }
        public string Nome
        {
            set
            {
                this.nome = value;
            }
            get
            {
                return this.nome;
            }
        }
        public double Salario
        {
            set
            {
                this.salario = value;
            }
            get
            {
                return this.salario;
            }
        }
        // declaração de métodos-funções
        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo}  Nome: {nome}  Salario: {salario}");
        }
    }
}
