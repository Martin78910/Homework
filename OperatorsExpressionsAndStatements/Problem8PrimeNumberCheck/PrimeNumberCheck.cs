using System;

namespace Problem8PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive integer number between 2 and 100");
            int n = int.Parse(Console.ReadLine());
           
             while (n < 2 || n > 100)
        {
            Console.WriteLine("Try again");
            n = int.Parse(Console.ReadLine());
        }
        bool isPrime = true;
        int counter = 1;
        
        while (counter <= Math.Sqrt(n))
        {
            if (n % counter == 0 && counter > 1)
            {
                isPrime = false;
            }
            counter++;
        }
        Console.WriteLine("Is your number prime?\n{0}", isPrime);
        }
    }
}

