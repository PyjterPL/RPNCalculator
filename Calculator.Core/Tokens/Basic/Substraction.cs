using Calculator.Core.Tokens.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Tokens.Basic
{
    public class Substraction : OperatorBase
    {
        public Substraction(string entry) : base(entry)
        {
        }

        public override decimal Calculate(decimal left, decimal right)
        {
            return left - right;
        }
    }
}
