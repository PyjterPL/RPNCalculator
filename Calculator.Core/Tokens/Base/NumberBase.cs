using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Tokens.Base
{
    public abstract class NumberBase : Token
    {
        public abstract decimal Value { get; }
        public NumberBase(string entry) : base(entry)
        {
        }
    }
}
