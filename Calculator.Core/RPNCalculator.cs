using Calculator.Core.Interfaces;
using Calculator.Core.Tokens;
using Calculator.Core.Tokens.Base;
using System;
using System.Collections;
using System.Collections.Generic;
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
        public string Calculate(string expression)
        {
            var formattedExpression = new Queue<Token>();
            try
            {
                formattedExpression = _RPNExpressionFormatter.FormatToRPN(expression);
            }
            catch (Exception e)
            {
                return e.Message;
            }

            var resStack = new Stack<Token>();

            while (formattedExpression.Count > 0)
            {
                var actualToken = formattedExpression.Dequeue();
                if (actualToken is Number)
                {
                    resStack.Push(actualToken);
                }
                else if (actualToken is OperatorBase)
                {
                    var a = (resStack.Pop() as Number);
                    var b = (resStack.Pop() as Number);

                    var calculationResult = new Number((actualToken as OperatorBase).Calculate(b.Value, a.Value).ToString());

                    resStack.Push(calculationResult);
                }
            }

            if (resStack.Count > 0)
            {
                return (resStack.Pop() as Number).Value.ToString();
            }
            return "0";
        }
    }
}
