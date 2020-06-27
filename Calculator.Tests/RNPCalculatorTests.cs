using NUnit.Framework;
using Calculator.Interfaces;
using Calculator.UserInterface;
using Calculator.Core.Interfaces;
using Calculator.Core;

namespace Calculator.Tests
{
    class RNPCalculatorTests
    {
        private ICalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new RPNCalculator(new DijkstraRPNExpressionFormatter());
        }

        [Test]
        public void FIS_SSTTestCases()
        {
            Assert.AreEqual(14, _calculator.Calculate("4+5*2"));
            Assert.AreEqual(6.5, _calculator.Calculate("4+5/2"));
            Assert.AreEqual(5.5, _calculator.Calculate("4+5/2-1"));
        }
    }
}
