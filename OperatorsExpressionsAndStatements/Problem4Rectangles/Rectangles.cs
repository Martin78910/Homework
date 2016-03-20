using System;

namespace Problem4Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Enter width");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            Console.WriteLine("Rectangle perimeter is {0} and area is {1}", perimeter, area);
        }
    }
}
