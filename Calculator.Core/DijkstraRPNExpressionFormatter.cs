using Calculator.Core.Interfaces;
using Calculator.Core.Tokens.Base;
using Calculator.Core.Tokens.Brackets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core
{
    public class DijkstraRPNExpressionFormatter : IRPNExpressionFormatter
    {
        private readonly ITokenFactory _tokenFactory;
        private const string _invalidExpressionMessage = "Invalid expression";
        public DijkstraRPNExpressionFormatter(ITokenFactory tokenFactory)
        {
            _tokenFactory = tokenFactory;
        }
        public Queue<Token> FormatToRPN(string expression)
        {
            var resultQueue = new Queue<Token>();
            var stack = new Stack<Token>();

            int pos = 0;

            while (pos < expression.Length)
            {
                var token = GetNextTokenFrom(ref pos, expression);
                if (token == null)
                {
                    break;
                }
                else if (token is NumberBase)
                {
                    resultQueue.Enqueue(token);
                }
                else if (token is LeftBracket)
                {
                    stack.Push(token);
                }
                else if (token is RightBracket)
                {
                    while (true)
                    {
                        var takenToken = stack.Pop();
                        if (takenToken is LeftBracket)
                        {
                            break;
                        }
                        else
                        {
                            resultQueue.Enqueue(takenToken);
                        }
                    }
                }
                else if (token is OperatorBase)
                {
                    if (stack.Count > 0)
                    {
                        var stackTop = stack.Peek();
                        var needToSearch = true;
                        if (stackTop != null && stackTop is OperatorBase)
                        {
                            while (needToSearch)
                            {
                                if (stackTop == null || !(stackTop is OperatorBase))
                                {
                                    break;
                                }

                                var o1 = token as OperatorBase;
                                var o2 = stackTop as OperatorBase;

                                if (o1.Priority <= o2.Priority)
                                {
                                    resultQueue.Enqueue(stack.Pop());
                                }
                                else 
                                {
                                    needToSearch = false;
                                }
                                stackTop = stack.Count > 0 ? stack.Peek() : null;
                            }
                        }
                    }

                    stack.Push(token);
                }
            }

            while(stack.Count > 0)
            {
                var nextToken = stack.Pop();

                if(nextToken is LeftBracket || nextToken is RightBracket)
                {
                    throw new ArgumentException(_invalidExpressionMessage);
                }

                resultQueue.Enqueue(nextToken);
            }

            return resultQueue;
        }

        private Token GetNextTokenFrom(ref int position, string expression)
        {
            Token result = null;
            var rest = expression.Substring(position);

            int count = 0;
            int pos = 0;
            while (count++ < rest.Length)
            {
                var cand = rest.Substring(0, count);
                var latest = _tokenFactory.GetToken(cand);
                if (latest != null)
                {
                    result = latest;
                    pos = count;
                }
                else
                {
                    break;
                }
            }
            if (result != null)
                position += pos;
            return result;
        }
    }
}
