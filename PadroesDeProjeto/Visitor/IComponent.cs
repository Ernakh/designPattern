using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Visitor
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
