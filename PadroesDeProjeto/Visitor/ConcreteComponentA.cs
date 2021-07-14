using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Visitor
{
    public class ConcreteComponentA : IComponent
    {
        // Note that we're calling `VisitConcreteComponentA`, which matches the
        // current class name. This way we let the visitor know the class of the
        // component it works with.
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteComponentA(this);
        }

        // Concrete Components may have special methods that don't exist in
        // their base class or interface. The Visitor is still able to use these
        // methods since it's aware of the component's concrete class.
        public string ExclusiveMethodOfConcreteComponentA()
        {
            return "A";
        }
    }
}
