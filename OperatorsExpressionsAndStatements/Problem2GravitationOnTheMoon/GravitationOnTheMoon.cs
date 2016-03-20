using System;

namespace Problem2GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("Enter your weight");
            double weight = double.Parse(Console.ReadLine());
            double weightOnTheMoon = weight * 17 / 100d;
            Console.WriteLine("Your weight on The Moon is {0}", weightOnTheMoon);
        }
    }
}
