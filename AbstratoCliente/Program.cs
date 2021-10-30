using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tentando instanciar um objeto referente a superclasse?
            //Cliente c = new Cliente(); // NÃO PODE OCORRER INSTÂNCIA

            // Podemos instanciar objeto referente as subclasses 
            ClienteFisico cf = new ClienteFisico(1,"Ana",20, 1111);
            ClienteJuridico cj = new ClienteJuridico(2,"Empresa",60, 2222);
            cf.Mostrar();
            cj.Mostrar();
            Teste t = new Teste();
            Console.WriteLine("Resultado da validação de idades: " + t.AnalisaIdades(cf));
            Console.WriteLine("Resultado da validação de idades: " + t.AnalisaIdades(cj));
            Console.ReadKey();

        }
    }
}
