using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;
            string symbol;
            char continueCalculating;

            do
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol: ");
                symbol = Console.ReadLine() ?? "default value";

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Result: " + res);
                        break;
                    case "-":
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
                Console.Write("Do you want to continue using calculator? (y/n): ");
                continueCalculating = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (char.ToLower(continueCalculating) == 'y');
            Console.WriteLine("Thank you for using the calculator!");
        }
    }
}
