using Calculator.Core.Tokens.Base;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Calculator.Core.Tokens
{
    public class Number : NumberBase
    {
        public Number(string entry) : base(entry)
        {
        }

        public override decimal Value => decimal.Parse(Entry.ToString());
    }
}
