﻿using System;

namespace NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
