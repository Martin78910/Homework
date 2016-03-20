using System;

namespace NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondNumber = double.Parse(Console.ReadLine());
            double result = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("Greater is {0}", result);
        }
    }
}
