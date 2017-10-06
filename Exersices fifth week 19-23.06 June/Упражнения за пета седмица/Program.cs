using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнения_за_пета_седмица
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = Console.ReadLine();
            var date2 = Console.ReadLine();

            var startingDate = DateTime.ParseExact(date1, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endingDate = DateTime.ParseExact(date2, "dd-MM-yyyy", CultureInfo.InvariantCulture);

          
            var holidays = new[]
            {
            "01 01",
            "03 03",
            "01 05",
            "06 05",
            "24 05",
            "06 09",
            "22 09",
            "01 11",
            "24 12",
            "25 12",
            "26 12"
            }.Select(a => DateTime.ParseExact(a, "dd MM", CultureInfo.InvariantCulture)).ToArray();

            var workingDays = 0;

            for (DateTime i = startingDate; i <= endingDate; i = i.AddDays(1)) 
            {
                var IsSaturadyOrSunday = i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday;

                var IsOtherHoliday = holidays.Any(d => d.Day == i.Day && d.Month == i.Month);

                if (!(IsSaturadyOrSunday || IsOtherHoliday))
                {
                    workingDays++;

                }
                i.AddDays(1);
            }
            
            Console.WriteLine(workingDays);
        }
    }
}
