﻿using System;


namespace Problem1FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            if (n == 0)
            {
                Console.WriteLine(1);
                return;
            }
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            Console.WriteLine("{0}", CalculateFibonacciNumbers(n));
        }
        private static int CalculateFibonacciNumbers(int n)
        {
            int x1 = 0;
            int x2 = 1;
            int x3 = 0;
            for (int i = 0; i < n; i++)
            {
                x3 = x1 + x2;
                x1 = x2;
                x2 = x3;
            }
            return x3;

        }
    }
}
