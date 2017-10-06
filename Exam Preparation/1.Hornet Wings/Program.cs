using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal wingFlaps = decimal.Parse(Console.ReadLine());
            decimal distanceInMetersPer1000Flaps = decimal.Parse(Console.ReadLine());
            decimal wingFlapsTillBreak = decimal.Parse(Console.ReadLine());

            decimal metersTraveled = (wingFlaps / 1000) * distanceInMetersPer1000Flaps;
            decimal secondsNeeded = (wingFlaps / 100) + (int)(wingFlaps / wingFlapsTillBreak) * 5;

            Console.WriteLine($"{metersTraveled:F2} m.");
            Console.WriteLine($"{secondsNeeded:F0} s.");
            
        }
    }
}
