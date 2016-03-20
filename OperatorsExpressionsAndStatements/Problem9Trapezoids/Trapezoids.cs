using System;

namespace Problem9Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Enter side A");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height H");
            double heightH = double.Parse(Console.ReadLine());
            Console.WriteLine("Area is {0}", (sideA + sideB)*heightH/2);
        }
    }
}
