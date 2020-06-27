using Calculator.Core.Interfaces;
using Calculator.Core.Tokens.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core
{
    public class DijkstraRPNExpressionFormatter : IRPNExpressionFormatter
    {
        private readonly ITokenFactory _tokenFactory;
        public DijkstraRPNExpressionFormatter(ITokenFactory tokenFactory)
        {
            _tokenFactory = tokenFactory;
        }
        public Queue<Token> FormatToRPN(string expression)
        {
            var resultQueue = new Queue<Token>();
            var stack = new Stack<Token>();
            foreach (var sign in expression)
            {
                var token = _tokenFactory.GetToken(sign);
            }
            throw new NotImplementedException();
        }
    }
}
