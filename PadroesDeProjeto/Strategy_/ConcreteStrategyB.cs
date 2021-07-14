using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Strategy_
{
    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
                "Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
}
