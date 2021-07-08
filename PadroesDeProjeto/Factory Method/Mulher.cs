using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Factory_Method
{
    public class Mulher : Pessoa
    {
        public Mulher(string nome)
        {
            this.nome = nome;
            this.sexo = "F";
            Console.WriteLine(nome + " é uma Mulher.");
        }
    }
}
