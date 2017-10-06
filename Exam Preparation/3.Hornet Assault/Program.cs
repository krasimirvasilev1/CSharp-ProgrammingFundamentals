using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> bees = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            var beesBases = 0;
            var numberOfRotations = bees.Count;

            for (int i = 1; i <= numberOfRotations; i++)
            {
                if ((i == 1 && bees.Count == 0) || (i== 1 && hornets.Count == 0))
                {
                    break;
                }

                var sumOfHornets = hornets.Sum();
                var sumOfBees = bees[beesBases];

                if (sumOfHornets > sumOfBees)
                {
                    bees.RemoveAt(beesBases);
                }
                else if (sumOfHornets < sumOfBees)
                {
                    bees[beesBases] = sumOfBees - sumOfHornets;
                    beesBases++;
                    hornets.RemoveAt(0);
                    sumOfHornets = hornets.Sum();
                }
                else
                {
                    bees.RemoveAt(beesBases);
                    hornets.RemoveAt(0);
                }
            }

            if (bees.Sum() > 0)
            {
                Console.WriteLine(string.Join(" ", bees));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
