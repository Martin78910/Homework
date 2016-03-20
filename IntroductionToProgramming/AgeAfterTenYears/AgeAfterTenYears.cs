using System;

namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("Enter your Birthday in format yyyy/mm/dd:");
            DateTime birthDay = new DateTime();
            birthDay = DateTime.Parse(Console.ReadLine());

            DateTime todaysDate = DateTime.Now;

            var MyAge = todaysDate.Year - birthDay.Year;

            Console.WriteLine("My Age is: " + MyAge);

            var myFutureAge = MyAge + 10;

            Console.WriteLine("My Age in 10 years will be: " + myFutureAge);        
        }
   }
}

