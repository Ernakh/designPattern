using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Mediator_
{
    public class ConcreteMediator : Mediator
    {
        ConcreteColleague1 colleague1;
        ConcreteColleague2 colleague2;
        public ConcreteColleague1 Colleague1
        {
            set { colleague1 = value; }
        }
        public ConcreteColleague2 Colleague2
        {
            set { colleague2 = value; }
        }
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == colleague1)
            {
                colleague2.Notify(message);
            }
            else
            {
                colleague1.Notify(message);
            }
        }
    }

}
