using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Interpreter
{
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(ContextoInterpreter context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }
}
