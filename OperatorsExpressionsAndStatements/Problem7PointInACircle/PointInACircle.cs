using System;
namespace Problem7PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("Enter points x and y for circle K({0, 0}, 2):");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool check = Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2) <= Math.Pow(2, 2);
            Console.WriteLine("Point inside? {0}", check);
        }
    }
}
