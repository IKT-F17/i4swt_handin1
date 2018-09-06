using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {   
        public double Accumulator { get; private set; } // <-- Class-property/"Memberdata"
        
        public Calculator() => Accumulator = 0; // initialized to 0 to begin with, since no calculations has been made. 
        
        // Addition
        public double Add(double a, double b)
        {
            return a + b;
        } 
        
    // Subtraction
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        
    // Multiply
        public double Multiply(double a, double b)
        {
            return a * b;
        }
    // Divider
        public double Divide(double a, double b)
        {
            try
            {
                return a / b;
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error you made a division with ZERO");
                Console.WriteLine(e.Message);
                return -42;
            }

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
            Console.WriteLine("5. Divide a double value, with another");

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
                case 5:
                    Console.WriteLine("you have chosen the divider function, now enter them concurrently");
                    funcReturn = 5;
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
                Console.WriteLine($"The sum of {a} + {b} is: {cal.Add(a, b)}");
                Accumulator = cal.Add(a, b);
            }

            if (duty == 2)
            {
                A = Console.ReadLine();
                a = Convert.ToDouble(A);
                B = Console.ReadLine();
                b = Convert.ToDouble(B);
                Console.WriteLine($"The sum of {a} - {b} is: {cal.Subtract(a, b)}");
                Accumulator = cal.Subtract(a, b);
            }

            if (duty == 3)
            {
                A = Console.ReadLine();
                a = Convert.ToDouble(A);
                B = Console.ReadLine();
                b = Convert.ToDouble(B);
                Console.WriteLine($"The sum of {a} * {b} is: {cal.Multiply(a, b)}");
                Accumulator = cal.Multiply(a, b);
            }

            if (duty == 4)
            {
                A = Console.ReadLine();
                a = Convert.ToDouble(A);
                B = Console.ReadLine();
                b = Convert.ToDouble(B);
                Console.WriteLine($"The sum of x {a} ^ {b} is: {cal.Power(a, b)}");
                Accumulator = cal.Power(a, b);
            }
            if (duty == 5)
            {
                A = Console.ReadLine();
                a = Convert.ToDouble(A);
                B = Console.ReadLine();
                b = Convert.ToDouble(B);
                Console.WriteLine($"The sum of {a} / {b} is: {cal.Divide(a, b)}");
                Accumulator = cal.Divide(a, b);
            }

        }
    }
}


