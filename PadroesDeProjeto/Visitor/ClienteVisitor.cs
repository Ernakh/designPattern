using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PadroesDeProjeto.Visitor
{
    public class ClienteVisitor
    {
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}
