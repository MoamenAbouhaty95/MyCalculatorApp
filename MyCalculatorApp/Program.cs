using System;

namespace MyCalculatorApp
{
    // Calculator class
    public class Calculator
    {
        public int Sum(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
        public int Multiply(int x, int y) => x * y;

        public double Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("\n Error: Cannot divide by zero!");
                return double.NaN;
            }
            return (double)x / y;
        }
    }

    // Main program
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Simple Calculator - MyCalculatorApp ";
            Calculator calc = new Calculator();

            // Header
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.WriteLine("═════                 SIMPLE CALCULATOR           ═════");
            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.ResetColor();

            // Get first number
            int num1 = ReadNumber("Enter the first number: ");

            Console.WriteLine("\n═══════════════════════════════════════════════════════");

            // Get second number
            int num2 = ReadNumber("Enter the second number: ");

            // Menu
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n───────────────────────────────────────────────────────");
            Console.WriteLine(" Choose an operation:");
            Console.WriteLine("   [1]. Add");
            Console.WriteLine("   [2]. Subtract");
            Console.WriteLine("   [3]. Multiply");
            Console.WriteLine("   [4]. Divide");
            Console.WriteLine("───────────────────────────────────────────────────────");
            Console.ResetColor();

            Console.WriteLine("\n═══════════════════════════════════════════════════════");
            int choice = ReadNumber("Enter your choice (1–4): ");

            double result = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n═══════════════════════════════════════════════════════");

            switch (choice)
            {
                case 1:
                    result = calc.Sum(num1, num2);
                    Console.WriteLine($"Result of {num1} + {num2} = {result}");
                    break;
                case 2:
                    result = calc.Subtract(num1, num2);
                    Console.WriteLine($"Result of {num1} - {num2} = {result}");
                    break;
                case 3:
                    result = calc.Multiply(num1, num2);
                    Console.WriteLine($"Result of {num1} × {num2} = {result}");
                    break;
                case 4:
                    result = calc.Divide(num1, num2);
                    Console.WriteLine($" Result of {num1} ÷ {num2} = {result}");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice! Please select between 1 and 4.");
                    Console.ResetColor();
                    return;
            }

            Console.WriteLine("═══════════════════════════════════════════════════════");
            Console.ResetColor();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Method for safely reading an integer
        static int ReadNumber(string message)
        {
            int number;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(message);
                Console.ResetColor();

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input! Please enter a valid number.\n");
                    Console.ResetColor();
                }
            }
        }
    }
}
