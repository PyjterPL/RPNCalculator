using Calculator.Core.Interfaces;
using Calculator.Core.Tokens.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Tokens
{
    public class TokenFactory : ITokenFactory
    {
        private List<Token> _registeredTokens = new List<Token>();
        public TokenFactory()
        {

        }
        public Token GetToken(char sign)
        {
            throw new NotImplementedException();
        }
    }
}
