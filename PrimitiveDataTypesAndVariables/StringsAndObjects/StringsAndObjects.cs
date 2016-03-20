using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string greeting = "Hello";
            string toWhom = "World";
            object concatenatedString = greeting + " " + toWhom;
            string result = (string)concatenatedString;
            Console.WriteLine(result);
        }
    }
}
