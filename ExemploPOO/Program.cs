using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Bob";
            pessoa1.Idade = 22;

            pessoa1.Apresentar();
        }
    }
}