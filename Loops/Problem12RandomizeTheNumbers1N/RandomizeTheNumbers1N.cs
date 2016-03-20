﻿using System;


namespace Problem12RandomizeTheNumbers1N
{
    class RandomizeTheNumbers1N
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer n:");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int randomNumber = 1;
            int countNumbers = 0;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                randomNumber = rnd.Next(1, n + 1);
                num[i] = randomNumber;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (num[i] == num[j])
                    {
                        num[j] = 0;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                randomNumber = rnd.Next(1, n + 1);
                if (num[i] == 0)
                {
                    i--;
                }
                for (int j = 0; j < n; j++)
                {
                    if (num[j] == randomNumber)
                    {
                        randomNumber = rnd.Next(1, n + 1);
                        countNumbers = 0;
                        j--;
                    }
                    else
                    {
                        countNumbers++;
                    }
                }
                if (countNumbers == n)
                {
                    countNumbers = 0;
                    for (i = 0; i < n; i++)
                    {
                        if (num[i] == 0)
                        {
                            num[i] = randomNumber;
                            break;
                        }
                    }
                }
            }
            foreach (var item in num)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
