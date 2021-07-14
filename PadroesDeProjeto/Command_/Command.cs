using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Command_
{
    public abstract class Command
    {
        protected Receiver receiver;
        // Constructor
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public abstract void Execute();
    }
}
