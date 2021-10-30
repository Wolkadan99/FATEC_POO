using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    class Gerente : Funcionario
    {
        public Gerente(double salario, string nome, int codigo) : base(salario, nome, codigo)
        {
        }
        public override double CalcularBonificacao()
        {
            return Salario * 15 / 100;
        }
    }
}
