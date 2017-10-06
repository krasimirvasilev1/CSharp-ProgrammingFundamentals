using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNum = int.Parse(Console.ReadLine());
            int endingNum = int.Parse(Console.ReadLine());

            var allPrimes = FindPrimesInRange(startingNum, endingNum);
            Console.WriteLine(string.Join(", ",allPrimes));

        }
        public static List<int> FindPrimesInRange(int startingNum, int endingNum)
        {
            var allPrimes = new List<int>();

            for (int i = startingNum; i <= endingNum; i++)
            {
                if (IsPrime(i))
                {
                    allPrimes.Add(i);
                }

            }
            return allPrimes;
        }

        public static bool IsPrime(long number)
        {

            if (number == 2)
            {
                return true;

            }
            if (number == 1 || number == 0)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;

                }

            }

            return true;
        }

    }
}


