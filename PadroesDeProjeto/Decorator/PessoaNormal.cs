using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Decorator
{
    sealed class PessoaNormal : IPessoaNormal
    {
        public string Andar()
        {
            return "andei";
        }
    }
}
