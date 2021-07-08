using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Factory_Method
{
    public class FactoryPessoa
    {
        public Pessoa getPessoa(string nome, string sexo)
        {
            if (sexo.Equals("M"))
            {
                return new Homem(nome);
            }
            else if (sexo.Equals("F"))
            {
                return new Mulher(nome);
            }
            else
                return null;
        }
    }
}
