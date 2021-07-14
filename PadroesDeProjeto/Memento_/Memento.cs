using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Memento_
{
    public class Memento
    {
        string state;
        // Constructor
        public Memento(string state)
        {
            this.state = state;
        }
        public string State
        {
            get { return state; }
        }
    }
}
