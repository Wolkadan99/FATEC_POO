﻿using System;

namespace ClasseFuncionario
{
    class Funcionario
    {
        //declaração de atributos
        public int codigo;
        public string nome;
        public double salario;

        //declaração do métodos-funções
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome +
                "\tSalário: " + salario);
        }
    }
}
