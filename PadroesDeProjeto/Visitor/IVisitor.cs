using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Visitor
{
    public interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);

        void VisitConcreteComponentB(ConcreteComponentB element);
    }
}
