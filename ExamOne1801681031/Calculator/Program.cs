using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to calculate some numbers? (yes or no) ");
            Console.ReadLine();

            Console.WriteLine("Enter first number:");
            double number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double number2 = double.Parse(Console.ReadLine());

            string symbole = Console.ReadLine();

            switch (symbole) // +, -, *, /
            {
                case "+":
                    Console.WriteLine("You did it!");
                    break;
                case "-":
                    Console.WriteLine("Try something else!");
                    break;
                case "*":
                    Console.WriteLine("Try with plus!");
                    break;
                case "/":
                    Console.WriteLine("Good job!");
                    break;

            }
        }
    }
}
