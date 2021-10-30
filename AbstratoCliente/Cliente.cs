using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    abstract class Cliente //esta classe é abstrata, então NÃO PODERÁ SER INSTANCIADA
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(int codigo, string nome, int idade)
        {
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        public abstract void Mostrar();//assinatura do método
        //e obrigada a ou as subclasses a implementarem este método
        //da maneira que é conveniente a cada uma

        public abstract string VerificaIdade(); //método abstrato

    }
}
