using Calculator.Core.Interfaces;
using Calculator.Core.Tokens.Base;
using Calculator.Core.Tokens.Basic;
using Calculator.Core.Tokens.Brackets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculator.Core.Tokens
{
    public class TokenFactory : ITokenFactory
    {
        private const string _invalidEntryMessage = "Token {0} not registered";
        private Dictionary<Func<string, bool>, Type> _registeredTokens = new Dictionary<Func<string, bool>, Type>();
        public TokenFactory()
        {
            _registeredTokens.Add(t => t == "+", typeof(Addition));
            _registeredTokens.Add(t => t == "-", typeof(Substraction));
            _registeredTokens.Add(t => t == "*", typeof(Multiplication));
            _registeredTokens.Add(t => t == "/", typeof(Division));
            _registeredTokens.Add(t => t == "(", typeof(LeftBracket));
            _registeredTokens.Add(t => t == ")", typeof(RightBracket));

            _registeredTokens.Add(t => Regex.Match(t, @"^(\d+(\d*)?)$").Success, typeof(Number));
        }
        public Token GetToken(string entry)
        {
            var registeredToken = _registeredTokens.FirstOrDefault(rt => rt.Key(entry));
            if (registeredToken.Value == null)
            {
                return null;
            }

            return (Token)Activator.CreateInstance(registeredToken.Value, entry);
        }
    }
}
