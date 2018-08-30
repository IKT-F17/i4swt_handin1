using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Application
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculator calculator = new Calculator();

            int MathOperation;
            MathOperation = calculator.PrintMenuChoices();

            calculator.ActualCalculator(MathOperation);
        }
    }
}
