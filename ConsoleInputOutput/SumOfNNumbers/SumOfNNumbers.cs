﻿using System;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter n numbers: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
