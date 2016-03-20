using System;


namespace Problem6CalculateN_K_
{
    class CalculaneNK

    {
        static void Main()
        {
            Console.WriteLine("Enter two integers n and k in the range (1 < k < n < 100)");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sumK = 1;
            int sumN = 1;
            for (int i = 1; i <= n; i++)
            {
                sumN *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                sumK *= i;
            }
            int sumF = sumN / sumK;
            Console.WriteLine(sumF);
        }
    }
}
