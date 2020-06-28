using Calculator.Core;
using Calculator.Core.Interfaces;
using Calculator.Core.Tokens;
using Calculator.Core.Tokens.Base;
using Calculator.Core.Tokens.Basic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.Tests
{
    class RPNExpressionFormatterTests
    {
        private IRPNExpressionFormatter _formatter;

        [SetUp]
        public void Setup()
        {
            _formatter = new DijkstraRPNExpressionFormatter(new TokenFactory());
        }

        [Test]
        public void BracketsTest()
        {
            var expectedQueue = new Queue<Token>();
            expectedQueue.Enqueue(new Number("2"));
            expectedQueue.Enqueue(new Number("3"));
            expectedQueue.Enqueue(new Addition("+"));
            expectedQueue.Enqueue(new Number("5"));
            expectedQueue.Enqueue(new Multiplication("*"));

            var resultQueue = _formatter.FormatToRPN("(2+3)*5");

            for (int i = 0; i < 5; i++)
            {
                var expected = expectedQueue.Dequeue();
                var result = resultQueue.Dequeue();
                Assert.AreEqual(expected.Entry, result.Entry);
                Assert.AreEqual(expected.GetType(), result.GetType());
            }

            if(resultQueue.Count > 0 || expectedQueue.Count > 0)
            {
                Assert.Fail();
            }
        }

        public void NoBracketsTest()
        {
            var expectedQueue = new Queue<Token>();
            expectedQueue.Enqueue(new Number("2"));
            expectedQueue.Enqueue(new Number("3"));
            expectedQueue.Enqueue(new Addition("+"));
            expectedQueue.Enqueue(new Number("5"));
            expectedQueue.Enqueue(new Multiplication("*"));

            var resultQueue = _formatter.FormatToRPN("2+3*5");

            for (int i = 0; i < 5; i++)
            {
                var expected = expectedQueue.Dequeue();
                var result = resultQueue.Dequeue();
                Assert.AreEqual(expected.Entry, result.Entry);
                Assert.AreEqual(expected.GetType(), result.GetType());
            }

            if (resultQueue.Count > 0 || expectedQueue.Count > 0)
            {
                Assert.Fail();
            }
        }
    }
}
