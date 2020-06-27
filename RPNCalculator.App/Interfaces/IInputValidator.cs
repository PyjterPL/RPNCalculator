using System;
using System.Collections.Generic;
using System.Text;

namespace RPNCalculator.Interfaces
{
    public interface IInputValidator
    {
        bool IsValidForCalculations(char c);
    }
}
