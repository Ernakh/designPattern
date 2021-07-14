using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Interpreter
{
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(ContextoInterpreter context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
