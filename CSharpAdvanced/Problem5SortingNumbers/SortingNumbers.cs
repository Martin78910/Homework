using System;
using System.Collections.Generic;


namespace Problem5SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            System.Collections.Generic.List<int> numbers = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
            numbers.Sort();
            Console.WriteLine();
            foreach (var item in numbers)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
}
