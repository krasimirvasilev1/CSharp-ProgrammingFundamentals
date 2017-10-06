using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime leavingSoftuni = DateTime.Parse(Console.ReadLine());
            long numberOfSteps = long.Parse(Console.ReadLine());
            long timeInSecondsForEachStep = long.Parse(Console.ReadLine());

            long timeSumed = numberOfSteps * timeInSecondsForEachStep;
            var result = timeSumed % 86400;
            leavingSoftuni = leavingSoftuni.AddSeconds(result);

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}",leavingSoftuni);
        }
    }
}
