using System;

namespace Problem5ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer");
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number % 10;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = (number / 10 / 10) % 10;
            bool check = thirdDigit == 7;
            Console.WriteLine("Third digit 7? {0}", check);
        }
    }
}
