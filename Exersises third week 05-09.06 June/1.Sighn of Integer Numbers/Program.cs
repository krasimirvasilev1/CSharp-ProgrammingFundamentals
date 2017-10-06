using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sighn_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSigh(int.Parse(Console.ReadLine()));
        }
        public static void PrintSigh (int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", number);
            }
        }
    }
}
