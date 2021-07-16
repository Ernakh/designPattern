using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Strategy_
{
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }
}
