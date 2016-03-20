using System;


namespace Problem1NumbersFrom1ToN
{
    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive integer");
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= n)
            {
                Console.Write("{0} ", counter);
                counter++;
            }
            Console.WriteLine();
         
        }
    }
}
