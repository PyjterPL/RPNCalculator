using Calculator.Core.Interfaces;
using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.UserInterface
{
    class MainConsole : IMainProgram
    {
        private readonly IInputValidator _inputValidator;
        private readonly ICalculator _calculator;
        private readonly string _menuMessage = "Insert string expression of mathematical operation. Press enter to calculate. \nOnly + - / * operations, braces and integers are allowed. \nPress 'c' to clean exspression.\nPress 'esc' to quit.";
        private string _input = string.Empty;

        public MainConsole(IInputValidator inputValidator, ICalculator calculator)
        {
            _inputValidator = inputValidator;
            _calculator = calculator;
        }
        
        public void Run()
        {
            DisplayMenu();
            HandleInput();
        }

        private void DisplayMenu()
        {
            Console.WriteLine(_menuMessage);
        }

        private void HandleInput()
        {
            while (true)
            {
                ConsoleKeyInfo pressedKey;
                do
                {
                    pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.Backspace)
                    {
                        if (_input.Length > 0)
                        {
                            _input = _input.Remove(_input.Length - 1);
                            Console.Write("\b \b");
                        }
                    }
                    else if(pressedKey.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }
                    else if(pressedKey.Key == ConsoleKey.C)
                    {
                        Console.Clear();
                        DisplayMenu();
                    }
                    else
                    {
                        bool isAllowedChar = _inputValidator.IsValidForCalculations(pressedKey.KeyChar);
                        if (isAllowedChar)
                        {
                            _input += pressedKey.KeyChar;
                            Console.Write(pressedKey.KeyChar);
                        }
                    }
                }
                while (pressedKey.Key != ConsoleKey.Enter);

                Console.WriteLine(_calculator.Calculate(_input));
            }
        }
    }
}
