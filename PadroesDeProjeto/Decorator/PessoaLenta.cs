using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Decorator
{
    class PessoaLenta : IPessoaNormal
    {
        IPessoaNormal p;

        public PessoaLenta(IPessoaNormal p)
        {
            this.p = p;
        }

        public string Andar()
        {
            return new StringBuilder(p.Andar())
                .Append(" ")
                .Append("devagar")
                .ToString();
        }
    }
}
