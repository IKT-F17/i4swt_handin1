using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {   
        // Addition
        public double Add(double a, double b)
        {
            return a + b;
        } 
        // Subtraction
        public double Subtract(double a, double b)
        { 
            return a-b;
        }
        // Multiply
        public double Multiply(double a, double b)
        {
            if (a == 0.0 || b == 0.0)
                throw new ArgumentException("Something went wrong, or you entered 0 as a value to be multiplied");
            double Sum;
            Sum = a * b;
            return Sum;
        }
        // Power
        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp); 
        }

        // Menu Choice ''test''
        public int PrintMenuChoices()
        {
            string MenuChoice;
            int actualChoice;
            int funcReturn = 0;

            Console.WriteLine("Press for following arithmetic operations:");
            Console.WriteLine("1. Add two double values");
            Console.WriteLine("2. Subtract one double value from another");
            Console.WriteLine("3. Multiply two double values");
            Console.WriteLine("4. Find a value to the power of n value");

            MenuChoice = Console.ReadLine();
            actualChoice = Convert.ToInt32(MenuChoice);
           
            switch (actualChoice)
            {
                case 1:
                    Console.WriteLine("you have chosen to add two value, now enter them concurrently");
                    funcReturn = 1; 
                    break;
                case 2:
                    Console.WriteLine("you have chosen to subtract two values from each other, now enter them concurrently");
                    funcReturn = 2;
                    break;
                case 3:
                    Console.WriteLine("you have chosen to multiply two values, now enter them concurrently");
                    funcReturn = 3;
                    break;
                case 4:
                    Console.WriteLine("you have chosen the 'to the power' function, now enter them concurrently");
                    funcReturn = 4;
                    break;
            }

            return funcReturn;
        }
        // Calculator ''test''
        public void ActualCalculator(int duty)
        {
            Calculator cal = new Calculator();
            string A, B;
            double a, b;

            if (duty == 1)
            {
                A = Console.ReadLine();
                a = Convert.ToDouble(A);
                B = Console.ReadLine();
                b = Convert.ToDouble(B);
                Console.WriteLine("The sum of " + a + "+" + b + " is: " + cal.Add(a, b));
            }

            if (duty == 2)
            {
                A = Console.ReadLine();
                a = Convert.ToDouble(A);
                B = Console.ReadLine();
                b = Convert.ToDouble(B);
                Console.WriteLine("The sum of " + a + "-" + b + " is: " + cal.Subtract(a, b));
            }

            if (duty == 3)
            {
                A = Console.ReadLine();
                a = Convert.ToDouble(A);
                B = Console.ReadLine();
                b = Convert.ToDouble(B);
                Console.WriteLine("The sum of " + a + " times " + b + " is: " + cal.Multiply(a, b));
            }

            if (duty == 4)
            {
                A = Console.ReadLine();
                a = Convert.ToDouble(A);
                B = Console.ReadLine();
                b = Convert.ToDouble(B);
                Console.WriteLine("The sum of x " + a + " to the power of " + b + " is: " + cal.Power(a, b));
            }

        }

    }
}


