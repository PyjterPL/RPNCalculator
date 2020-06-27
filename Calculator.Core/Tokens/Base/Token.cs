using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Tokens.Base
{
    public abstract class Token
    {
        public readonly string Entry;

        public Token(string entry)
        {
            Entry = entry;
        }
    }
}
