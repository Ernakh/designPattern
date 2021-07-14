using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Decorator
{
    class PessoaRapida : IPessoaNormal
    {
        IPessoaNormal p;


        public PessoaRapida(IPessoaNormal p)
        {
            this.p = p;
        }

        public string Andar()
        {
            return new StringBuilder(p.Andar())
                .Append(" ")
                .Append("rápido")
                .ToString();
        }

        public String Correr()
        {
            return "corri";
        }
    }
}
