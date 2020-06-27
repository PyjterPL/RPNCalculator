using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Tokens.Base
{
    public abstract class Token
    {
        public readonly char Sign;

        public Token(char sign)
        {
            Sign = sign;
        }
    }
}
