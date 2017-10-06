using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            var Prime = IsPrime(number);
            Console.WriteLine(Prime);

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
