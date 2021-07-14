using System;
using System.Collections.Generic;
using System.Text;

namespace PadroesDeProjeto.Interpreter
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(ContextoInterpreter context);
    }
}
