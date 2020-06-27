using NUnit.Framework;
using Calculator.Interfaces;
using Calculator.UserInterface;

namespace Calculator.Tests
{
    public class InputValidatorTests
    {
        private IInputValidator _inputValidator;

        [SetUp]
        public void Setup()
        {
            _inputValidator = new CharInputValidator();
        }

        [Test]
        public void ShouldPassAllNumbers()
        {
            Assert.IsTrue(_inputValidator.IsValidForCalculations('0'));
            Assert.IsTrue(_inputValidator.IsValidForCalculations('1'));
            Assert.IsTrue(_inputValidator.IsValidForCalculations('2'));
            Assert.IsTrue(_inputValidator.IsValidForCalculations('3'));
            Assert.IsTrue(_inputValidator.IsValidForCalculations('4'));
            Assert.IsTrue(_inputValidator.IsValidForCalculations('5')); 
            Assert.IsTrue(_inputValidator.IsValidForCalculations('6'));
            Assert.IsTrue(_inputValidator.IsValidForCalculations('7'));
            Assert.IsTrue(_inputValidator.IsValidForCalculations('8'));
            Assert.IsTrue(_inputValidator.IsValidForCalculations('9'));
        }
        [Test]
        public void ShouldPassBraces()
        {
            Assert.IsTrue(_inputValidator.IsValidForCalculations('('));
            Assert.IsTrue(_inputValidator.IsValidForCalculations(')'));
        }
        
        [Test]
        public void ShouldPassMultiplication()
        {
            Assert.IsTrue(_inputValidator.IsValidForCalculations('*'));
        }
        [Test]
        public void ShouldPassDivision()
        {
            Assert.IsTrue(_inputValidator.IsValidForCalculations('/'));
        }
        [Test]
        public void ShouldPassAddition()
        {
            Assert.IsTrue(_inputValidator.IsValidForCalculations('+'));
        }
        [Test]
        public void ShouldPassSubtraction()
        {
            Assert.IsTrue(_inputValidator.IsValidForCalculations('-'));
        }
        [Test]
        public void ShouldNotPassLetters()
        {
            Assert.IsFalse(_inputValidator.IsValidForCalculations('q'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('w'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('e'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('r'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('t'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('y'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('u'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('i'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('o'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('p'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('a'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('s'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('d'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('f'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('g'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('h'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('j'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('k'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('l'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('z'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('x'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('c'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('v'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('b'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('n'));
            Assert.IsFalse(_inputValidator.IsValidForCalculations('m'));
        }
        [Test]
        public void ShouldNotPassComma()
        {
            Assert.IsFalse(_inputValidator.IsValidForCalculations(','));
        }
        [Test]
        public void ShouldNotPassDot()
        {
            Assert.IsFalse(_inputValidator.IsValidForCalculations('.'));
        }
    }
}