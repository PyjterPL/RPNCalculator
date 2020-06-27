using Calculator.Core.Tokens.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Interfaces
{
    public interface IRPNExpressionFormatter
    {
        Queue<Token> FormatToRPN(string expression);
    }
}
