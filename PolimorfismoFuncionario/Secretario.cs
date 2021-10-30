using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    class Secretario : Funcionario
    {
        public Secretario(double salario, string nome, int codigo) : base(salario, nome, codigo)
        {
        }
    }
}
