using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Tokens.Base
{
    public abstract class OperatorBase : Token
    {
        public virtual int Priority
        {
            get { return 1; }
        }

        public OperatorBase(char sign) : base(sign)
        {
        }

        public abstract decimal Calculate(decimal left, decimal right);
    }
}
