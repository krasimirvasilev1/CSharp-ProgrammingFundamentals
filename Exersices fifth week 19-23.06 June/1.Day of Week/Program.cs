using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            var newDay = DateTime.ParseExact(day, "d-M-yyyy", CultureInfo.InvariantCulture);

            DateTime dayOfweek = new DateTime(newDay.Year, newDay.Month, newDay.Day);

            Console.WriteLine("{0}",dayOfweek.DayOfWeek);
        }
    }
}
