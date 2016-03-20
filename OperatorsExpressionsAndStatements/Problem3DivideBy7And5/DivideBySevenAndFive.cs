using System;

namespace Problem3DivideBy7And5
{
    class DivideBySevenAndFive
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer");
            int firstNumber = int.Parse(Console.ReadLine());
            bool secondNumber = firstNumber % 7 == 0 && firstNumber % 5 == 0;
            if (secondNumber == true)
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
