using Calculator.Core.Tokens.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Tokens.Basic
{
    public class Division : OperatorBase
    {
        public Division(char sign) : base(sign)
        {
        }

        public override int Priority => 2;

        public override decimal Calculate(decimal left, decimal right)
        {
            return left / right;
        }
    }
}
