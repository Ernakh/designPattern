using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Memento_
{
    public class Caretaker
    {
        Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
