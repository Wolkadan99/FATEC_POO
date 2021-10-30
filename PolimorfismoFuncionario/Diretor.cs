using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    class Diretor : Funcionario
    {
        public Diretor(double salario, string nome, int codigo) : base(salario, nome, codigo)
        {
        }
        public override double CalcularBonificacao()
        {          //chama o método da classe base de 10%      + 1000
            return base.CalcularBonificacao() + 1000;
        }
    }
}
