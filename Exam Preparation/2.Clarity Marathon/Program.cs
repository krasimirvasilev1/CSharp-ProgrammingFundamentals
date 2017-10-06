using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Clarity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDays = decimal.Parse(Console.ReadLine());
            var runnersInTheMarathon = decimal.Parse(Console.ReadLine());
            var numberOfLapsAverage = decimal.Parse(Console.ReadLine());
            var lapLength = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            var runnersThatCanParticipate = marathonDays * trackCapacity;
            if (runnersThatCanParticipate > runnersInTheMarathon)
            {
                runnersThatCanParticipate = runnersInTheMarathon;
            }

            decimal totalMeters = ((runnersThatCanParticipate * numberOfLapsAverage) * lapLength);
            decimal totalKilometers = totalMeters / 1000;

            decimal totalMoneyRaised = totalKilometers * moneyPerKilometer;

            Console.WriteLine("Money raised: {0:F2}",totalMoneyRaised);


        }
    }
}
