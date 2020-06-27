using Calculator.Core.Interfaces;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Calculator.Core
{
    public class RPNCalculator : ICalculator
    {
        private readonly IRPNExpressionFormatter _RPNExpressionFormatter;
        public RPNCalculator(IRPNExpressionFormatter RPNExpressionFormatter)
        {
            _RPNExpressionFormatter = RPNExpressionFormatter;
        }
        public double Calculate(string expression)
        {
            throw new NotImplementedException();
        }
    }
}
