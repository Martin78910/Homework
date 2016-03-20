using System;

namespace Problem14ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit position:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit value:");
            int valueBit = int.Parse(Console.ReadLine());
            if (valueBit == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine(result);
            }
            else
            {
                int mask = 1 << p;
                int result = n | mask;
                Console.WriteLine(result);
            }
                       
        }
    }
}
