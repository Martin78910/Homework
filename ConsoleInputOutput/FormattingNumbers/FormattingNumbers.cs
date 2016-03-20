using System;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            double c = double.Parse(Console.ReadLine());
            string binary = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:0.##}|{3,-10:F3}|", a, binary, b, c);
        }
    }
}
