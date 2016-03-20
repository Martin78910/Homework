using System;

namespace Problem6TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter number A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number C");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number D");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number E");
            double e = double.Parse(Console.ReadLine());
            if (a > b && b == c && c < d && d > e)
            {
                Console.WriteLine("The biggest number is: {0}", a);
            }
            else if (a > b && a < c && c > d && d == e)
            {
                Console.WriteLine("The biggest number is: {0}", c);
            }
            else if (b > a && b > c && c > d && d > e)
            {
                 Console.WriteLine("The biggest number is: {0}", b);
            }
            else if (a > b && a == c && c < d && d == e)
            {
                Console.WriteLine("The biggest number is: {0}", d);
            }
            else if (a < b && e > c && c > d && d < e)
            {
                Console.WriteLine("The biggest number is: {0}", e);
            }
        }
    }
}
