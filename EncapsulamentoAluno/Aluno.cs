using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoAluno
{
    class Aluno
    {
        //declaração de atríbutos encapsulados
        private int ra;
        private string nome;
        private double prova1;
        private double prova2;
        private double media;

        /* Crie os métodos de encapsulamento de 
         * todos os atributo (membros da classe)
        * Na main crie um vetor de 3 elementos, digite ra, nome, p1, p2, 
        * a média deve ser calculada
        * apresente o vetor na main, sem a função mostrar
        * em outro laço de repetição apresente os 
        * alunos aprovados ou reprovados e seus respectivos
        * nomes e médias**/
        //declaração encapsulamento
        public int Ra
        {
            set
            {
                this.ra = value;
            }

            get
            { 
                return this.ra; 
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
        public double Prova1
        {
            set
            {
                this.prova1 = value;
            }
            get
            {
                return this.prova1;
            }
        }
        public double Prova2
        {
            set
            {
                this.prova2 = value;
            }
            get
            {
                return this.prova2;
            }
        }
        public double Media
        {
            set
            {
                this.media = value;
            }
            get
            {
                return this.media;
            }
        }
    }
}
