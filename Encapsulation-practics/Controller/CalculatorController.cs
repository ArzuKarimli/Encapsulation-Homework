using Encapsulation_practics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_practics.Controller
{
    internal class CalculatorController
    {
        public void Calc()
        {
            
            Console.WriteLine("Enter first number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("choose which action you want");
            char operation = Convert.ToChar(Console.ReadLine());
            CalculatorService calculatorService = new CalculatorService();
            double result = calculatorService.Calculation(number1, number2, operation);
        }

    }
}
