using System;

namespace RectangleAria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въдеди а:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи б:");
            int b = int.Parse(Console.ReadLine());

            double S = a * b;

            Console.WriteLine("Лицето на правоъгълника е:" + S);
            Console.ReadLine();
        }
    }
}
