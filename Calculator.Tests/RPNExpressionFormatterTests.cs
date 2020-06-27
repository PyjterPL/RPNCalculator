using Calculator.Core;
using Calculator.Core.Interfaces;
using Calculator.Core.Tokens;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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
        public void BracesTest()
        {
            Assert.Fail();
            //ToDo
            //Assert.AreEqual("2 3 + 5 *", _formatter.FormatToRPN("(2+3)*5"));
            //Assert.AreEqual("2 7 + 3 / 14 3 - 4 * + 2 /", _formatter.FormatToRPN("((2+7)/3+(14-3)*4)/2"));
        }
    }
}
