using System;

namespace Problem6FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a four-digit integer number");
            int number = int.Parse(Console.ReadLine());
            int d = number % 10;
            int c = (number / 10) % 10;
            int b = (number / 10 / 10) % 10;
            int a = (number / 10 / 10 / 10) % 10;
            Console.WriteLine("The sum of digits is {0}", a + b + c + d);
            Console.WriteLine("The reversen number is:{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit in front:{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Second and third digits excanged:{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
