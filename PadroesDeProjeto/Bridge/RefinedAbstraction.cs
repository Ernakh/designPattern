using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
