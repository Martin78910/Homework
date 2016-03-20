using System;

namespace Problem15BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.WriteLine("Enter unsigned integer number:");
            uint n = uint.Parse(Console.ReadLine());
            uint result = 0;
            uint nRightP = n >> 3;
            uint bit3 = nRightP & 1;
            nRightP = n >> 24;
            uint bit24 = nRightP & 1;
            nRightP = n >> 4;
            uint bit4 = nRightP & 1;
            nRightP = n >> 25;
            uint bit25 = nRightP & 1;
            nRightP = n >> 5;
            uint bit5 = nRightP & 1;
            nRightP = n >> 26;
            uint bit26 = nRightP & 1;
            if (bit3 == 0 && bit24 == 1)
            {
                int mask = ~(1 << 24);       
                result = n & (uint)mask;
                mask = 1 << 3;             
                result = result | (uint)mask;
            }
            else if (bit3 == 1 && bit24 == 0)
            {
                int mask = 1 << 24;       
                result = n | (uint)mask;
                mask = ~(1 << 3);         
                result = result & (uint)mask;
            }
            if (bit4 == 0 && bit25 == 1)
            {
                int mask = ~(1 << 25);   
                if (bit3 == 1 && bit24 == 1 || bit3 == 0 && bit24 == 0)
                {
                    result = n & (uint)mask;
                }
                else
                {
                    result = result & (uint)mask;
                }
                mask = 1 << 4;                  
                result = result | (uint)mask;
            }
            else if (bit4 == 1 && bit25 == 0)
            {
                int mask = 1 << 25;       
                if (bit3 == 1 && bit24 == 1 || bit3 == 0 && bit24 == 0)
                {
                    result = n | (uint)mask;
                }
                else
                {
                    result = result | (uint)mask;
                }
                mask = ~(1 << 4);         
                result = result & (uint)mask;
            }
            if (bit5 == 0 && bit26 == 1)
            {
                int mask = ~(1 << 26);    
                if ((bit3 == 1 && bit24 == 1 || bit3 == 0 && bit24 == 0) &&
                    (bit4 == 0 && bit25 == 0 || bit4 == 0 && bit25 == 0))
                {
                    result = n & (uint)mask;
                }
                else
                {
                    result = result & (uint)mask;
                }
                mask = 1 << 5;          
                result = result | (uint)mask;
            }
            else if (bit5 == 1 && bit26 == 0)
            {
                int mask = 1 << 26;         
                if ((bit3 == 1 && bit24 == 1 || bit3 == 0 && bit24 == 0) &&
                   (bit4 == 0 && bit25 == 0 || bit4 == 0 && bit25 == 0))
                {
                    result = n | (uint)mask;
                }
                else
                {
                    result = result | (uint)mask;
                }
                mask = ~(1 << 5);           
                result = result & (uint)mask;
            }
            Console.WriteLine(result);
        }
    }
}
