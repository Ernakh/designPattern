using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Chain_of_Responsibility
{
    public abstract class Handler
    {
        protected Handler successor;
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(int request);
    }
}
