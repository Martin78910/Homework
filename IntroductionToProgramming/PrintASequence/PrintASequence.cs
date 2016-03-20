using System;

namespace PrintASequence
{
    class PrintASequence
    {
        static void Main()
        {
            for (int i = 2; i < 12; i++)
            {
                if ((i & 1) == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
