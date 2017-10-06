using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> drivers = Console.ReadLine().Split().ToList();
            List<double> zones = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<int> checkPoints = Console.ReadLine().Split().Select(int.Parse).ToList();

            var fuel = 0.0m;
            var zone = 0;
            for (int i = 0; i < drivers.Count; i++)
            {
                var driverName = drivers[i];
                fuel = (decimal)driverName[0];
                for (int j = 0; j < zones.Count; j++)
                {
                   
                        fuel = fuel - (decimal)(zones[j]);
                    
                    for (int k = 0; k < checkPoints.Count; k++)
                    {
                        if (j == checkPoints[k])
                        {
                            fuel = fuel + (decimal)(zones[j] * 2);
                        }
                    }
                    if (fuel < 0)
                    {
                        zone = j;
                        break;
                    }
                }
                if (fuel < 0)
                {
                    Console.WriteLine($"{driverName} - reached {zone}");
                }
                else
                {
                    Console.WriteLine($"{driverName} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
