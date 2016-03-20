using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16CountingAWordInAText
{
    class CountingAWordInAText
    {
        static void Main()
        {
            string searchedWord = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(searchedWord))
                {
                    counter++;
                }
            }
       
            Console.WriteLine(counter);
        }
    }
}
