using RPNCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPNCalculator.UserInterface
{
    public class CharInputValidator : IInputValidator
    {
        private readonly char[] _validChars = new char[]
        {
            '-', '+', '*', '/',
            '(', ')',
            '0','1','2','3','4','5','6','7','8','9'
        };

        public bool IsValidForCalculations(char c)
        {
            return _validChars.Contains(c);
        }
    }
}
