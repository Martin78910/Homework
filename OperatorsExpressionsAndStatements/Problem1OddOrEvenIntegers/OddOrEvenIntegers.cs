using System;

namespace Problem1OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number");
            int firstNumber = int.Parse(Console.ReadLine());
            bool oddNumber = firstNumber % 2 == 1;
            if (oddNumber == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
