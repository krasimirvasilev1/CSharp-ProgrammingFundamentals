using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
