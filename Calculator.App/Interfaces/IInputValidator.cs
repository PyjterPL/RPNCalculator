using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Interfaces
{
    public interface IInputValidator
    {
        bool IsValidForCalculations(char c);
    }
}
