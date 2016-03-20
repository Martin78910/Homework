using System;

namespace Problem1ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Enter number A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0}" + " " + "{1}", b, a);
            }
            else
            {
                Console.WriteLine("{0}" + " " + "{1}", a, b);
            }
            
        }
    }
}
