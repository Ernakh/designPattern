using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Composite
{
    public interface IPresenteOperacoes
    {
        void Adicionar(PresenteBase gift);
        void Remover(PresenteBase gift);
    }
}
