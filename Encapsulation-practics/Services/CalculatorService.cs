using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Encapsulation_practics.Services
{
    internal class CalculatorService
    {
      
         public double Calculation(double number1,double number2,char operation)
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                  result = number1+number2;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine(result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine(result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine(result);
                    break;
                default: 
                    break;
            }return result;
        }






    }
}

