using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta[] vetorConta = new Conta[3];//declaração do vetor
            for(int i=0, i < vetorConta.Length; i++)
            {
                vetorConta[i] = new Conta();
            }
        }
    }
}
