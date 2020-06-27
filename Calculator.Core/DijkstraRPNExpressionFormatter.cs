using Calculator.Core.Interfaces;
using Calculator.Core.Tokens.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core
{
    public class DijkstraRPNExpressionFormatter : IRPNExpressionFormatter
    {
        public Queue<Token> FormatToRPN(string expression)
        {
            var resultQueue = new Queue<Token>();
            var stack = new Stack<Token>();

            throw new NotImplementedException();
        }
    }
}
