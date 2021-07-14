using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Composite
{
    public class CompositePresente : PresenteBase, IPresenteOperacoes
    {
        private List<PresenteBase> _presentes;
        public CompositePresente(string nome, int preco) : base(nome, preco)
        {
            _presentes = new List<PresenteBase>();
        }

        public override int CalcularPrecoTotal()
        {
            int total = 0;

            Console.WriteLine($"{nome} contem os itens abaixo com preço:");

            foreach (PresenteBase presente in _presentes)
            {
                total += presente.CalcularPrecoTotal();
            }

            return total;
        }

        public void Adicionar(PresenteBase gift)
        {
            _presentes.Add(gift);
        }

        public void Remover(PresenteBase gift)
        {
            _presentes.Remove(gift);
        }
    }
}
