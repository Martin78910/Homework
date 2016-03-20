using System;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            Console.WriteLine("Is my gender is female? Enter yes or no!");
            string gender = Console.ReadLine();
            bool isFemale = gender == "no";
            Console.WriteLine("{0}", isFemale);
                        
        }
    }
}
