using Microsoft.Extensions.DependencyInjection;
using RPNCalculator.Interfaces;
using RPNCalculator.UserInterface;
using System;
using System.Net.NetworkInformation;

namespace RPNCalculator.App
{
    class Program
    {
        private static ServiceProvider _servicesProvider;
        private static void RegisterServices()
        {
            _servicesProvider = new ServiceCollection()
                .AddScoped<IMainProgram, MainConsole>()
                .AddScoped<IInputValidator, CharInputValidator>()
                .BuildServiceProvider();
        }
        static void Main(string[] args)
        {
            RegisterServices();
            _servicesProvider.GetService<IMainProgram>().Run();
        }
    }
}
