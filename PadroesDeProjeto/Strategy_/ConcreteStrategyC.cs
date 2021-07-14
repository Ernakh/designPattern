using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Strategy_
{
    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine(
                "Called ConcreteStrategyC.AlgorithmInterface()");
        }
    }
}
