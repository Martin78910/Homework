using System;

namespace SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Write first number");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Write second number");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Write third number");
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(firstNumber + secondNumber + thirdNumber);
        }
    }
}
