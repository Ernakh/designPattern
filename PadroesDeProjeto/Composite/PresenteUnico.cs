using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Composite
{
    public class PresenteUnico : PresenteBase
    {
        public PresenteUnico(string nome, int preco) : base(nome, preco)
        {

        }


        public override int CalcularPrecoTotal()
        {
            Console.WriteLine($"{nome} com preço de {preco}");
            return preco;
        }
    }
}
