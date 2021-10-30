using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoBancoPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Poupanca p1 = new Poupanca();
            p1.Saldo = 100;
            Poupanca p2 = new Poupanca();
            p2.Saldo = 200;
            List<Poupanca> vp = new List<Poupanca>();
            vp.Add(p1);
            vp.Add(p2);
            Banco b = new Banco("Itau", vp);
            b = null; //retirando a referência do objeto instanciado
            GC.Collect();


            Console.ReadKey();
        }
    }
}
