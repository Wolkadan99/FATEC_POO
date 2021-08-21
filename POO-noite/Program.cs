using System;

namespace POO_noite
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o ano de nascimento: "); // print
            int anoNascimento = Convert.ToInt32(Console.ReadLine());
            int idade = 2021 - anoNascimento;
            Console.WriteLine("Sua idade é " + idade);
            //exemplo do if
            if (idade >= 18) // duas ou mais linhas de código EXIGEM {}
            {
                Console.Write("O aluno é ");
                Console.WriteLine("maior de idade");
            }
            else if (idade == 17)
                Console.Write("Aluno não pode tirar carta de motorista");
            else // uma linha de código não precisa de {}
                Console.Write("O aluno é menor de idade");
            Console.Write("\nEXEMPLO COM SWITCH.......................");
            char mes = 'w';
            switch (mes) //utilizam variáveis interias ou char
            {
                case 'J': //mes == 1
                    Console.Write("Janeiro");
                    break;
                case 'F':
                    Console.WriteLine("Fevereiro");
                    break;
                default:
                    Console.Write("Mês inválido");
                    break;
            }
            Console.Write("\nEXEMPLO COM IF.......................");
            int mess = 2;
            if (mess == 1)
                Console.Write("Janeiro");
            else if (mess == 2)
                Console.Write("Fevereiro");
            else
                Console.Write("Mês inválido");


            Console.WriteLine("EXEMPLO DO FOR");
            //int cont;
            for (int cont1 = 0; cont1 < 3; cont1++) //Python for cont in range(3):
                Console.WriteLine("Valor do cont.....: " + cont1);

            Console.WriteLine("EXEMPLO DO WHILE");
            int cont = 0;
            while (cont < 3)
            {
                Console.WriteLine("Valor do cont.....: " + cont);
                //cont = cont + 1;
                //cont += 1;
                cont++;
            }
            cont = -1;
            Console.WriteLine("EXEMPLO DO COMANDO DO .. WHILE");
            do
            {
                Console.WriteLine("Valor do cont.....: " + cont);
                cont++;
            } while (cont < 3);

            Console.ReadKey();// apenas pausar a tela do prompt do programa em execução
        }
    }
}
