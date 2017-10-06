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
                int distancePerMetres = int.Parse(Console.ReadLine());
                int hoursNeededForThisDistance = int.Parse(Console.ReadLine());
                int minutesNeededForThisDistance = int.Parse(Console.ReadLine());
                int secondsNeededForThisDistance = int.Parse(Console.ReadLine());
                double secondsAll = (double)((hoursNeededForThisDistance * 60) * 60) + (minutesNeededForThisDistance * 60) + secondsNeededForThisDistance;
                double hoursAll = ((secondsAll / 60) / 60);
                double metersInKilometers = distancePerMetres / 1000;
                double metersInMiles = (double)distancePerMetres / 1609;
                double metersPerSecond = distancePerMetres / secondsAll;
                Console.WriteLine($"{metersPerSecond}");
                Console.WriteLine($"{metersInKilometers / hoursAll}");
                Console.WriteLine($"{metersInMiles / hoursAll}");
            }
        }
    }
