using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Factory_Method
{
    public class Homem : Pessoa
    {
        public Homem (string nome)
        {
            this.nome = nome;
            this.sexo = "M";
            Console.WriteLine(nome + " é um Homem.");
        }
    }
}
