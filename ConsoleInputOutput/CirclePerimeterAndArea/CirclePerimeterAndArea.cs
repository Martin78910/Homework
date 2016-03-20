using System;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Enter Circle Radius");
            double circleRadius = double.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter {0:F2}", 2 * Math.PI * circleRadius);
            Console.WriteLine("Area {0:F2}", Math.PI * Math.Pow(circleRadius, 2));
        }
    }
}
