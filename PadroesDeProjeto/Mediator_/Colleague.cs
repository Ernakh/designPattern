using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Mediator_
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        // Constructor
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
