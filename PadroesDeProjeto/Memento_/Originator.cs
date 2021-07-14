using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Memento_
{
    public class Originator
    {
        string state;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State = " + state);
            }
        }
        // Creates memento 
        public Memento CreateMemento()
        {
            return (new Memento(state));
        }
        // Restores original state
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
}
