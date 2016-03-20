using System;

namespace Problem4MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.WriteLine("Enter number A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number C");
            double c = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 || a < 0 && b < 0 && c > 0 || a > 0 && b < 0 && c < 0 ||
                a < 0 && b > 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b > 0 && c > 0 || a > 0 && b < 0 && c > 0 || a > 0 && b > 0 && c < 0 ||
                a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
