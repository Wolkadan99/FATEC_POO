using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.Codigo = 1;
            c.Nome = "Bia";
            c.Endereco = "Rua Terezina, 75";

            Fisico f = new Fisico();
            f.Codigo = c.Codigo;
            f.Nome = "Lia";
            f.Endereco = "Rua Japão, 5";
            f.Rg = 222;
            f.Cpf = 222;
            f.Mostrar();

            Juridico j = new Juridico();
            j.Codigo = 3;
            j.Nome = "Ana";
            j.Endereco = "Rua Ceará, 7";
            j.Cnpj = 111;
            j.Ie = 1111;
            Console.ReadKey();
        }
    }
}
