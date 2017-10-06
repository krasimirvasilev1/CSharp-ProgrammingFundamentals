using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distancePerMetres = int.Parse(Console.ReadLine());
            float hoursNeededForThisDistance = int.Parse(Console.ReadLine());
            float minutesNeededForThisDistance = int.Parse(Console.ReadLine());
            float secondsNeededForThisDistance = int.Parse(Console.ReadLine());
            float secondsAll = (float)((hoursNeededForThisDistance * 60) * 60) + (minutesNeededForThisDistance * 60) + secondsNeededForThisDistance;
            float hoursAll = ((secondsAll / 60) / 60);
            float metersInKilometers = (float)distancePerMetres / 1000;
            float metersInMiles = (float)distancePerMetres / 1609;
            float metersPerSecond = (float)distancePerMetres / secondsAll;
            Console.WriteLine("{0}",metersPerSecond);
            Console.WriteLine("{0}", metersInKilometers/hoursAll);
            Console.WriteLine("{0}",metersInMiles/hoursAll);
        }
    }
}
