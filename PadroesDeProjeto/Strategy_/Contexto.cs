using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Strategy_
{
    public class Contexto
    {
        Strategy strategy;
        // Constructor
        public Contexto(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
