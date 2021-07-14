using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Composite
{
    public abstract class PresenteBase
    {
        protected string nome;
        protected int preco;

        public PresenteBase(string nome, int preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public abstract int CalcularPrecoTotal();
    }
}
