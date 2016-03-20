using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            string dateStringFirst = Console.ReadLine();
            string dateStringSecond = Console.ReadLine();
            string format = "dd.MM.yyyy";
            DateTime firstDate = DateTime.ParseExact(dateStringFirst, format,
            CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(dateStringSecond, format,
            CultureInfo.InvariantCulture);
            int difference = CalculateNumberDifferenceDates(firstDate, secondDate);
            Console.WriteLine("Days between: {0} ", difference);
        }
        private static int CalculateNumberDifferenceDates(DateTime firstDate, DateTime secondDate)
        {
            TimeSpan ts = secondDate - firstDate;
            int differenceInDays = ts.Days;
            return differenceInDays;
        }
    }
}
