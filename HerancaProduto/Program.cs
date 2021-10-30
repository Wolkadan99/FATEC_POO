using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(100.55,"mouse",1);
            p.Mostrar();
           
            Perecivel pe = new Perecivel("20/09/2021","27/09/2021",10,99.95,"mussarela",2);
            pe.Mostrar();
            Console.ReadKey();
        }
    }
}
