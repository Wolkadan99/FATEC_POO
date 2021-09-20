using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo onix = new Veiculo();
            onix.marca = "Chevrolet";
            onix.motor.combustao.combustivel = "Gasolina";
            Veiculo hb20 = new Veiculo();
            hb20.motor.combustao.potencia = "15 mil cavalos";
        }
    }
}
