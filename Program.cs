using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter symbol: ");
            string symbol = Console.ReadLine() ?? "default value";

            switch (symbol)
            {
                case "+":
                    res = num1 + num2;
                    Console.WriteLine("Result: " + res);
                    break;
                case "-" :
                    res = num1 - num2;
                    Console.WriteLine("Result: " + res);
                    break;
                case "*":
                    res = num1 * num2;
                    Console.WriteLine("Result: " + res);
                    break;
                case "/":
                    res = num1 / num2;
                    Console.WriteLine("Result: " + res);
                    break; 
                default:
                    Console.WriteLine("Invalid symbol");
                    break;
            }
        }
    }
}
