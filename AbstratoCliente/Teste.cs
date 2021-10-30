using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class Teste
    {//Esta classe contribui para o sistema e apresenta o RELACIONAMENTO DE DEPENDÊNCIA
        //na passagem de parâmetro por meio do objeto referente a classe Cliente (objCliente)
        public string AnalisaIdades(Cliente objCliente)//uso de generalização por meio do parâmetro
        {
            return objCliente.VerificaIdade();
        }
    }
}
