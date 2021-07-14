using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Command_
{
    public class ConcreteCommand : Command
    {
        // Constructor
        public ConcreteCommand(Receiver receiver) :
            base(receiver)
        {
        }
        public override void Execute()
        {
            receiver.Action();
        }
    }
}
