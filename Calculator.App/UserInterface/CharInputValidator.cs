using Calculator.Core.Interfaces;
using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.UserInterface
{
    public class CharInputValidator : IInputValidator
    {
        private readonly ITokenFactory _tokenFactory;
        public CharInputValidator(ITokenFactory tokenFactory)
        {
            _tokenFactory = tokenFactory;
        }

        public bool IsValidForCalculations(char c)
        {
            return _tokenFactory.GetToken(c.ToString()) != null;
        }
    }
}
