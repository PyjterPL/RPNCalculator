using Calculator.Core.Tokens.Base;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Calculator.Core.Tokens
{
    class Number : NumberBase
    {
        public Number(char sign) : base(sign)
        {
        }

        public override decimal Value => decimal.Parse(Sign.ToString());
    }
}
