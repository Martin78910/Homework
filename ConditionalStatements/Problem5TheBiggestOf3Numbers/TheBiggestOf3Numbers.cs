using System;

namespace Problem5TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter number A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number C");
            double c = double.Parse(Console.ReadLine());
            if (a>=b && a>c)
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }
            else if (b>=c && b>a)
            {
                Console.WriteLine("The biggest number is: {0}", b);
            }
            else if (c>=a && a>b || c > a && a == b)
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
        }
    }
}
