using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            for (int i = 0, num = 2; i < 1000; i++, num++)
        {
            if (num % 2 == 0)
            {
                Console.Write("{0},", num);
            }
            else
            {
                num = num * (-1);
                Console.Write("{0},", num);
                num = num * (-1);
            }
        }
        Console.WriteLine();
    }
        }
}

