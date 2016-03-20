using System;


namespace Problem12ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit position");
            int position = int.Parse(Console.ReadLine());
            int numberRightP = number >> position;
            int bit = numberRightP & 1;
            Console.WriteLine(bit);
        }
    }
}
