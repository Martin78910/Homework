using System;

namespace Problem2NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive integer");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 7 != 0 && i % 3 != 0)
                {
                    Console.Write("{0} ", i);
                }
            }            
            Console.WriteLine();
        }
    }
}
