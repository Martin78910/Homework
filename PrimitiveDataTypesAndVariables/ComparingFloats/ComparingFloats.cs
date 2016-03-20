using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = double.Parse(Console.ReadLine());
            double compareVariable = 0.000001;
            double equal = Math.Abs(a - b);
            if (equal < compareVariable)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
