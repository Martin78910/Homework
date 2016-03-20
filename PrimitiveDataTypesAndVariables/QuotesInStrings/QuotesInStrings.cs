using System;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string one = @"""use""";
            string two = "of quotations causes difficulties";
            string three = "\"use\"";
            Console.WriteLine("The " + one + two + ".");
            Console.WriteLine("The " + three + two + ".");
        }
    }
}
