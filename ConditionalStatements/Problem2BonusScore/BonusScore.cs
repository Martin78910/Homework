using System;

namespace Problem2BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number between 1 & 9");
            int number = int.Parse(Console.ReadLine());
            if (number == 1 || number == 2 || number == 3)
            {
                Console.WriteLine(number*10);
            }
            else if (number == 4 || number == 5 || number == 6)
            {
                Console.WriteLine(number*100);
            }
            else if (number == 7 || number == 8 || number == 9)
            {
                Console.WriteLine(number*1000);
            }
            else if (number <= 0 || number > 9)
            {
                Console.WriteLine("Invalid score");
            }
        
        }
    }
}
