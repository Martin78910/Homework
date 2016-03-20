using System;

namespace Problem11BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("Enter an unsigned integer number");
            uint number = uint.Parse(Console.ReadLine());
            int p = 3;
            int numberRightP = (int)number >> p;
            int bit = numberRightP & 1;
            Console.WriteLine(bit);

        }
    }
}
