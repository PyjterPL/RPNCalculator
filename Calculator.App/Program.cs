using Microsoft.Extensions.DependencyInjection;
using Calculator.Core.Interfaces;
using Calculator.Interfaces;
using Calculator.UserInterface;
using System;
using System.Net.NetworkInformation;
using Calculator.Core;

namespace Calculator.App
{
    class Program
    {
        private static ServiceProvider _servicesProvider;
        private static void RegisterServices()
        {
            _servicesProvider = new ServiceCollection()
                .AddScoped<IMainProgram, MainConsole>()
                .AddScoped<IInputValidator, CharInputValidator>()
                .AddScoped<ICalculator, RPNCalculator>()
                .BuildServiceProvider();
        }
        static void Main(string[] args)
        {
            RegisterServices();
            _servicesProvider.GetService<IMainProgram>().Run();
        }
    }
}
